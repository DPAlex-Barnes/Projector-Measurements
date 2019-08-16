using System;
using System.Windows.Forms;

namespace Projector_Measurements
{
    public partial class PleaseWaitForm : Form
    {

        public PleaseWaitForm(string message, bool isVisible)
        {
            
            InitializeComponent();
            OKButton.Visible = isVisible;
            MessageLabel.Text = message;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
