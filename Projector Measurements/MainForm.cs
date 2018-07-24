using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projector_Measurements
{
    public partial class MainForm : Form
    {
        MinoltaRig minolta = new MinoltaRig();
        bool isConnected = false;
        string[] ninePoint = new string[9];
        string[] corners = new string[4];
        double[] data = new double[13];
        bool isRunning = false;

        public MainForm()
        {
            InitializeComponent();
            ComboBoxComms.Items.AddRange(minolta.comms);
            Processing.compensationFactor = 1.05;
            Calculations.area = 4.56;

        }
        #region get lumens button click

        private void button1_Click(object sender, EventArgs e)
        {
            isRunning = true;
            var t = Task.Run(() =>
            {
                while (isRunning)
                {
                    ninePoint = minolta.ReadNine();
                    corners = minolta.ReadCorners();
                    string[] ThirteenPoint = Processing.ConcatArrays(ninePoint, corners);
                    data = Processing.ProcessData(ThirteenPoint);
                    double reading = Calculations.Lumens(data);
                    Thread.Sleep(80);
                    Invoke(new Action(() =>
                        {
                            DisplayReading(data, reading);
                        }));
                }
            });
        }

        


        #endregion

            #region Serial connect button click

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            bool StartUpComplete = false;
            label1.Text = "Connecting...";
            isConnected = minolta.Initialise((string)ComboBoxComms.SelectedItem);

            if (isConnected)
            {
                StartUpComplete = minolta.Start();
            }
            else
            {
                label1.Text = "Offline";
                label1.ForeColor = System.Drawing.Color.Red;

            }

            if (StartUpComplete)
            {
                label1.Text = "Online";
                label1.ForeColor = System.Drawing.Color.Green;
            }
        }


        #endregion
        private string DisplayReading(double[] data, double reading) {
            string round = "#.00";
            TopLeft.Text = this.data[0].ToString(round);
            Top.Text = this.data[1].ToString("#.000");
            TopRight.Text = this.data[2].ToString("#.000");
            Left.Text = this.data[3].ToString("#.000");
            Centre.Text = this.data[4].ToString("#.000");
            Right.Text = this.data[5].ToString("#.000");
            BottomLeft.Text = this.data[6].ToString("#.000");
            Bottom.Text = this.data[7].ToString("#.000");
            BottomRight.Text = this.data[8].ToString("#.000");
            TLCorner.Text = this.data[9].ToString("#.000");
            TRCorner.Text = this.data[10].ToString("#.000");
            BLCorner.Text = this.data[11].ToString("#.000");
            BRCorner.Text = this.data[12].ToString("#.000");

            if (reading < 1000)
            {
                return LumensRead.Text = reading.ToString();
            }
            else
            {
               return LumensRead.Text = reading.ToString(round);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isRunning = false;
        }
    }

  

}
