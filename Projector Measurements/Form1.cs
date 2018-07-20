using System;
using System.Windows.Forms;

namespace Projector_Measurements
{
    public partial class Form1 : Form
    {
        MinoltaRig minolta = new MinoltaRig();
        bool isConnected = false;

        double compensationFactor = 1.05;
        double[] multipliers = { 1/10000, 1/1000, 1/100, 1/10, 1,
                10, 100, 10000, 100000, 1000000 };

        double Wuxga = 4.56;
        double[] ninePoint = new double[9] { 699, 663, 668, 513, 595, 559, 673, 529, 541 };
        string[] lxData = new string[9] { "+ 3485", "+23455", "+54365", "+23435", "+   55", "+   65", "+ 6545", "+45655", "+  235" };

        public Form1()
        {
            InitializeComponent();
            ComboBoxComms.Items.AddRange(minolta.comms);
        }
        #region get lumens button click

        private void button1_Click(object sender, EventArgs e)
        {
            ninePoint = ProcessData(minolta.Read());

            string reading = Convert.ToString(Calculations.Lumens(ninePoint, Wuxga));
            TopLeft.Text = Convert.ToString(ninePoint[0]);
            Top.Text = Convert.ToString(ninePoint[1]);
            TopRight.Text = Convert.ToString(ninePoint[2]);
            Left.Text = Convert.ToString(ninePoint[3]);
            Centre.Text = Convert.ToString(ninePoint[4]);
            Right.Text = Convert.ToString(ninePoint[5]);
            BottomLeft.Text = Convert.ToString(ninePoint[6]);
            Bottom.Text = Convert.ToString(ninePoint[7]);
            BottomRight.Text = Convert.ToString(ninePoint[8]);

            LumensRead.Text = reading;
        }
        #endregion

        #region Serial connect button click

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            bool Complete = false;
            label1.Text = "Connecting...";
            isConnected = minolta.Initialise((string)ComboBoxComms.SelectedItem);
            
            if (isConnected)
            {
                Complete = minolta.Start();
            }
            if (Complete)
            {
                label1.Text = "Connected";
            }
        }  
    #endregion

        public double[] ProcessData(string[] data)
        {
            
            double[] processed = new double[9];
            int multiplierIndex = int.Parse(data[0][data[0].Length-1].ToString());
            
            for (int i = 0; i < data.Length; i++)
            {
                string s = data[i];
                if (s.StartsWith("+"))
                {
                    data[i] = s.Substring(1,4);
                    data[i] = data[i].Trim();
                    processed[i] = double.Parse(data[i]);

                }
                else if (s.StartsWith("-"))
                {
                    data[i] = s.Substring(1,4);
                    data[i] = data[i].Trim();
                    processed[i] = double.Parse(data[i]);
                }                        
               
            }

            foreach (double point in processed)
            {
                processed[Array.IndexOf(processed, point)] = (point * multipliers[multiplierIndex])* compensationFactor;
            }

            return processed;
        }         
        
    }

  

}
