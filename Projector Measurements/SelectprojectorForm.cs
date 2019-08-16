using System;
using System.IO;
using System.Windows.Forms;

namespace Projector_Measurements
{
    public partial class SelectprojectorForm : Form
    {
        public SelectprojectorForm()
        {
            InitializeComponent();
            comboBox1.DataSource = GetFileNames("protocol", "*.toast");
            
        }

        private string[] GetFileNames(string path, string filter)
        {
            string[] files = Directory.GetFiles(path, filter);
            for (int i = 0; i < files.Length; i++)
            {
                files[i] = Path.GetFileNameWithoutExtension(files[i]);
            }

            return files;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ProjectorType = comboBox1.SelectedItem.ToString();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
