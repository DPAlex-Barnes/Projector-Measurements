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
        string[] ThirteenPoint = new string[13];
        
        double[] data;
        double[] cornerdata;

        double ansiLumens;
        bool isRunning = false;
        
        public MainForm()
        {
            InitializeComponent();
            ComboBoxComms.Items.AddRange(minolta.comms);
            Processing.compensationFactor = 1.05;
            

        }
        #region get lumens button click

        private void StartButton_Click(object sender, EventArgs e)
        {
            Calculations.area = SetResAreaDisplay(resolutionComboBox.SelectedItem.ToString());
            isRunning = true;
            var t = Task.Run((Action)(() =>
            {
                while (isRunning)
                {
                    ninePoint = minolta.ReadNine();
                    corners = minolta.ReadCorners();
                    data = Processing.ProcessData(ninePoint);
                    cornerdata = Processing.ProcessData(corners);
                    ansiLumens = Calculations.AnsiLumens(data);
                    Thread.Sleep(80);
                    Invoke(new Action(() =>
                        {
                            DisplayReading(data, cornerdata, ansiLumens);
                        }));
                }
            }));
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
                BtnConnect.Enabled = false;
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

        private void button2_Click(object sender, EventArgs e)
        {
            isRunning = false;
        }


        #endregion
        private string DisplayReading(double[] npData, double[] cData, double reading) {
            string round = "#.00";
            TopLeft.Text = npData[0].ToString(round);
            Top.Text = npData[1].ToString(round);
            TopRight.Text = npData[2].ToString(round);
            Left.Text = npData[3].ToString(round);
            Centre.Text = npData[4].ToString(round);
            Right.Text = npData[5].ToString(round);
            BottomLeft.Text = npData[6].ToString(round);
            Bottom.Text = npData[7].ToString(round);
            BottomRight.Text = npData[8].ToString(round);
            TLCorner.Text = cData[0].ToString();
            TRCorner.Text = cData[1].ToString();
            BLCorner.Text = cData[2].ToString();
            BRCorner.Text = cData[3].ToString();

            if (reading > 1000)
            {
                return LumensRead.Text = reading.ToString("#");
            }
            else
            {
               return LumensRead.Text = reading.ToString(round);
            }
        }

        private double SetResAreaDisplay(string res)
        {
            if (res.Equals("DC2K"))
                {
                return 3.84;
                }
            else if (res.Equals("WUXGA"))
            {
                return 4.54;
            }
            else if (res.Equals("1080p"))
            {
                return 4.10;
            }
            else
            {
                return 0;
            }
        }
        

        
    }

  

}
