namespace Projector_Measurements
{
    partial class UserSettingsForm
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
            this.CompFactorLabel = new System.Windows.Forms.Label();
            this.CompFactorTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.FilePathBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.screenWidthLabel = new System.Windows.Forms.Label();
            this.screenWidthTextBox = new System.Windows.Forms.TextBox();
            this.CommPortLabel = new System.Windows.Forms.Label();
            this.MinoltaComboBox = new System.Windows.Forms.ComboBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.CommsGroupBox = new System.Windows.Forms.GroupBox();
            this.ProjectorComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveDataGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ServerPathLabel = new System.Windows.Forms.Label();
            this.SettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.CommsGroupBox.SuspendLayout();
            this.SaveDataGroupBox.SuspendLayout();
            this.SettingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CompFactorLabel
            // 
            this.CompFactorLabel.AutoSize = true;
            this.CompFactorLabel.Location = new System.Drawing.Point(9, 21);
            this.CompFactorLabel.Name = "CompFactorLabel";
            this.CompFactorLabel.Size = new System.Drawing.Size(113, 13);
            this.CompFactorLabel.TabIndex = 0;
            this.CompFactorLabel.Text = "Compensation Factor :";
            // 
            // CompFactorTextBox
            // 
            this.CompFactorTextBox.Location = new System.Drawing.Point(128, 18);
            this.CompFactorTextBox.Name = "CompFactorTextBox";
            this.CompFactorTextBox.Size = new System.Drawing.Size(91, 20);
            this.CompFactorTextBox.TabIndex = 1;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(417, 163);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 2;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "File Path :";
            // 
            // PathTextBox
            // 
            this.PathTextBox.Location = new System.Drawing.Point(80, 22);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(233, 20);
            this.PathTextBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 20);
            this.button1.TabIndex = 5;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // screenWidthLabel
            // 
            this.screenWidthLabel.AutoSize = true;
            this.screenWidthLabel.Location = new System.Drawing.Point(33, 51);
            this.screenWidthLabel.Name = "screenWidthLabel";
            this.screenWidthLabel.Size = new System.Drawing.Size(89, 13);
            this.screenWidthLabel.TabIndex = 6;
            this.screenWidthLabel.Text = "Screen Width(m):";
            // 
            // screenWidthTextBox
            // 
            this.screenWidthTextBox.Location = new System.Drawing.Point(128, 48);
            this.screenWidthTextBox.Name = "screenWidthTextBox";
            this.screenWidthTextBox.Size = new System.Drawing.Size(91, 20);
            this.screenWidthTextBox.TabIndex = 7;
            // 
            // CommPortLabel
            // 
            this.CommPortLabel.AutoSize = true;
            this.CommPortLabel.Location = new System.Drawing.Point(9, 28);
            this.CommPortLabel.Name = "CommPortLabel";
            this.CommPortLabel.Size = new System.Drawing.Size(75, 13);
            this.CommPortLabel.TabIndex = 8;
            this.CommPortLabel.Text = "Minolta T-10 : ";
            // 
            // MinoltaComboBox
            // 
            this.MinoltaComboBox.BackColor = System.Drawing.Color.White;
            this.MinoltaComboBox.FormattingEnabled = true;
            this.MinoltaComboBox.Location = new System.Drawing.Point(87, 25);
            this.MinoltaComboBox.Name = "MinoltaComboBox";
            this.MinoltaComboBox.Size = new System.Drawing.Size(117, 21);
            this.MinoltaComboBox.TabIndex = 13;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(323, 163);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 14;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CommsGroupBox
            // 
            this.CommsGroupBox.Controls.Add(this.ProjectorComboBox);
            this.CommsGroupBox.Controls.Add(this.label2);
            this.CommsGroupBox.Controls.Add(this.MinoltaComboBox);
            this.CommsGroupBox.Controls.Add(this.CommPortLabel);
            this.CommsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.CommsGroupBox.Name = "CommsGroupBox";
            this.CommsGroupBox.Size = new System.Drawing.Size(219, 104);
            this.CommsGroupBox.TabIndex = 15;
            this.CommsGroupBox.TabStop = false;
            this.CommsGroupBox.Text = "RS-232 Communication";
            // 
            // ProjectorComboBox
            // 
            this.ProjectorComboBox.BackColor = System.Drawing.Color.White;
            this.ProjectorComboBox.FormattingEnabled = true;
            this.ProjectorComboBox.Location = new System.Drawing.Point(87, 54);
            this.ProjectorComboBox.Name = "ProjectorComboBox";
            this.ProjectorComboBox.Size = new System.Drawing.Size(117, 21);
            this.ProjectorComboBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Projector : ";
            // 
            // SaveDataGroupBox
            // 
            this.SaveDataGroupBox.Controls.Add(this.textBox1);
            this.SaveDataGroupBox.Controls.Add(this.ServerPathLabel);
            this.SaveDataGroupBox.Controls.Add(this.label1);
            this.SaveDataGroupBox.Controls.Add(this.PathTextBox);
            this.SaveDataGroupBox.Controls.Add(this.button1);
            this.SaveDataGroupBox.Location = new System.Drawing.Point(243, 12);
            this.SaveDataGroupBox.Name = "SaveDataGroupBox";
            this.SaveDataGroupBox.Size = new System.Drawing.Size(349, 104);
            this.SaveDataGroupBox.TabIndex = 16;
            this.SaveDataGroupBox.TabStop = false;
            this.SaveDataGroupBox.Text = "Save Data";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 20);
            this.textBox1.TabIndex = 7;
            // 
            // ServerPathLabel
            // 
            this.ServerPathLabel.AutoSize = true;
            this.ServerPathLabel.Location = new System.Drawing.Point(6, 62);
            this.ServerPathLabel.Name = "ServerPathLabel";
            this.ServerPathLabel.Size = new System.Drawing.Size(68, 13);
            this.ServerPathLabel.TabIndex = 6;
            this.ServerPathLabel.Text = "SQL Server :";
            // 
            // SettingsGroupBox
            // 
            this.SettingsGroupBox.Controls.Add(this.CompFactorLabel);
            this.SettingsGroupBox.Controls.Add(this.CompFactorTextBox);
            this.SettingsGroupBox.Controls.Add(this.screenWidthTextBox);
            this.SettingsGroupBox.Controls.Add(this.screenWidthLabel);
            this.SettingsGroupBox.Location = new System.Drawing.Point(12, 122);
            this.SettingsGroupBox.Name = "SettingsGroupBox";
            this.SettingsGroupBox.Size = new System.Drawing.Size(231, 85);
            this.SettingsGroupBox.TabIndex = 17;
            this.SettingsGroupBox.TabStop = false;
            this.SettingsGroupBox.Text = "Settings";
            // 
            // UserSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(626, 257);
            this.Controls.Add(this.SettingsGroupBox);
            this.Controls.Add(this.SaveDataGroupBox);
            this.Controls.Add(this.CommsGroupBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SubmitButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserSettingsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UserSettingsForm_Load);
            this.CommsGroupBox.ResumeLayout(false);
            this.CommsGroupBox.PerformLayout();
            this.SaveDataGroupBox.ResumeLayout(false);
            this.SaveDataGroupBox.PerformLayout();
            this.SettingsGroupBox.ResumeLayout(false);
            this.SettingsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CompFactorLabel;
        private System.Windows.Forms.TextBox CompFactorTextBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.FolderBrowserDialog FilePathBrowser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label screenWidthLabel;
        private System.Windows.Forms.TextBox screenWidthTextBox;
        private System.Windows.Forms.Label CommPortLabel;
        private System.Windows.Forms.ComboBox MinoltaComboBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.GroupBox CommsGroupBox;
        private System.Windows.Forms.ComboBox ProjectorComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox SaveDataGroupBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label ServerPathLabel;
        private System.Windows.Forms.GroupBox SettingsGroupBox;
    }
}