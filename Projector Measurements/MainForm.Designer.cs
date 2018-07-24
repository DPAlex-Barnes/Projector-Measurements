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
            this.button1 = new System.Windows.Forms.Button();
            this.ComboBoxComms = new System.Windows.Forms.ComboBox();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.WhiteMeasurementsPanel.SuspendLayout();
            this.LiveGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DarkGray;
            this.button1.Location = new System.Drawing.Point(15, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ComboBoxComms
            // 
            this.ComboBoxComms.FormattingEnabled = true;
            this.ComboBoxComms.Location = new System.Drawing.Point(15, 44);
            this.ComboBoxComms.Name = "ComboBoxComms";
            this.ComboBoxComms.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxComms.TabIndex = 12;
            this.ComboBoxComms.Text = "COM3";
            // 
            // BtnConnect
            // 
            this.BtnConnect.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnConnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConnect.ForeColor = System.Drawing.Color.DarkGray;
            this.BtnConnect.Location = new System.Drawing.Point(34, 73);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(75, 23);
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
            this.label1.Location = new System.Drawing.Point(20, 109);
            this.label1.MinimumSize = new System.Drawing.Size(109, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "No Connection";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 50);
            this.panel1.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnConnect);
            this.groupBox1.Controls.Add(this.ComboBoxComms);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 481);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // WhiteMeasurementsPanel
            // 
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
            this.WhiteMeasurementsPanel.Location = new System.Drawing.Point(6, 19);
            this.WhiteMeasurementsPanel.Name = "WhiteMeasurementsPanel";
            this.WhiteMeasurementsPanel.Size = new System.Drawing.Size(572, 456);
            this.WhiteMeasurementsPanel.TabIndex = 18;
            // 
            // BRCorner
            // 
            this.BRCorner.AutoSize = true;
            this.BRCorner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BRCorner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRCorner.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRCorner.ForeColor = System.Drawing.Color.DarkGray;
            this.BRCorner.Location = new System.Drawing.Point(453, 285);
            this.BRCorner.MaximumSize = new System.Drawing.Size(115, 42);
            this.BRCorner.MinimumSize = new System.Drawing.Size(115, 42);
            this.BRCorner.Name = "BRCorner";
            this.BRCorner.Size = new System.Drawing.Size(115, 42);
            this.BRCorner.TabIndex = 17;
            this.BRCorner.Text = "0";
            this.BRCorner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BLCorner
            // 
            this.BLCorner.AutoSize = true;
            this.BLCorner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BLCorner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLCorner.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLCorner.ForeColor = System.Drawing.Color.DarkGray;
            this.BLCorner.Location = new System.Drawing.Point(3, 285);
            this.BLCorner.MaximumSize = new System.Drawing.Size(115, 42);
            this.BLCorner.MinimumSize = new System.Drawing.Size(115, 42);
            this.BLCorner.Name = "BLCorner";
            this.BLCorner.Size = new System.Drawing.Size(115, 42);
            this.BLCorner.TabIndex = 17;
            this.BLCorner.Text = "0";
            this.BLCorner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TRCorner
            // 
            this.TRCorner.AutoSize = true;
            this.TRCorner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TRCorner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TRCorner.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRCorner.ForeColor = System.Drawing.Color.DarkGray;
            this.TRCorner.Location = new System.Drawing.Point(453, 3);
            this.TRCorner.MaximumSize = new System.Drawing.Size(115, 42);
            this.TRCorner.MinimumSize = new System.Drawing.Size(115, 42);
            this.TRCorner.Name = "TRCorner";
            this.TRCorner.Size = new System.Drawing.Size(115, 42);
            this.TRCorner.TabIndex = 17;
            this.TRCorner.Text = "0";
            this.TRCorner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TLCorner
            // 
            this.TLCorner.AutoSize = true;
            this.TLCorner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TLCorner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TLCorner.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TLCorner.ForeColor = System.Drawing.Color.DarkGray;
            this.TLCorner.Location = new System.Drawing.Point(3, 3);
            this.TLCorner.MaximumSize = new System.Drawing.Size(115, 42);
            this.TLCorner.MinimumSize = new System.Drawing.Size(115, 42);
            this.TLCorner.Name = "TLCorner";
            this.TLCorner.Size = new System.Drawing.Size(115, 42);
            this.TLCorner.TabIndex = 15;
            this.TLCorner.Text = "0";
            this.TLCorner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BottomLeft
            // 
            this.BottomLeft.AutoSize = true;
            this.BottomLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BottomLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BottomLeft.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottomLeft.ForeColor = System.Drawing.Color.DarkGray;
            this.BottomLeft.Location = new System.Drawing.Point(86, 219);
            this.BottomLeft.MaximumSize = new System.Drawing.Size(115, 42);
            this.BottomLeft.MinimumSize = new System.Drawing.Size(115, 42);
            this.BottomLeft.Name = "BottomLeft";
            this.BottomLeft.Size = new System.Drawing.Size(115, 42);
            this.BottomLeft.TabIndex = 11;
            this.BottomLeft.Text = "0";
            this.BottomLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TopLeft
            // 
            this.TopLeft.AutoSize = true;
            this.TopLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TopLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopLeft.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopLeft.ForeColor = System.Drawing.Color.DarkGray;
            this.TopLeft.Location = new System.Drawing.Point(86, 69);
            this.TopLeft.MaximumSize = new System.Drawing.Size(115, 42);
            this.TopLeft.MinimumSize = new System.Drawing.Size(115, 42);
            this.TopLeft.Name = "TopLeft";
            this.TopLeft.Size = new System.Drawing.Size(115, 42);
            this.TopLeft.TabIndex = 10;
            this.TopLeft.Text = "0";
            this.TopLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BottomRight
            // 
            this.BottomRight.AutoSize = true;
            this.BottomRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BottomRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BottomRight.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottomRight.ForeColor = System.Drawing.Color.DarkGray;
            this.BottomRight.Location = new System.Drawing.Point(373, 219);
            this.BottomRight.MaximumSize = new System.Drawing.Size(115, 42);
            this.BottomRight.MinimumSize = new System.Drawing.Size(115, 42);
            this.BottomRight.Name = "BottomRight";
            this.BottomRight.Size = new System.Drawing.Size(115, 42);
            this.BottomRight.TabIndex = 9;
            this.BottomRight.Text = "0";
            this.BottomRight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TopRight
            // 
            this.TopRight.AutoSize = true;
            this.TopRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TopRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopRight.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopRight.ForeColor = System.Drawing.Color.DarkGray;
            this.TopRight.Location = new System.Drawing.Point(373, 70);
            this.TopRight.MaximumSize = new System.Drawing.Size(115, 42);
            this.TopRight.MinimumSize = new System.Drawing.Size(115, 42);
            this.TopRight.Name = "TopRight";
            this.TopRight.Size = new System.Drawing.Size(115, 42);
            this.TopRight.TabIndex = 8;
            this.TopRight.Text = "0";
            this.TopRight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Bottom
            // 
            this.Bottom.AutoSize = true;
            this.Bottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Bottom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bottom.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bottom.ForeColor = System.Drawing.Color.DarkGray;
            this.Bottom.Location = new System.Drawing.Point(228, 219);
            this.Bottom.MaximumSize = new System.Drawing.Size(115, 42);
            this.Bottom.MinimumSize = new System.Drawing.Size(115, 42);
            this.Bottom.Name = "Bottom";
            this.Bottom.Size = new System.Drawing.Size(115, 42);
            this.Bottom.TabIndex = 7;
            this.Bottom.Text = "0";
            this.Bottom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Right
            // 
            this.Right.AutoSize = true;
            this.Right.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Right.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Right.ForeColor = System.Drawing.Color.DarkGray;
            this.Right.Location = new System.Drawing.Point(373, 145);
            this.Right.MaximumSize = new System.Drawing.Size(115, 42);
            this.Right.MinimumSize = new System.Drawing.Size(115, 42);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(115, 42);
            this.Right.TabIndex = 6;
            this.Right.Text = "0";
            this.Right.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Left
            // 
            this.Left.AutoSize = true;
            this.Left.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Left.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Left.ForeColor = System.Drawing.Color.DarkGray;
            this.Left.Location = new System.Drawing.Point(86, 145);
            this.Left.MaximumSize = new System.Drawing.Size(115, 42);
            this.Left.MinimumSize = new System.Drawing.Size(115, 42);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(115, 42);
            this.Left.TabIndex = 5;
            this.Left.Text = "0";
            this.Left.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Top
            // 
            this.Top.AutoSize = true;
            this.Top.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Top.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Top.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Top.ForeColor = System.Drawing.Color.DarkGray;
            this.Top.Location = new System.Drawing.Point(228, 69);
            this.Top.MaximumSize = new System.Drawing.Size(115, 42);
            this.Top.MinimumSize = new System.Drawing.Size(115, 42);
            this.Top.Name = "Top";
            this.Top.Size = new System.Drawing.Size(115, 42);
            this.Top.TabIndex = 4;
            this.Top.Text = "0";
            this.Top.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Centre
            // 
            this.Centre.AutoSize = true;
            this.Centre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Centre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Centre.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Centre.ForeColor = System.Drawing.Color.DarkGray;
            this.Centre.Location = new System.Drawing.Point(228, 145);
            this.Centre.MaximumSize = new System.Drawing.Size(115, 42);
            this.Centre.MinimumSize = new System.Drawing.Size(115, 42);
            this.Centre.Name = "Centre";
            this.Centre.Size = new System.Drawing.Size(115, 42);
            this.Centre.TabIndex = 3;
            this.Centre.Text = "0";
            this.Centre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LumensRead
            // 
            this.LumensRead.AutoSize = true;
            this.LumensRead.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LumensRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LumensRead.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LumensRead.ForeColor = System.Drawing.Color.DarkGray;
            this.LumensRead.Location = new System.Drawing.Point(311, 355);
            this.LumensRead.MaximumSize = new System.Drawing.Size(115, 42);
            this.LumensRead.MinimumSize = new System.Drawing.Size(115, 42);
            this.LumensRead.Name = "LumensRead";
            this.LumensRead.Size = new System.Drawing.Size(115, 42);
            this.LumensRead.TabIndex = 1;
            this.LumensRead.Text = "0";
            this.LumensRead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LumensText
            // 
            this.LumensText.AutoSize = true;
            this.LumensText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LumensText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LumensText.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LumensText.ForeColor = System.Drawing.Color.DarkGray;
            this.LumensText.Location = new System.Drawing.Point(126, 355);
            this.LumensText.Name = "LumensText";
            this.LumensText.Size = new System.Drawing.Size(153, 42);
            this.LumensText.TabIndex = 0;
            this.LumensText.Text = "Lumens = ";
            // 
            // LiveGroupBox
            // 
            this.LiveGroupBox.Controls.Add(this.WhiteMeasurementsPanel);
            this.LiveGroupBox.Location = new System.Drawing.Point(187, 68);
            this.LiveGroupBox.Name = "LiveGroupBox";
            this.LiveGroupBox.Size = new System.Drawing.Size(584, 481);
            this.LiveGroupBox.TabIndex = 21;
            this.LiveGroupBox.TabStop = false;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.DarkGray;
            this.button2.Location = new System.Drawing.Point(15, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 53);
            this.button2.TabIndex = 15;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.LiveGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projector Measurments";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.WhiteMeasurementsPanel.ResumeLayout(false);
            this.WhiteMeasurementsPanel.PerformLayout();
            this.LiveGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox ComboBoxComms;
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
        private System.Windows.Forms.Label Bottom;
        private System.Windows.Forms.Label Right;
        private System.Windows.Forms.Label Left;
        private System.Windows.Forms.Label Top;
        private System.Windows.Forms.Label Centre;
        private System.Windows.Forms.Label LumensRead;
        private System.Windows.Forms.Label LumensText;
        private System.Windows.Forms.GroupBox LiveGroupBox;
        private System.Windows.Forms.Button button2;
    }
}

