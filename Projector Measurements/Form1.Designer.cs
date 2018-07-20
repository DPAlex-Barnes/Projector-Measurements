namespace Projector_Measurements
{
    partial class Form1
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
            this.LumensText = new System.Windows.Forms.Label();
            this.LumensRead = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Centre = new System.Windows.Forms.Label();
            this.Top = new System.Windows.Forms.Label();
            this.Left = new System.Windows.Forms.Label();
            this.Right = new System.Windows.Forms.Label();
            this.Bottom = new System.Windows.Forms.Label();
            this.TopRight = new System.Windows.Forms.Label();
            this.BottomRight = new System.Windows.Forms.Label();
            this.TopLeft = new System.Windows.Forms.Label();
            this.BottomLeft = new System.Windows.Forms.Label();
            this.ComboBoxComms = new System.Windows.Forms.ComboBox();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // LumensText
            // 
            this.LumensText.AutoSize = true;
            this.LumensText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LumensText.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LumensText.Location = new System.Drawing.Point(166, 63);
            this.LumensText.Name = "LumensText";
            this.LumensText.Size = new System.Drawing.Size(66, 20);
            this.LumensText.TabIndex = 0;
            this.LumensText.Text = "Lumens";
            // 
            // LumensRead
            // 
            this.LumensRead.AutoSize = true;
            this.LumensRead.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LumensRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LumensRead.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LumensRead.Location = new System.Drawing.Point(238, 53);
            this.LumensRead.Name = "LumensRead";
            this.LumensRead.Size = new System.Drawing.Size(76, 33);
            this.LumensRead.TabIndex = 1;
            this.LumensRead.Text = "0000";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Location = new System.Drawing.Point(42, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "Measure Lumens";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Centre
            // 
            this.Centre.AutoSize = true;
            this.Centre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Centre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Centre.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Centre.Location = new System.Drawing.Point(238, 201);
            this.Centre.Name = "Centre";
            this.Centre.Size = new System.Drawing.Size(76, 33);
            this.Centre.TabIndex = 3;
            this.Centre.Text = "0000";
            // 
            // Top
            // 
            this.Top.AutoSize = true;
            this.Top.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Top.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Top.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Top.Location = new System.Drawing.Point(238, 128);
            this.Top.Name = "Top";
            this.Top.Size = new System.Drawing.Size(76, 33);
            this.Top.TabIndex = 4;
            this.Top.Text = "0000";
            // 
            // Left
            // 
            this.Left.AutoSize = true;
            this.Left.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Left.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Left.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Left.Location = new System.Drawing.Point(115, 201);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(76, 33);
            this.Left.TabIndex = 5;
            this.Left.Text = "0000";
            // 
            // Right
            // 
            this.Right.AutoSize = true;
            this.Right.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Right.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Right.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Right.Location = new System.Drawing.Point(366, 201);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(76, 33);
            this.Right.TabIndex = 6;
            this.Right.Text = "0000";
            // 
            // Bottom
            // 
            this.Bottom.AutoSize = true;
            this.Bottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Bottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bottom.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Bottom.Location = new System.Drawing.Point(238, 271);
            this.Bottom.Name = "Bottom";
            this.Bottom.Size = new System.Drawing.Size(76, 33);
            this.Bottom.TabIndex = 7;
            this.Bottom.Text = "0000";
            // 
            // TopRight
            // 
            this.TopRight.AutoSize = true;
            this.TopRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TopRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopRight.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TopRight.Location = new System.Drawing.Point(366, 128);
            this.TopRight.Name = "TopRight";
            this.TopRight.Size = new System.Drawing.Size(76, 33);
            this.TopRight.TabIndex = 8;
            this.TopRight.Text = "0000";
            // 
            // BottomRight
            // 
            this.BottomRight.AutoSize = true;
            this.BottomRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BottomRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottomRight.ForeColor = System.Drawing.SystemColors.GrayText;
            this.BottomRight.Location = new System.Drawing.Point(366, 271);
            this.BottomRight.Name = "BottomRight";
            this.BottomRight.Size = new System.Drawing.Size(76, 33);
            this.BottomRight.TabIndex = 9;
            this.BottomRight.Text = "0000";
            // 
            // TopLeft
            // 
            this.TopLeft.AutoSize = true;
            this.TopLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TopLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopLeft.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TopLeft.Location = new System.Drawing.Point(115, 128);
            this.TopLeft.Name = "TopLeft";
            this.TopLeft.Size = new System.Drawing.Size(76, 33);
            this.TopLeft.TabIndex = 10;
            this.TopLeft.Text = "0000";
            // 
            // BottomLeft
            // 
            this.BottomLeft.AutoSize = true;
            this.BottomLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BottomLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottomLeft.ForeColor = System.Drawing.SystemColors.GrayText;
            this.BottomLeft.Location = new System.Drawing.Point(115, 271);
            this.BottomLeft.Name = "BottomLeft";
            this.BottomLeft.Size = new System.Drawing.Size(76, 33);
            this.BottomLeft.TabIndex = 11;
            this.BottomLeft.Text = "0000";
            // 
            // ComboBoxComms
            // 
            this.ComboBoxComms.BackColor = System.Drawing.SystemColors.MenuText;
            this.ComboBoxComms.ForeColor = System.Drawing.Color.White;
            this.ComboBoxComms.FormattingEnabled = true;
            this.ComboBoxComms.Location = new System.Drawing.Point(73, 19);
            this.ComboBoxComms.Name = "ComboBoxComms";
            this.ComboBoxComms.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxComms.TabIndex = 12;
            // 
            // BtnConnect
            // 
            this.BtnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnConnect.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnConnect.Location = new System.Drawing.Point(96, 46);
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
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(7, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Offline";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BottomLeft);
            this.groupBox1.Controls.Add(this.TopLeft);
            this.groupBox1.Controls.Add(this.BottomRight);
            this.groupBox1.Controls.Add(this.TopRight);
            this.groupBox1.Controls.Add(this.Bottom);
            this.groupBox1.Controls.Add(this.Right);
            this.groupBox1.Controls.Add(this.Left);
            this.groupBox1.Controls.Add(this.Top);
            this.groupBox1.Controls.Add(this.Centre);
            this.groupBox1.Controls.Add(this.LumensRead);
            this.groupBox1.Controls.Add(this.LumensText);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(232, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 458);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnConnect);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ComboBoxComms);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(5, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(766, 87);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(8, 91);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 457);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button2.Location = new System.Drawing.Point(42, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 53);
            this.button2.TabIndex = 2;
            this.button2.Text = "Full Screen Contrast";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button3.Location = new System.Drawing.Point(42, 80);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 53);
            this.button3.TabIndex = 2;
            this.button3.Text = "Live Lumens";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projector Optical Measurments";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LumensText;
        private System.Windows.Forms.Label LumensRead;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Centre;
        private System.Windows.Forms.Label Top;
        private System.Windows.Forms.Label Left;
        private System.Windows.Forms.Label Right;
        private System.Windows.Forms.Label Bottom;
        private System.Windows.Forms.Label TopRight;
        private System.Windows.Forms.Label BottomRight;
        private System.Windows.Forms.Label TopLeft;
        private System.Windows.Forms.Label BottomLeft;
        private System.Windows.Forms.ComboBox ComboBoxComms;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

