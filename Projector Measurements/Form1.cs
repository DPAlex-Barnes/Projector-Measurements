using System;
using System.Windows.Forms;

namespace Projector_Measurements
{
    public partial class Form1 : Form
    {
        MinoltaRig minolta = new MinoltaRig();
        bool isConnected = false;

        double compensationFactor = 1.05;
        double[] multipliers = { 0.00001, 0.0001, 0.001 ,0.1, 1,
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
            else
            {
                label1.Text = "No Connection Established";
            }
            if (Complete)
            {
                label1.Text = "Connected";
            }
        }
        #endregion

        private double[] ProcessData(string[] data)
        {
            double multiplier = GetMultiplier(data);
            double[] converted = ConvertToNumber(data);
            
            double[] processed = ApplyMultiplier(converted, multiplier);

            return processed;
        }

        private double[] ConvertToNumber(string[] dataArray)
        {
            double[] converted = new double[dataArray.Length];

            for (int i = 0; i < dataArray.Length; i++)
            {
                string s = dataArray[i];
                if (s.StartsWith("+"))
                {
                    dataArray[i] = s.Substring(1, 4);
                    dataArray[i] = dataArray[i].Trim();
                    converted[i] = double.Parse(dataArray[i]);

                }
                else if (s.StartsWith("-"))
                {
                    dataArray[i] = s.Substring(1, 4);
                    dataArray[i] = dataArray[i].Trim();
                    converted[i] = double.Parse(dataArray[i]);
                }
            }

            return converted;
        }

        private double GetMultiplier(string[] data)
        {
            string FirstString = data[0];
            int index = int.Parse(FirstString[FirstString.Length-1].ToString());
            
            return multipliers[index];
        }

        private double[] ApplyMultiplier(double[]data, double multiplier)
        {
            double[] applied = new double[data.Length];

            foreach (double number in data)
            {
                applied[Array.IndexOf(data, number)] = (number * multiplier) * compensationFactor;
            }
            return applied;
        }

    }

  

}
