using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Vision;

namespace ImagePartClassifier
{
    public partial class MainForm : Form
    {
        private Bitmap imageFull;
        private List<ModelInput> imagesForModel;
        public MainForm()
        {
            InitializeComponent();
            imagesForModel = new List<ModelInput>();
            imageFull = null;
            cbArchitecture.DataSource = Enum.GetValues(typeof(ImageClassificationTrainer.Architecture));
        }

        private void btnFbd_Click(object sender, EventArgs e)
        {
            if (fbdOutput.ShowDialog() == DialogResult.OK)
            {
                tbFolderPath.Text = fbdOutput.SelectedPath;
                btnOfd.Enabled = true;
            }
        }

        private void btnOfd_Click(object sender, EventArgs e)
        {
            if (ofdImage.ShowDialog() == DialogResult.OK)
            {
                tbImagePath.Text = ofdImage.FileName;
            }

            imageFull = new Bitmap(tbImagePath.Text);

            var path0 = tbFolderPath.Text + "\\" + "True";
            var path1 = tbFolderPath.Text + "\\" + "False";
            Directory.CreateDirectory(path0);
            Directory.CreateDirectory(path1);

            DisplayCurrentPart();
            btnAccept.Enabled = true;
            btnReject.Enabled = true;
            tbPartNumber.Enabled = true;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            SaveImagePartToFile(true);
            DisplayCurrentPart();
            IncrementCurrentPartNumber();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            SaveImagePartToFile(false);
            DisplayCurrentPart();
            IncrementCurrentPartNumber();
        }

        private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                btnReject.PerformClick();
            }
            if (e.KeyCode == Keys.D)
            {
                btnAccept.PerformClick();
            }

        }
        private void tbPartNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbPartNumber_TextChanged(object sender, EventArgs e)
        {
            DisplayCurrentPart();
        }

        private void DisplayCurrentPart()
        {
            var partNumber = GetCurrentPartNumber();
            var partsInRow = imageFull.Width / 64;
            var Y = partNumber / partsInRow;

            var widthRemainder = imageFull.Width % 64;
            var fixedWidth = imageFull.Width - widthRemainder;
            var X = partNumber * 64 - (Y * fixedWidth);

            var rectClone = new Rectangle(X, Y * 64, 64, 64);
            var imagePart = imageFull.Clone(rectClone, imageFull.PixelFormat);

            lblPartCountVal.Text = ((imageFull.Width / 64) * (imageFull.Height / 64)).ToString();
            pbImagePart.Image = imagePart;
            tbPartNumber.Text = partNumber.ToString();
        }

        private void SaveImagePartToFile(bool isAccepted)
        {
            var imagePart = pbImagePart.Image;
            var imagePartNumber = tbPartNumber.Text;
            var imagePath = tbFolderPath.Text + "\\" + isAccepted.ToString() + "\\" + imagePartNumber + ".png";

            using (var memory = new MemoryStream())
            {
                using (var fs = new FileStream(imagePath, FileMode.Create, FileAccess.ReadWrite))
                {
                    imagePart.Save(memory, ImageFormat.Png);
                    byte[] bytes = memory.ToArray();
                    fs.Write(bytes, 0, bytes.Length);
                }
            }
        }

        private int GetCurrentPartNumber() => tbPartNumber.Text == String.Empty ? 0 : int.Parse(tbPartNumber.Text);

        private void IncrementCurrentPartNumber() => tbPartNumber.Text = (GetCurrentPartNumber() + 1).ToString();

        private void btnFbdPredict_Click(object sender, EventArgs e)
        {
            if (fbdOutput.ShowDialog() == DialogResult.OK)
            {
                tbFoldersPath.Text = fbdOutput.SelectedPath;
                imagesForModel.Clear();

                var imagesTrue = LoadImagesFromDirectory(fbdOutput.SelectedPath + "\\" + "True");
                imagesForModel.AddRange(imagesTrue);
                lblImage1CountValue.Text = imagesTrue?.Count().ToString();

                var imagesFalse = LoadImagesFromDirectory(fbdOutput.SelectedPath + "\\" + "False");
                imagesForModel.AddRange(imagesFalse);
                lblImage0CountValue.Text = imagesFalse?.Count().ToString();

                if (imagesTrue == null || imagesTrue.Count() == 0 || imagesFalse == null || imagesFalse.Count() == 0)
                    MessageBox.Show("Należy wybrać ścieżkę zawierającą dwa foldery o nazwach 'False' i 'True'," +
                        " w których znajdują się pliki .png lub .jpg", "Błąd");

                SetCreateModelState();
            }
        }

        private void btnCreateModel_Click(object sender, EventArgs e)
        {
            ImageClassificationTrainer.Architecture architecture;
            Enum.TryParse<ImageClassificationTrainer.Architecture>(cbArchitecture.SelectedValue.ToString(), out architecture);
            tbModelOutputInfo.AppendText("Please wait as the model is being created, trained and evaluated. This can take a while." + System.Environment.NewLine);
            SetViewCreateModelState(false);

            new Thread(() =>
            {
                ModelBuilder.CreateModel(tbFoldersPath.Text, tbModelName.Text, imagesForModel, architecture);
                Invoke((MethodInvoker)delegate
                {
                    SetViewCreateModelState(true);
                    tbModelOutputInfo.AppendText($"Model has been saved alongside metrics log in {tbFoldersPath.Text}." + System.Environment.NewLine);
                });
            }).Start();
        }

        private IEnumerable<ModelInput> LoadImagesFromDirectory(string folder)
        {
            var files = Directory.GetFiles(folder, "*", searchOption: SearchOption.AllDirectories);
            foreach (var file in files)
            {
                if ((Path.GetExtension(file) != ".jpg") && (Path.GetExtension(file) != ".png"))
                    continue;

                var label = Directory.GetParent(file).Name;

                yield return new ModelInput()
                {
                    ImageSource = file,
                    Label = label
                };
            }
        }

        private void SetViewCreateModelState(bool state)
        {
            btnBrowseFoldersPath.Enabled = state;
            btnCreateModel.Enabled = state;
            tbModelName.Enabled = state;
            cbArchitecture.Enabled = state;
            tabControl.Enabled = state;
        }

        private void tbModelName_TextChanged(object sender, EventArgs e)
        {
            SetCreateModelState();
        }

        private void SetCreateModelState()
        {
            if (tbModelName.Text != null && tbModelName.Text != "" && 
                tbFoldersPath.Text != null && tbFoldersPath.Text != "" &&
                lblImage1CountValue.Text != null && lblImage1CountValue.Text != "" &&
                lblImage0CountValue.Text != null && lblImage0CountValue.Text != "0")
            {
                btnCreateModel.Enabled = true;
            }
            else
            {
                btnCreateModel.Enabled = false;
            }
        }

        private void btnBrowseModelPredit_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowseImagePredit_Click(object sender, EventArgs e)
        {

        }
    }
}
