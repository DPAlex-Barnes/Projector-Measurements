
using System.IO;
using System.Drawing.Printing;
using System.Drawing;
using System;

namespace Projector_Measurements
{
    
    class PrintDataForm : IDisposable
    {
        bool disposed = false;
        private Font Consolas11Font;
        private StreamReader reader;
        private DataCentreClass data = new DataCentreClass();

        public PrintDataForm(DataCentreClass importeddata)
        {
            data = importeddata;
            var file = File.AppendText("~Optical Measurements.txt");
            
            file.WriteLine("Digital Projection Optical Performance Report");
            file.WriteLine();
            file.WriteLine();

            file.WriteLine($"Date/Time:              {data.date} {data.time} ");
            file.WriteLine($"Name:                   {data.name}");
            file.WriteLine($"Projector ID:           {data.projectorID}");
            file.WriteLine($"Lamp Type:              {data.lampType} ");
            file.WriteLine();

            file.WriteLine($"Format:                 {data.resolution}");
            file.WriteLine($"Area:                   {data.area.ToString("F2")} m" + "\x00B2");


            file.WriteLine();

            file.WriteLine($"ANSI Lumens:            {data.ansiLumens.ToString("#")} Lumens ");
            file.WriteLine($"ANSI Uniformity:        {data.ansiUniformity.ToString("#")}%");
            file.WriteLine($"DP Uniformity:          {data.dpUniformity.ToString("#")}%");
            file.WriteLine($"Full Screen Contrast:   {data.fullScreenContrast.ToString("#")}:1");

            file.WriteLine();

            file.WriteLine($"Centre Lumens:          {data.centreLumens.ToString("#")} Lumens");
            file.WriteLine($"Centre Contrast:        {data.centreContrast.ToString("#")}:1");

            file.Close();
        }
        
        public void Print()
        {
            reader = File.OpenText("~Optical Measurements.txt");
            Consolas11Font = new Font("Consolas", 11);
            PrintDocument doc = new PrintDocument();

            doc.PrintPage += PrintTextFileHandler;

            
            System.Windows.Forms.PrintDialog dlg = new System.Windows.Forms.PrintDialog();
            System.Windows.Forms.PrintPreviewDialog preview = new System.Windows.Forms.PrintPreviewDialog();

            dlg.Document = doc;
            preview.Document = doc;

            //if (preview.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
            //{
                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    doc.Print();
                }
            //}

            reader.Close();
            
            File.Delete("~Optical Measurements.txt");
            
        }

        private void PrintTextFileHandler(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;

            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;

            StringFormat formatleft = new StringFormat(StringFormatFlags.NoClip);
            
            string line = null;

            linesPerPage = e.MarginBounds.Height / Consolas11Font.GetHeight(g);

            while (count < linesPerPage && (line = reader.ReadLine()) != null)
            {
                if (count == 0)
                {
                    float center = (e.PageBounds.Width / 2) - (e.Graphics.MeasureString(line, Consolas11Font).Width/2);
                    yPos = topMargin + (count * Consolas11Font.GetHeight(g));
                    g.DrawString(line, Consolas11Font, Brushes.Black, center, yPos, formatleft);
                    count++;
                }
                else
                {
                    yPos = topMargin + (count * Consolas11Font.GetHeight(g));
                    g.DrawString(line, Consolas11Font, Brushes.Black, leftMargin, yPos, formatleft);
                    count++;
                }
                
            }

            if (line!= null)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
            
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(Boolean disposing)
        {
            if (disposed)
            {
                return;
            }

            if (disposing)
            {
                Consolas11Font.Dispose();
            }

            disposed = true;
        }

        ~PrintDataForm()
        {
            Dispose(false);
        }

    }


}
