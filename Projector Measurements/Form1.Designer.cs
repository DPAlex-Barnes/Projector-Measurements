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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LumensText
            // 
            this.LumensText.AutoSize = true;
            this.LumensText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LumensText.Location = new System.Drawing.Point(337, 79);
            this.LumensText.Name = "LumensText";
            this.LumensText.Size = new System.Drawing.Size(83, 20);
            this.LumensText.TabIndex = 0;
            this.LumensText.Text = "Lumens = ";
            // 
            // LumensRead
            // 
            this.LumensRead.AutoSize = true;
            this.LumensRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LumensRead.Location = new System.Drawing.Point(426, 79);
            this.LumensRead.Name = "LumensRead";
            this.LumensRead.Size = new System.Drawing.Size(45, 20);
            this.LumensRead.TabIndex = 1;
            this.LumensRead.Text = "0000";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "Get Lumens";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Centre
            // 
            this.Centre.AutoSize = true;
            this.Centre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Centre.Location = new System.Drawing.Point(373, 214);
            this.Centre.Name = "Centre";
            this.Centre.Size = new System.Drawing.Size(45, 20);
            this.Centre.TabIndex = 3;
            this.Centre.Text = "0000";
            // 
            // Top
            // 
            this.Top.AutoSize = true;
            this.Top.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Top.Location = new System.Drawing.Point(373, 141);
            this.Top.Name = "Top";
            this.Top.Size = new System.Drawing.Size(45, 20);
            this.Top.TabIndex = 4;
            this.Top.Text = "0000";
            // 
            // Left
            // 
            this.Left.AutoSize = true;
            this.Left.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Left.Location = new System.Drawing.Point(250, 214);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(45, 20);
            this.Left.TabIndex = 5;
            this.Left.Text = "0000";
            // 
            // Right
            // 
            this.Right.AutoSize = true;
            this.Right.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Right.Location = new System.Drawing.Point(501, 214);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(45, 20);
            this.Right.TabIndex = 6;
            this.Right.Text = "0000";
            // 
            // Bottom
            // 
            this.Bottom.AutoSize = true;
            this.Bottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bottom.Location = new System.Drawing.Point(373, 284);
            this.Bottom.Name = "Bottom";
            this.Bottom.Size = new System.Drawing.Size(45, 20);
            this.Bottom.TabIndex = 7;
            this.Bottom.Text = "0000";
            // 
            // TopRight
            // 
            this.TopRight.AutoSize = true;
            this.TopRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopRight.Location = new System.Drawing.Point(501, 141);
            this.TopRight.Name = "TopRight";
            this.TopRight.Size = new System.Drawing.Size(45, 20);
            this.TopRight.TabIndex = 8;
            this.TopRight.Text = "0000";
            // 
            // BottomRight
            // 
            this.BottomRight.AutoSize = true;
            this.BottomRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottomRight.Location = new System.Drawing.Point(501, 284);
            this.BottomRight.Name = "BottomRight";
            this.BottomRight.Size = new System.Drawing.Size(45, 20);
            this.BottomRight.TabIndex = 9;
            this.BottomRight.Text = "0000";
            // 
            // TopLeft
            // 
            this.TopLeft.AutoSize = true;
            this.TopLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopLeft.Location = new System.Drawing.Point(250, 141);
            this.TopLeft.Name = "TopLeft";
            this.TopLeft.Size = new System.Drawing.Size(45, 20);
            this.TopLeft.TabIndex = 10;
            this.TopLeft.Text = "0000";
            // 
            // BottomLeft
            // 
            this.BottomLeft.AutoSize = true;
            this.BottomLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottomLeft.Location = new System.Drawing.Point(250, 284);
            this.BottomLeft.Name = "BottomLeft";
            this.BottomLeft.Size = new System.Drawing.Size(45, 20);
            this.BottomLeft.TabIndex = 11;
            this.BottomLeft.Text = "0000";
            // 
            // ComboBoxComms
            // 
            this.ComboBoxComms.FormattingEnabled = true;
            this.ComboBoxComms.Location = new System.Drawing.Point(24, 79);
            this.ComboBoxComms.Name = "ComboBoxComms";
            this.ComboBoxComms.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxComms.TabIndex = 12;
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(45, 118);
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
            this.label1.Location = new System.Drawing.Point(21, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(606, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(606, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(606, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 459);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.ComboBoxComms);
            this.Controls.Add(this.BottomLeft);
            this.Controls.Add(this.TopLeft);
            this.Controls.Add(this.BottomRight);
            this.Controls.Add(this.TopRight);
            this.Controls.Add(this.Bottom);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.Top);
            this.Controls.Add(this.Centre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LumensRead);
            this.Controls.Add(this.LumensText);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

