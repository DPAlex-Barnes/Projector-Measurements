namespace Projector_Measurements
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.StartButton = new System.Windows.Forms.Button();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LiveViewLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GetMeasurementsButton = new System.Windows.Forms.Button();
            this.resolutionComboBox = new System.Windows.Forms.ComboBox();
            this.StopButton = new System.Windows.Forms.Button();
            this.WhiteMeasurementsPanel = new System.Windows.Forms.Panel();
            this.BRCorner = new System.Windows.Forms.Label();
            this.BLCorner = new System.Windows.Forms.Label();
            this.TRCorner = new System.Windows.Forms.Label();
            this.TLCorner = new System.Windows.Forms.Label();
            this.BottomLeft = new System.Windows.Forms.Label();
            this.TopLeft = new System.Windows.Forms.Label();
            this.BottomRight = new System.Windows.Forms.Label();
            this.TopRight = new System.Windows.Forms.Label();
            this.Bottom = new System.Windows.Forms.Label();
            this.Right = new System.Windows.Forms.Label();
            this.Left = new System.Windows.Forms.Label();
            this.Top = new System.Windows.Forms.Label();
            this.Centre = new System.Windows.Forms.Label();
            this.LumensRead = new System.Windows.Forms.Label();
            this.LumensText = new System.Windows.Forms.Label();
            this.LiveGroupBox = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.WhiteMeasurementsPanel.SuspendLayout();
            this.LiveGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.StartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.StartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.ForeColor = System.Drawing.Color.DarkGray;
            this.StartButton.Location = new System.Drawing.Point(15, 176);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(121, 53);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Visible = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // BtnConnect
            // 
            this.BtnConnect.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnConnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConnect.ForeColor = System.Drawing.Color.DarkGray;
            this.BtnConnect.Location = new System.Drawing.Point(15, 19);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(121, 46);
            this.BtnConnect.TabIndex = 13;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(20, 69);
            this.label1.MinimumSize = new System.Drawing.Size(109, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Offline";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LiveViewLabel);
            this.panel1.Location = new System.Drawing.Point(301, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 50);
            this.panel1.TabIndex = 19;
            // 
            // LiveViewLabel
            // 
            this.LiveViewLabel.AutoSize = true;
            this.LiveViewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LiveViewLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.LiveViewLabel.Location = new System.Drawing.Point(87, 8);
            this.LiveViewLabel.Name = "LiveViewLabel";
            this.LiveViewLabel.Size = new System.Drawing.Size(274, 33);
            this.LiveViewLabel.TabIndex = 18;
            this.LiveViewLabel.Text = "All Point Live View";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GetMeasurementsButton);
            this.groupBox1.Controls.Add(this.resolutionComboBox);
            this.groupBox1.Controls.Add(this.StopButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnConnect);
            this.groupBox1.Controls.Add(this.StartButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 565);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // GetMeasurementsButton
            // 
            this.GetMeasurementsButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.GetMeasurementsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.GetMeasurementsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GetMeasurementsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetMeasurementsButton.ForeColor = System.Drawing.Color.DarkGray;
            this.GetMeasurementsButton.Location = new System.Drawing.Point(15, 495);
            this.GetMeasurementsButton.Name = "GetMeasurementsButton";
            this.GetMeasurementsButton.Size = new System.Drawing.Size(121, 53);
            this.GetMeasurementsButton.TabIndex = 17;
            this.GetMeasurementsButton.Text = "All Measurements";
            this.GetMeasurementsButton.UseVisualStyleBackColor = true;
            this.GetMeasurementsButton.Visible = false;
            this.GetMeasurementsButton.Click += new System.EventHandler(this.GetMeasurementsButton_Click);
            // 
            // resolutionComboBox
            // 
            this.resolutionComboBox.BackColor = System.Drawing.Color.White;
            this.resolutionComboBox.FormattingEnabled = true;
            this.resolutionComboBox.Items.AddRange(new object[] {
            "DC4K",
            "UHD 4K",
            "WUXGA",
            "1080p"});
            this.resolutionComboBox.Location = new System.Drawing.Point(15, 137);
            this.resolutionComboBox.Name = "resolutionComboBox";
            this.resolutionComboBox.Size = new System.Drawing.Size(121, 21);
            this.resolutionComboBox.TabIndex = 16;
            this.resolutionComboBox.Text = "Resolution.....";
            this.resolutionComboBox.Visible = false;
            this.resolutionComboBox.SelectedValueChanged += new System.EventHandler(this.resolutionComboBox_SelectedValueChanged);
            // 
            // StopButton
            // 
            this.StopButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.StopButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.StopButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopButton.ForeColor = System.Drawing.Color.DarkGray;
            this.StopButton.Location = new System.Drawing.Point(15, 235);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(121, 53);
            this.StopButton.TabIndex = 15;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Visible = false;
            this.StopButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // WhiteMeasurementsPanel
            // 
            this.WhiteMeasurementsPanel.AutoSize = true;
            this.WhiteMeasurementsPanel.Controls.Add(this.BRCorner);
            this.WhiteMeasurementsPanel.Controls.Add(this.BLCorner);
            this.WhiteMeasurementsPanel.Controls.Add(this.TRCorner);
            this.WhiteMeasurementsPanel.Controls.Add(this.TLCorner);
            this.WhiteMeasurementsPanel.Controls.Add(this.BottomLeft);
            this.WhiteMeasurementsPanel.Controls.Add(this.TopLeft);
            this.WhiteMeasurementsPanel.Controls.Add(this.BottomRight);
            this.WhiteMeasurementsPanel.Controls.Add(this.TopRight);
            this.WhiteMeasurementsPanel.Controls.Add(this.Bottom);
            this.WhiteMeasurementsPanel.Controls.Add(this.Right);
            this.WhiteMeasurementsPanel.Controls.Add(this.Left);
            this.WhiteMeasurementsPanel.Controls.Add(this.Top);
            this.WhiteMeasurementsPanel.Controls.Add(this.Centre);
            this.WhiteMeasurementsPanel.Controls.Add(this.LumensRead);
            this.WhiteMeasurementsPanel.Controls.Add(this.LumensText);
            this.WhiteMeasurementsPanel.Location = new System.Drawing.Point(6, 13);
            this.WhiteMeasurementsPanel.Name = "WhiteMeasurementsPanel";
            this.WhiteMeasurementsPanel.Size = new System.Drawing.Size(672, 552);
            this.WhiteMeasurementsPanel.TabIndex = 18;
            // 
            // BRCorner
            // 
            this.BRCorner.AutoSize = true;
            this.BRCorner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BRCorner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRCorner.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRCorner.ForeColor = System.Drawing.Color.DarkGray;
            this.BRCorner.Location = new System.Drawing.Point(509, 366);
            this.BRCorner.MaximumSize = new System.Drawing.Size(160, 60);
            this.BRCorner.MinimumSize = new System.Drawing.Size(160, 30);
            this.BRCorner.Name = "BRCorner";
            this.BRCorner.Size = new System.Drawing.Size(160, 60);
            this.BRCorner.TabIndex = 17;
            this.BRCorner.Text = "0";
            this.BRCorner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BLCorner
            // 
            this.BLCorner.AutoSize = true;
            this.BLCorner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BLCorner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLCorner.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLCorner.ForeColor = System.Drawing.Color.DarkGray;
            this.BLCorner.Location = new System.Drawing.Point(3, 366);
            this.BLCorner.MaximumSize = new System.Drawing.Size(160, 60);
            this.BLCorner.MinimumSize = new System.Drawing.Size(160, 30);
            this.BLCorner.Name = "BLCorner";
            this.BLCorner.Size = new System.Drawing.Size(160, 60);
            this.BLCorner.TabIndex = 17;
            this.BLCorner.Text = "0";
            this.BLCorner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TRCorner
            // 
            this.TRCorner.AutoSize = true;
            this.TRCorner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TRCorner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TRCorner.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRCorner.ForeColor = System.Drawing.Color.DarkGray;
            this.TRCorner.Location = new System.Drawing.Point(508, 9);
            this.TRCorner.MaximumSize = new System.Drawing.Size(160, 60);
            this.TRCorner.MinimumSize = new System.Drawing.Size(160, 30);
            this.TRCorner.Name = "TRCorner";
            this.TRCorner.Size = new System.Drawing.Size(160, 60);
            this.TRCorner.TabIndex = 17;
            this.TRCorner.Text = "0";
            this.TRCorner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TLCorner
            // 
            this.TLCorner.AutoSize = true;
            this.TLCorner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TLCorner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TLCorner.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TLCorner.ForeColor = System.Drawing.Color.DarkGray;
            this.TLCorner.Location = new System.Drawing.Point(3, 9);
            this.TLCorner.MaximumSize = new System.Drawing.Size(160, 60);
            this.TLCorner.MinimumSize = new System.Drawing.Size(160, 30);
            this.TLCorner.Name = "TLCorner";
            this.TLCorner.Size = new System.Drawing.Size(160, 60);
            this.TLCorner.TabIndex = 15;
            this.TLCorner.Text = "0";
            this.TLCorner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BottomLeft
            // 
            this.BottomLeft.AutoSize = true;
            this.BottomLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BottomLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BottomLeft.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottomLeft.ForeColor = System.Drawing.Color.DarkGray;
            this.BottomLeft.Location = new System.Drawing.Point(66, 270);
            this.BottomLeft.MaximumSize = new System.Drawing.Size(160, 60);
            this.BottomLeft.MinimumSize = new System.Drawing.Size(160, 30);
            this.BottomLeft.Name = "BottomLeft";
            this.BottomLeft.Size = new System.Drawing.Size(160, 60);
            this.BottomLeft.TabIndex = 11;
            this.BottomLeft.Text = "0";
            this.BottomLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TopLeft
            // 
            this.TopLeft.AutoSize = true;
            this.TopLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TopLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopLeft.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopLeft.ForeColor = System.Drawing.Color.DarkGray;
            this.TopLeft.Location = new System.Drawing.Point(66, 95);
            this.TopLeft.MaximumSize = new System.Drawing.Size(160, 60);
            this.TopLeft.MinimumSize = new System.Drawing.Size(160, 30);
            this.TopLeft.Name = "TopLeft";
            this.TopLeft.Size = new System.Drawing.Size(160, 60);
            this.TopLeft.TabIndex = 10;
            this.TopLeft.Text = "0";
            this.TopLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BottomRight
            // 
            this.BottomRight.AutoSize = true;
            this.BottomRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BottomRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BottomRight.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottomRight.ForeColor = System.Drawing.Color.DarkGray;
            this.BottomRight.Location = new System.Drawing.Point(433, 270);
            this.BottomRight.MaximumSize = new System.Drawing.Size(160, 60);
            this.BottomRight.MinimumSize = new System.Drawing.Size(160, 30);
            this.BottomRight.Name = "BottomRight";
            this.BottomRight.Size = new System.Drawing.Size(160, 60);
            this.BottomRight.TabIndex = 9;
            this.BottomRight.Text = "0";
            this.BottomRight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TopRight
            // 
            this.TopRight.AutoSize = true;
            this.TopRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TopRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopRight.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopRight.ForeColor = System.Drawing.Color.DarkGray;
            this.TopRight.Location = new System.Drawing.Point(433, 96);
            this.TopRight.MaximumSize = new System.Drawing.Size(160, 60);
            this.TopRight.MinimumSize = new System.Drawing.Size(160, 30);
            this.TopRight.Name = "TopRight";
            this.TopRight.Size = new System.Drawing.Size(160, 60);
            this.TopRight.TabIndex = 8;
            this.TopRight.Text = "0";
            this.TopRight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Bottom
            // 
            this.Bottom.AutoSize = true;
            this.Bottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Bottom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bottom.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bottom.ForeColor = System.Drawing.Color.DarkGray;
            this.Bottom.Location = new System.Drawing.Point(246, 270);
            this.Bottom.MaximumSize = new System.Drawing.Size(160, 60);
            this.Bottom.MinimumSize = new System.Drawing.Size(160, 30);
            this.Bottom.Name = "Bottom";
            this.Bottom.Size = new System.Drawing.Size(160, 60);
            this.Bottom.TabIndex = 7;
            this.Bottom.Text = "0";
            this.Bottom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Right
            // 
            this.Right.AutoSize = true;
            this.Right.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Right.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Right.ForeColor = System.Drawing.Color.DarkGray;
            this.Right.Location = new System.Drawing.Point(433, 184);
            this.Right.MaximumSize = new System.Drawing.Size(160, 60);
            this.Right.MinimumSize = new System.Drawing.Size(160, 30);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(160, 60);
            this.Right.TabIndex = 6;
            this.Right.Text = "0";
            this.Right.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Left
            // 
            this.Left.AutoSize = true;
            this.Left.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Left.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Left.ForeColor = System.Drawing.Color.DarkGray;
            this.Left.Location = new System.Drawing.Point(66, 184);
            this.Left.MaximumSize = new System.Drawing.Size(160, 60);
            this.Left.MinimumSize = new System.Drawing.Size(160, 30);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(160, 60);
            this.Left.TabIndex = 5;
            this.Left.Text = "0";
            this.Left.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Top
            // 
            this.Top.AutoSize = true;
            this.Top.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Top.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Top.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Top.ForeColor = System.Drawing.Color.DarkGray;
            this.Top.Location = new System.Drawing.Point(246, 95);
            this.Top.MaximumSize = new System.Drawing.Size(160, 60);
            this.Top.MinimumSize = new System.Drawing.Size(160, 30);
            this.Top.Name = "Top";
            this.Top.Size = new System.Drawing.Size(160, 60);
            this.Top.TabIndex = 4;
            this.Top.Text = "0";
            this.Top.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Centre
            // 
            this.Centre.AutoSize = true;
            this.Centre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Centre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Centre.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Centre.ForeColor = System.Drawing.Color.DarkGray;
            this.Centre.Location = new System.Drawing.Point(246, 184);
            this.Centre.MaximumSize = new System.Drawing.Size(160, 60);
            this.Centre.MinimumSize = new System.Drawing.Size(160, 30);
            this.Centre.Name = "Centre";
            this.Centre.Size = new System.Drawing.Size(160, 60);
            this.Centre.TabIndex = 3;
            this.Centre.Text = "0";
            this.Centre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LumensRead
            // 
            this.LumensRead.AutoSize = true;
            this.LumensRead.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LumensRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LumensRead.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LumensRead.ForeColor = System.Drawing.Color.DarkGray;
            this.LumensRead.Location = new System.Drawing.Point(304, 468);
            this.LumensRead.MaximumSize = new System.Drawing.Size(160, 60);
            this.LumensRead.MinimumSize = new System.Drawing.Size(160, 0);
            this.LumensRead.Name = "LumensRead";
            this.LumensRead.Size = new System.Drawing.Size(160, 60);
            this.LumensRead.TabIndex = 1;
            this.LumensRead.Text = "00000";
            this.LumensRead.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LumensText
            // 
            this.LumensText.AutoSize = true;
            this.LumensText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LumensText.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LumensText.ForeColor = System.Drawing.Color.DarkGray;
            this.LumensText.Location = new System.Drawing.Point(157, 482);
            this.LumensText.Name = "LumensText";
            this.LumensText.Size = new System.Drawing.Size(151, 40);
            this.LumensText.TabIndex = 0;
            this.LumensText.Text = "Lumens = ";
            // 
            // LiveGroupBox
            // 
            this.LiveGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LiveGroupBox.Controls.Add(this.WhiteMeasurementsPanel);
            this.LiveGroupBox.ForeColor = System.Drawing.Color.DarkGray;
            this.LiveGroupBox.Location = new System.Drawing.Point(187, 84);
            this.LiveGroupBox.Name = "LiveGroupBox";
            this.LiveGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LiveGroupBox.Size = new System.Drawing.Size(684, 571);
            this.LiveGroupBox.TabIndex = 21;
            this.LiveGroupBox.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userSettingsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "&Settings";
            // 
            // userSettingsToolStripMenuItem
            // 
            this.userSettingsToolStripMenuItem.Name = "userSettingsToolStripMenuItem";
            this.userSettingsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.userSettingsToolStripMenuItem.Text = "User Settings...";
            this.userSettingsToolStripMenuItem.Click += new System.EventHandler(this.userSettingsToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LiveGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projector Measurments";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.WhiteMeasurementsPanel.ResumeLayout(false);
            this.WhiteMeasurementsPanel.PerformLayout();
            this.LiveGroupBox.ResumeLayout(false);
            this.LiveGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel WhiteMeasurementsPanel;
        private System.Windows.Forms.Label BRCorner;
        private System.Windows.Forms.Label BLCorner;
        private System.Windows.Forms.Label TRCorner;
        private System.Windows.Forms.Label TLCorner;
        private System.Windows.Forms.Label BottomLeft;
        private System.Windows.Forms.Label TopLeft;
        private System.Windows.Forms.Label BottomRight;
        private System.Windows.Forms.Label TopRight;
        new private System.Windows.Forms.Label Bottom;
        new private System.Windows.Forms.Label Right;
        new private System.Windows.Forms.Label Left;
        new private System.Windows.Forms.Label Top;
        private System.Windows.Forms.Label Centre;
        private System.Windows.Forms.Label LumensRead;
        private System.Windows.Forms.Label LumensText;
        private System.Windows.Forms.GroupBox LiveGroupBox;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Label LiveViewLabel;
        private System.Windows.Forms.ComboBox resolutionComboBox;
        public System.Windows.Forms.Button GetMeasurementsButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userSettingsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

