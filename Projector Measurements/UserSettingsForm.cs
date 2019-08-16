using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace Projector_Measurements
{
    public partial class UserSettingsForm : Form
    {
        public UserSettingsForm()
        {
            InitializeComponent();
            string[] comms = SerialPort.GetPortNames();
            
            MinoltaComboBox.Items.AddRange(comms);
            ProjectorComboBox.Items.AddRange(comms);

        }

        private void UserSettingsForm_Load(object sender, EventArgs e)
        {
            MinoltaComboBox.SelectedItem = Properties.Settings.Default.MinoltaComms;
            ProjectorComboBox.SelectedItem = Properties.Settings.Default.ProjectorComms;
            PathTextBox.Text = Properties.Settings.Default.CSVPath;
            CompFactorTextBox.Text = Properties.Settings.Default.CompensationFactor.ToString();
            screenWidthTextBox.Text = Properties.Settings.Default.ScreenWidth.ToString();

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.MinoltaComms = MinoltaComboBox.SelectedItem.ToString();
            Properties.Settings.Default.ProjectorComms = ProjectorComboBox.SelectedItem.ToString();
            Properties.Settings.Default.CSVPath = PathTextBox.Text;
            Properties.Settings.Default.CompensationFactor = double.Parse(CompFactorTextBox.Text);
            Properties.Settings.Default.ScreenWidth = double.Parse(screenWidthTextBox.Text);
            Properties.Settings.Default.Save();
            Processing.compensationFactor = Properties.Settings.Default.CompensationFactor;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.FilePathBrowser = new FolderBrowserDialog();
            DialogResult result = FilePathBrowser.ShowDialog();
            PathTextBox.Text = FilePathBrowser.SelectedPath;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
