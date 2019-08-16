using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Projector_Measurements
{
    public partial class PrintForm : Form
    {
        DataCentreClass currentdata;
        string date = DateTime.Now.ToShortDateString();
        string time = DateTime.Now.ToShortTimeString();

        public PrintForm(DataCentreClass data)
        {
            InitializeComponent();
            currentdata = data;
            
        }

        private void PrintForm_Load(object sender, EventArgs e)
        {
            NameFieldLabel.Text = currentdata.name;
            ProjectorSerialLabel.Text = currentdata.projectorID;
            LampTypeLabel.Text = currentdata.lampType;
            ResolutionLabel.Text = currentdata.resolution;

            AnsiLumensLabel.Text = currentdata.ansiLumens.ToString("#");
            AnsiUniformityLabel.Text = currentdata.ansiUniformity.ToString("#00") + " %";
            DpUniformitylabel.Text = currentdata.dpUniformity.ToString("#00") + " %";
            FscLabel.Text = currentdata.fullScreenContrast.ToString("#00") + " : 1";

            CentreLumensLabel.Text = currentdata.centreLumens.ToString("#");
            CentreContrastLabel.Text = currentdata.centreContrast.ToString("#00") + " : 1";

            DateTimeLabel.Text = $"{date} {time}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDocument doc = new PrintDocument();
            doc.DefaultPageSettings.Margins = new Margins(25,25,25,25);
            doc.PrintPage += doc_PrintPage;

            PrintDialog dlg = new PrintDialog();
            dlg.Document = doc;

            if(dlg.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
            
        }

        private void doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;
            Bitmap bmp = new Bitmap(PrintWindowPanel.Width, PrintWindowPanel.Height);
            PrintWindowPanel.DrawToBitmap(bmp, new Rectangle(0, 0, PrintWindowPanel.Width, PrintWindowPanel.Height));
            e.Graphics.DrawImage((Image)bmp, x, y);
        }
    }
}
