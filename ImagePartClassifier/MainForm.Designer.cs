namespace ImagePartClassifier
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fbdOutput = new System.Windows.Forms.FolderBrowserDialog();
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            this.tabPageCreateModel = new System.Windows.Forms.TabPage();
            this.tlpCreateModel = new System.Windows.Forms.TableLayoutPanel();
            this.tbModelOutputInfo = new System.Windows.Forms.TextBox();
            this.tlpTopRightCreateModel = new System.Windows.Forms.TableLayoutPanel();
            this.lblFolderPathNames = new System.Windows.Forms.Label();
            this.btnBrowseFoldersPath = new System.Windows.Forms.Button();
            this.tbFoldersPath = new System.Windows.Forms.TextBox();
            this.btnCreateModel = new System.Windows.Forms.Button();
            this.pbFrogCreateModel = new System.Windows.Forms.PictureBox();
            this.tlpBttmLeftCreateModel = new System.Windows.Forms.TableLayoutPanel();
            this.tbModelName = new System.Windows.Forms.TextBox();
            this.lblModelName = new System.Windows.Forms.Label();
            this.lblImage1CountText = new System.Windows.Forms.Label();
            this.lblImage1CountValue = new System.Windows.Forms.Label();
            this.lblImage0CountValue = new System.Windows.Forms.Label();
            this.lblImage0CountText = new System.Windows.Forms.Label();
            this.cbArchitecture = new System.Windows.Forms.ComboBox();
            this.lblArchitecture = new System.Windows.Forms.Label();
            this.tabPageClassify = new System.Windows.Forms.TabPage();
            this.tlpClassify = new System.Windows.Forms.TableLayoutPanel();
            this.pbFrogClassify = new System.Windows.Forms.PictureBox();
            this.tlpTopRightClassify = new System.Windows.Forms.TableLayoutPanel();
            this.btnOfd = new System.Windows.Forms.Button();
            this.btnFbd = new System.Windows.Forms.Button();
            this.tbImagePath = new System.Windows.Forms.TextBox();
            this.tbFolderPath = new System.Windows.Forms.TextBox();
            this.pbImagePart = new System.Windows.Forms.PictureBox();
            this.tlpBttmLeftClassify = new System.Windows.Forms.TableLayoutPanel();
            this.lblPartCountVal = new System.Windows.Forms.Label();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.lblPartCountDesc = new System.Windows.Forms.Label();
            this.tbPartNumber = new System.Windows.Forms.TextBox();
            this.lblPartCurrDesc = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageCreateModel.SuspendLayout();
            this.tlpCreateModel.SuspendLayout();
            this.tlpTopRightCreateModel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFrogCreateModel)).BeginInit();
            this.tlpBttmLeftCreateModel.SuspendLayout();
            this.tabPageClassify.SuspendLayout();
            this.tlpClassify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFrogClassify)).BeginInit();
            this.tlpTopRightClassify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagePart)).BeginInit();
            this.tlpBttmLeftClassify.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofdImage
            // 
            this.ofdImage.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            // 
            // tabPageCreateModel
            // 
            this.tabPageCreateModel.Controls.Add(this.tlpCreateModel);
            this.tabPageCreateModel.Location = new System.Drawing.Point(4, 22);
            this.tabPageCreateModel.Name = "tabPageCreateModel";
            this.tabPageCreateModel.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCreateModel.Size = new System.Drawing.Size(579, 389);
            this.tabPageCreateModel.TabIndex = 1;
            this.tabPageCreateModel.Text = "Create Model";
            this.tabPageCreateModel.UseVisualStyleBackColor = true;
            // 
            // tlpCreateModel
            // 
            this.tlpCreateModel.ColumnCount = 2;
            this.tlpCreateModel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCreateModel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66667F));
            this.tlpCreateModel.Controls.Add(this.tlpBttmLeftCreateModel, 0, 1);
            this.tlpCreateModel.Controls.Add(this.pbFrogCreateModel, 0, 0);
            this.tlpCreateModel.Controls.Add(this.tlpTopRightCreateModel, 1, 0);
            this.tlpCreateModel.Controls.Add(this.tbModelOutputInfo, 1, 1);
            this.tlpCreateModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCreateModel.Location = new System.Drawing.Point(3, 3);
            this.tlpCreateModel.Name = "tlpCreateModel";
            this.tlpCreateModel.RowCount = 2;
            this.tlpCreateModel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpCreateModel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpCreateModel.Size = new System.Drawing.Size(573, 383);
            this.tlpCreateModel.TabIndex = 0;
            // 
            // tbModelOutputInfo
            // 
            this.tbModelOutputInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbModelOutputInfo.Enabled = false;
            this.tbModelOutputInfo.Location = new System.Drawing.Point(193, 79);
            this.tbModelOutputInfo.Multiline = true;
            this.tbModelOutputInfo.Name = "tbModelOutputInfo";
            this.tbModelOutputInfo.Size = new System.Drawing.Size(377, 301);
            this.tbModelOutputInfo.TabIndex = 0;
            // 
            // tlpTopRightCreateModel
            // 
            this.tlpTopRightCreateModel.ColumnCount = 2;
            this.tlpTopRightCreateModel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tlpTopRightCreateModel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTopRightCreateModel.Controls.Add(this.btnCreateModel, 1, 0);
            this.tlpTopRightCreateModel.Controls.Add(this.tbFoldersPath, 0, 1);
            this.tlpTopRightCreateModel.Controls.Add(this.btnBrowseFoldersPath, 1, 1);
            this.tlpTopRightCreateModel.Controls.Add(this.lblFolderPathNames, 0, 0);
            this.tlpTopRightCreateModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTopRightCreateModel.Location = new System.Drawing.Point(193, 3);
            this.tlpTopRightCreateModel.Name = "tlpTopRightCreateModel";
            this.tlpTopRightCreateModel.RowCount = 2;
            this.tlpTopRightCreateModel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTopRightCreateModel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTopRightCreateModel.Size = new System.Drawing.Size(377, 70);
            this.tlpTopRightCreateModel.TabIndex = 6;
            // 
            // lblFolderPathNames
            // 
            this.lblFolderPathNames.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFolderPathNames.AutoSize = true;
            this.lblFolderPathNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFolderPathNames.Location = new System.Drawing.Point(11, 5);
            this.lblFolderPathNames.Name = "lblFolderPathNames";
            this.lblFolderPathNames.Size = new System.Drawing.Size(260, 24);
            this.lblFolderPathNames.TabIndex = 5;
            this.lblFolderPathNames.Text = "Select a model name and a path that contains folders filled with images. Folder n" +
    "ames should be \'True\' and \'False\'.";
            this.lblFolderPathNames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBrowseFoldersPath
            // 
            this.btnBrowseFoldersPath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBrowseFoldersPath.Location = new System.Drawing.Point(292, 41);
            this.btnBrowseFoldersPath.Name = "btnBrowseFoldersPath";
            this.btnBrowseFoldersPath.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseFoldersPath.TabIndex = 3;
            this.btnBrowseFoldersPath.Text = "Browse";
            this.btnBrowseFoldersPath.UseVisualStyleBackColor = true;
            this.btnBrowseFoldersPath.Click += new System.EventHandler(this.btnFbdPredict_Click);
            // 
            // tbFoldersPath
            // 
            this.tbFoldersPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFoldersPath.Enabled = false;
            this.tbFoldersPath.Location = new System.Drawing.Point(3, 42);
            this.tbFoldersPath.Name = "tbFoldersPath";
            this.tbFoldersPath.Size = new System.Drawing.Size(276, 20);
            this.tbFoldersPath.TabIndex = 1;
            this.tbFoldersPath.Text = "Input folders path";
            this.tbFoldersPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCreateModel
            // 
            this.btnCreateModel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreateModel.Enabled = false;
            this.btnCreateModel.Location = new System.Drawing.Point(292, 6);
            this.btnCreateModel.Name = "btnCreateModel";
            this.btnCreateModel.Size = new System.Drawing.Size(75, 23);
            this.btnCreateModel.TabIndex = 6;
            this.btnCreateModel.Text = "Create";
            this.btnCreateModel.UseVisualStyleBackColor = true;
            this.btnCreateModel.Click += new System.EventHandler(this.btnCreateModel_Click);
            // 
            // pbFrogCreateModel
            // 
            this.pbFrogCreateModel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbFrogCreateModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFrogCreateModel.Image = global::ImagePartClassifier.Properties.Resources.bigfrog2;
            this.pbFrogCreateModel.InitialImage = global::ImagePartClassifier.Properties.Resources.bigfrog2;
            this.pbFrogCreateModel.Location = new System.Drawing.Point(3, 3);
            this.pbFrogCreateModel.Name = "pbFrogCreateModel";
            this.pbFrogCreateModel.Size = new System.Drawing.Size(184, 70);
            this.pbFrogCreateModel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFrogCreateModel.TabIndex = 4;
            this.pbFrogCreateModel.TabStop = false;
            // 
            // tlpBttmLeftCreateModel
            // 
            this.tlpBttmLeftCreateModel.ColumnCount = 2;
            this.tlpBttmLeftCreateModel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBttmLeftCreateModel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBttmLeftCreateModel.Controls.Add(this.lblArchitecture, 0, 0);
            this.tlpBttmLeftCreateModel.Controls.Add(this.cbArchitecture, 1, 0);
            this.tlpBttmLeftCreateModel.Controls.Add(this.lblImage0CountText, 0, 3);
            this.tlpBttmLeftCreateModel.Controls.Add(this.lblImage0CountValue, 1, 3);
            this.tlpBttmLeftCreateModel.Controls.Add(this.lblImage1CountValue, 1, 2);
            this.tlpBttmLeftCreateModel.Controls.Add(this.lblImage1CountText, 0, 2);
            this.tlpBttmLeftCreateModel.Controls.Add(this.lblModelName, 0, 1);
            this.tlpBttmLeftCreateModel.Controls.Add(this.tbModelName, 1, 1);
            this.tlpBttmLeftCreateModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBttmLeftCreateModel.Location = new System.Drawing.Point(3, 79);
            this.tlpBttmLeftCreateModel.Name = "tlpBttmLeftCreateModel";
            this.tlpBttmLeftCreateModel.RowCount = 4;
            this.tlpBttmLeftCreateModel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpBttmLeftCreateModel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpBttmLeftCreateModel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpBttmLeftCreateModel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpBttmLeftCreateModel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBttmLeftCreateModel.Size = new System.Drawing.Size(184, 301);
            this.tlpBttmLeftCreateModel.TabIndex = 5;
            // 
            // tbModelName
            // 
            this.tbModelName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbModelName.Location = new System.Drawing.Point(95, 102);
            this.tbModelName.Name = "tbModelName";
            this.tbModelName.Size = new System.Drawing.Size(86, 20);
            this.tbModelName.TabIndex = 14;
            this.tbModelName.TextChanged += new System.EventHandler(this.tbModelName_TextChanged);
            // 
            // lblModelName
            // 
            this.lblModelName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblModelName.AutoSize = true;
            this.lblModelName.Location = new System.Drawing.Point(13, 106);
            this.lblModelName.Name = "lblModelName";
            this.lblModelName.Size = new System.Drawing.Size(65, 13);
            this.lblModelName.TabIndex = 13;
            this.lblModelName.Text = "Model name";
            // 
            // lblImage1CountText
            // 
            this.lblImage1CountText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblImage1CountText.AutoSize = true;
            this.lblImage1CountText.Location = new System.Drawing.Point(11, 174);
            this.lblImage1CountText.Name = "lblImage1CountText";
            this.lblImage1CountText.Size = new System.Drawing.Size(70, 26);
            this.lblImage1CountText.TabIndex = 7;
            this.lblImage1CountText.Text = "Found \'1\' flag images";
            this.lblImage1CountText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblImage1CountValue
            // 
            this.lblImage1CountValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblImage1CountValue.AutoSize = true;
            this.lblImage1CountValue.Location = new System.Drawing.Point(131, 181);
            this.lblImage1CountValue.Name = "lblImage1CountValue";
            this.lblImage1CountValue.Size = new System.Drawing.Size(13, 13);
            this.lblImage1CountValue.TabIndex = 8;
            this.lblImage1CountValue.Text = "0";
            // 
            // lblImage0CountValue
            // 
            this.lblImage0CountValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblImage0CountValue.AutoSize = true;
            this.lblImage0CountValue.Location = new System.Drawing.Point(131, 256);
            this.lblImage0CountValue.Name = "lblImage0CountValue";
            this.lblImage0CountValue.Size = new System.Drawing.Size(13, 13);
            this.lblImage0CountValue.TabIndex = 10;
            this.lblImage0CountValue.Text = "0";
            // 
            // lblImage0CountText
            // 
            this.lblImage0CountText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblImage0CountText.AutoSize = true;
            this.lblImage0CountText.Location = new System.Drawing.Point(11, 250);
            this.lblImage0CountText.Name = "lblImage0CountText";
            this.lblImage0CountText.Size = new System.Drawing.Size(70, 26);
            this.lblImage0CountText.TabIndex = 9;
            this.lblImage0CountText.Text = "Found \'0\' flag images";
            this.lblImage0CountText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbArchitecture
            // 
            this.cbArchitecture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbArchitecture.FormattingEnabled = true;
            this.cbArchitecture.Location = new System.Drawing.Point(95, 27);
            this.cbArchitecture.Name = "cbArchitecture";
            this.cbArchitecture.Size = new System.Drawing.Size(86, 21);
            this.cbArchitecture.TabIndex = 12;
            // 
            // lblArchitecture
            // 
            this.lblArchitecture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblArchitecture.AutoSize = true;
            this.lblArchitecture.Location = new System.Drawing.Point(12, 24);
            this.lblArchitecture.Name = "lblArchitecture";
            this.lblArchitecture.Size = new System.Drawing.Size(68, 26);
            this.lblArchitecture.TabIndex = 11;
            this.lblArchitecture.Text = "Model trainer architecture";
            this.lblArchitecture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPageClassify
            // 
            this.tabPageClassify.Controls.Add(this.tlpClassify);
            this.tabPageClassify.Location = new System.Drawing.Point(4, 22);
            this.tabPageClassify.Name = "tabPageClassify";
            this.tabPageClassify.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClassify.Size = new System.Drawing.Size(579, 389);
            this.tabPageClassify.TabIndex = 0;
            this.tabPageClassify.Text = "Classify";
            this.tabPageClassify.UseVisualStyleBackColor = true;
            // 
            // tlpClassify
            // 
            this.tlpClassify.ColumnCount = 2;
            this.tlpClassify.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpClassify.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tlpClassify.Controls.Add(this.tlpBttmLeftClassify, 0, 1);
            this.tlpClassify.Controls.Add(this.pbImagePart, 1, 1);
            this.tlpClassify.Controls.Add(this.tlpTopRightClassify, 1, 0);
            this.tlpClassify.Controls.Add(this.pbFrogClassify, 0, 0);
            this.tlpClassify.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpClassify.Location = new System.Drawing.Point(3, 3);
            this.tlpClassify.Name = "tlpClassify";
            this.tlpClassify.RowCount = 2;
            this.tlpClassify.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpClassify.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpClassify.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpClassify.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpClassify.Size = new System.Drawing.Size(573, 383);
            this.tlpClassify.TabIndex = 0;
            // 
            // pbFrogClassify
            // 
            this.pbFrogClassify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbFrogClassify.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFrogClassify.Image = global::ImagePartClassifier.Properties.Resources.bigfrog2;
            this.pbFrogClassify.InitialImage = global::ImagePartClassifier.Properties.Resources.bigfrog2;
            this.pbFrogClassify.Location = new System.Drawing.Point(3, 3);
            this.pbFrogClassify.Name = "pbFrogClassify";
            this.pbFrogClassify.Size = new System.Drawing.Size(185, 70);
            this.pbFrogClassify.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFrogClassify.TabIndex = 3;
            this.pbFrogClassify.TabStop = false;
            // 
            // tlpTopRightClassify
            // 
            this.tlpTopRightClassify.ColumnCount = 2;
            this.tlpTopRightClassify.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tlpTopRightClassify.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTopRightClassify.Controls.Add(this.tbFolderPath, 0, 0);
            this.tlpTopRightClassify.Controls.Add(this.tbImagePath, 0, 1);
            this.tlpTopRightClassify.Controls.Add(this.btnFbd, 1, 0);
            this.tlpTopRightClassify.Controls.Add(this.btnOfd, 1, 1);
            this.tlpTopRightClassify.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTopRightClassify.Location = new System.Drawing.Point(194, 3);
            this.tlpTopRightClassify.Name = "tlpTopRightClassify";
            this.tlpTopRightClassify.RowCount = 2;
            this.tlpTopRightClassify.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTopRightClassify.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTopRightClassify.Size = new System.Drawing.Size(376, 70);
            this.tlpTopRightClassify.TabIndex = 2;
            // 
            // btnOfd
            // 
            this.btnOfd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOfd.Enabled = false;
            this.btnOfd.Location = new System.Drawing.Point(291, 41);
            this.btnOfd.Name = "btnOfd";
            this.btnOfd.Size = new System.Drawing.Size(75, 23);
            this.btnOfd.TabIndex = 3;
            this.btnOfd.Text = "Open File";
            this.btnOfd.UseVisualStyleBackColor = true;
            this.btnOfd.Click += new System.EventHandler(this.btnOfd_Click);
            // 
            // btnFbd
            // 
            this.btnFbd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFbd.Location = new System.Drawing.Point(291, 6);
            this.btnFbd.Name = "btnFbd";
            this.btnFbd.Size = new System.Drawing.Size(75, 23);
            this.btnFbd.TabIndex = 2;
            this.btnFbd.Text = "Browse";
            this.btnFbd.UseVisualStyleBackColor = true;
            this.btnFbd.Click += new System.EventHandler(this.btnFbd_Click);
            // 
            // tbImagePath
            // 
            this.tbImagePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbImagePath.Enabled = false;
            this.tbImagePath.Location = new System.Drawing.Point(3, 42);
            this.tbImagePath.Name = "tbImagePath";
            this.tbImagePath.Size = new System.Drawing.Size(276, 20);
            this.tbImagePath.TabIndex = 1;
            this.tbImagePath.Text = "Input image path";
            this.tbImagePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbFolderPath
            // 
            this.tbFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFolderPath.Enabled = false;
            this.tbFolderPath.Location = new System.Drawing.Point(3, 7);
            this.tbFolderPath.Name = "tbFolderPath";
            this.tbFolderPath.Size = new System.Drawing.Size(276, 20);
            this.tbFolderPath.TabIndex = 0;
            this.tbFolderPath.Text = "Output folder path";
            this.tbFolderPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbImagePart
            // 
            this.pbImagePart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbImagePart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImagePart.Location = new System.Drawing.Point(194, 79);
            this.pbImagePart.Name = "pbImagePart";
            this.pbImagePart.Size = new System.Drawing.Size(376, 301);
            this.pbImagePart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagePart.TabIndex = 1;
            this.pbImagePart.TabStop = false;
            // 
            // tlpBttmLeftClassify
            // 
            this.tlpBttmLeftClassify.ColumnCount = 2;
            this.tlpBttmLeftClassify.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBttmLeftClassify.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBttmLeftClassify.Controls.Add(this.lblPartCurrDesc, 0, 0);
            this.tlpBttmLeftClassify.Controls.Add(this.tbPartNumber, 1, 0);
            this.tlpBttmLeftClassify.Controls.Add(this.lblPartCountDesc, 0, 1);
            this.tlpBttmLeftClassify.Controls.Add(this.btnAccept, 0, 2);
            this.tlpBttmLeftClassify.Controls.Add(this.btnReject, 1, 2);
            this.tlpBttmLeftClassify.Controls.Add(this.lblPartCountVal, 1, 1);
            this.tlpBttmLeftClassify.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBttmLeftClassify.Location = new System.Drawing.Point(3, 79);
            this.tlpBttmLeftClassify.Name = "tlpBttmLeftClassify";
            this.tlpBttmLeftClassify.RowCount = 4;
            this.tlpBttmLeftClassify.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpBttmLeftClassify.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpBttmLeftClassify.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpBttmLeftClassify.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpBttmLeftClassify.Size = new System.Drawing.Size(185, 301);
            this.tlpBttmLeftClassify.TabIndex = 0;
            // 
            // lblPartCountVal
            // 
            this.lblPartCountVal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPartCountVal.AutoSize = true;
            this.lblPartCountVal.Location = new System.Drawing.Point(132, 106);
            this.lblPartCountVal.Name = "lblPartCountVal";
            this.lblPartCountVal.Size = new System.Drawing.Size(13, 13);
            this.lblPartCountVal.TabIndex = 5;
            this.lblPartCountVal.Text = "0";
            // 
            // btnReject
            // 
            this.btnReject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReject.Enabled = false;
            this.btnReject.Location = new System.Drawing.Point(95, 153);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(87, 69);
            this.btnReject.TabIndex = 4;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = true;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAccept.Enabled = false;
            this.btnAccept.Location = new System.Drawing.Point(3, 153);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(86, 69);
            this.btnAccept.TabIndex = 3;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // lblPartCountDesc
            // 
            this.lblPartCountDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPartCountDesc.AutoSize = true;
            this.lblPartCountDesc.Location = new System.Drawing.Point(9, 106);
            this.lblPartCountDesc.Name = "lblPartCountDesc";
            this.lblPartCountDesc.Size = new System.Drawing.Size(73, 13);
            this.lblPartCountDesc.TabIndex = 2;
            this.lblPartCountDesc.Text = "Count of parts";
            this.lblPartCountDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPartNumber
            // 
            this.tbPartNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPartNumber.Enabled = false;
            this.tbPartNumber.Location = new System.Drawing.Point(95, 27);
            this.tbPartNumber.Name = "tbPartNumber";
            this.tbPartNumber.Size = new System.Drawing.Size(87, 20);
            this.tbPartNumber.TabIndex = 1;
            this.tbPartNumber.TextChanged += new System.EventHandler(this.tbPartNumber_TextChanged);
            this.tbPartNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPartNumber_KeyPress);
            // 
            // lblPartCurrDesc
            // 
            this.lblPartCurrDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPartCurrDesc.AutoSize = true;
            this.lblPartCurrDesc.Location = new System.Drawing.Point(10, 24);
            this.lblPartCurrDesc.Name = "lblPartCurrDesc";
            this.lblPartCurrDesc.Size = new System.Drawing.Size(72, 26);
            this.lblPartCurrDesc.TabIndex = 0;
            this.lblPartCurrDesc.Text = "Current image part";
            this.lblPartCurrDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageClassify);
            this.tabControl.Controls.Add(this.tabPageCreateModel);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(587, 415);
            this.tabControl.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 415);
            this.Controls.Add(this.tabControl);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Image Classifier";
            this.tabPageCreateModel.ResumeLayout(false);
            this.tlpCreateModel.ResumeLayout(false);
            this.tlpCreateModel.PerformLayout();
            this.tlpTopRightCreateModel.ResumeLayout(false);
            this.tlpTopRightCreateModel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFrogCreateModel)).EndInit();
            this.tlpBttmLeftCreateModel.ResumeLayout(false);
            this.tlpBttmLeftCreateModel.PerformLayout();
            this.tabPageClassify.ResumeLayout(false);
            this.tlpClassify.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFrogClassify)).EndInit();
            this.tlpTopRightClassify.ResumeLayout(false);
            this.tlpTopRightClassify.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagePart)).EndInit();
            this.tlpBttmLeftClassify.ResumeLayout(false);
            this.tlpBttmLeftClassify.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void TbPartNumber_TextChanged(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog fbdOutput;
        private System.Windows.Forms.OpenFileDialog ofdImage;
        private System.Windows.Forms.TabPage tabPageCreateModel;
        private System.Windows.Forms.TableLayoutPanel tlpCreateModel;
        private System.Windows.Forms.TableLayoutPanel tlpBttmLeftCreateModel;
        private System.Windows.Forms.Label lblArchitecture;
        private System.Windows.Forms.ComboBox cbArchitecture;
        private System.Windows.Forms.Label lblImage0CountText;
        private System.Windows.Forms.Label lblImage0CountValue;
        private System.Windows.Forms.Label lblImage1CountValue;
        private System.Windows.Forms.Label lblImage1CountText;
        private System.Windows.Forms.Label lblModelName;
        private System.Windows.Forms.TextBox tbModelName;
        private System.Windows.Forms.PictureBox pbFrogCreateModel;
        private System.Windows.Forms.TableLayoutPanel tlpTopRightCreateModel;
        private System.Windows.Forms.Button btnCreateModel;
        private System.Windows.Forms.TextBox tbFoldersPath;
        private System.Windows.Forms.Button btnBrowseFoldersPath;
        private System.Windows.Forms.Label lblFolderPathNames;
        private System.Windows.Forms.TextBox tbModelOutputInfo;
        private System.Windows.Forms.TabPage tabPageClassify;
        private System.Windows.Forms.TableLayoutPanel tlpClassify;
        private System.Windows.Forms.TableLayoutPanel tlpBttmLeftClassify;
        private System.Windows.Forms.Label lblPartCurrDesc;
        private System.Windows.Forms.TextBox tbPartNumber;
        private System.Windows.Forms.Label lblPartCountDesc;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Label lblPartCountVal;
        private System.Windows.Forms.PictureBox pbImagePart;
        private System.Windows.Forms.TableLayoutPanel tlpTopRightClassify;
        private System.Windows.Forms.TextBox tbFolderPath;
        private System.Windows.Forms.TextBox tbImagePath;
        private System.Windows.Forms.Button btnFbd;
        private System.Windows.Forms.Button btnOfd;
        private System.Windows.Forms.PictureBox pbFrogClassify;
        private System.Windows.Forms.TabControl tabControl;
    }
}

