using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projector_Measurements
{
    public partial class MainForm : Form
    {
        public MinoltaRig minolta = new MinoltaRig();
        bool isConnected = false;
        string[] ninePoint = new string[9];
        string[] corners = new string[4];
        string[] ThirteenPoint = new string[13];
        
        double[] data;
        double[] cornerdata;

        double ansiLumens;
        
        bool isRunning = false;
        bool StartUpComplete = false;


        public MainForm()
        {
            
            InitializeComponent();
 
        }
        #region get lumens button click

        private void StartButton_Click(object sender, EventArgs e)
        {
            
            StartButton.Enabled = false;
            Console.WriteLine(Processing.compensationFactor);
            try
            {
                string selectedResolution = resolutionComboBox.SelectedItem.ToString();
                SetScreenArea(selectedResolution);
                isRunning = true;
                resolutionComboBox.Enabled = false;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please select a resolution");
                StartButton.Enabled = true;
            }
                      
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
            var pleaseWait = new PleaseWaitForm("Please Wait...", false);          

            pleaseWait.Show();
            
            label1.Text = "Connecting...";
            label1.ForeColor = System.Drawing.Color.Orange;
            isConnected = minolta.Initialise(Properties.Settings.Default.MinoltaComms);

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
                resolutionComboBox.Visible = true;
                StartButton.Visible = true;
                StopButton.Visible = true;
                GetMeasurementsButton.Visible = true;
                label1.Text = "Online";
                label1.ForeColor = System.Drawing.Color.Green;
            }
            pleaseWait.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isRunning = false;
            StartButton.Enabled = true;
            resolutionComboBox.Enabled = true;
        }


        #endregion

        #region Display Readings

        private string DisplayReading(double[] npData, double[] cData, double reading)
        {

            string round = "#.00";

            foreach (double i in npData)
            {
                Console.WriteLine($"Data point: {i}");
                if (i > 1000)
                {
                    round = "#";
                }
                else
                {
                    round = "#.00";
                }
            }

            foreach (double i in cData)
            {
                Console.WriteLine($"Data point: {i}");
                if (i > 1000)
                {
                    round = "#";
                }
                else
                {
                    round = "#.00";
                }
            }

            TopLeft.Text = npData[0].ToString(round);
            Top.Text = npData[1].ToString(round);
            TopRight.Text = npData[2].ToString(round);
            Left.Text = npData[3].ToString(round);
            Centre.Text = npData[4].ToString(round);
            Right.Text = npData[5].ToString(round);
            BottomLeft.Text = npData[6].ToString(round);
            Bottom.Text = npData[7].ToString(round);
            BottomRight.Text = npData[8].ToString(round);

            TLCorner.Text = cData[0].ToString(round);
            TRCorner.Text = cData[1].ToString(round);
            BLCorner.Text = cData[2].ToString(round);
            BRCorner.Text = cData[3].ToString(round);

            if (reading > 1000)
            {
                return LumensRead.Text = reading.ToString("#");
            }
            else
            {
                return LumensRead.Text = reading.ToString(round);
            }
        }

        #endregion

        private void SetScreenArea(string resolution)
        {
            int width = 0;
            int height = 0;
            double screenWidth = Properties.Settings.Default.ScreenWidth;

            switch (resolution)
            {
                case "DC4K":
                    width = 4096;
                    height = 2160;
                    break;
                case "UHD 4K":
                    width = 3840;
                    height = 2160;
                    break;
                case "WUXGA":
                    width = 1920;
                    height = 1200;
                    break;
                case "1080p":
                    width = 1920;
                    height = 1080;
                    break;
                default:
                    break;

            }

            Calculations.CalculateScreenSize(width, height, screenWidth);

        }

        private void GetMeasurementsButton_Click(object sender, EventArgs e)
        {

            isRunning = false;
            SetScreenArea(resolutionComboBox.SelectedItem.ToString());
            var selectprojector = new SelectprojectorForm();
            selectprojector.ShowDialog();
            var measurements = new MeasurmentsForm(minolta, resolutionComboBox.SelectedItem.ToString());           
            measurements.ShowDialog();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void userSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserSettingsForm userform = new UserSettingsForm();
            userform.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            resolutionComboBox.SelectedIndex = Properties.Settings.Default.ResolutionIndex;
            MinoltaConnect();

            if (String.IsNullOrEmpty(Properties.Settings.Default.MinoltaComms))
            {
                MessageBox.Show("Please Connect To Correct comm port from Settings");
                UserSettingsForm userform = new UserSettingsForm();
                userform.Show();
            }
        }

        private void MinoltaConnect()
        {
            var pleaseWait = new PleaseWaitForm("Please Wait...", false);

            pleaseWait.Show();

            label1.Text = "Connecting...";
            label1.ForeColor = System.Drawing.Color.Orange;
            isConnected = minolta.Initialise(Properties.Settings.Default.MinoltaComms);

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
                resolutionComboBox.Visible = true;
                StartButton.Visible = true;
                StopButton.Visible = true;
                GetMeasurementsButton.Visible = true;
                label1.Text = "Online";
                label1.ForeColor = System.Drawing.Color.Green;
            }
            pleaseWait.Close();
        }

        private void resolutionComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ResolutionIndex = resolutionComboBox.SelectedIndex;
            Properties.Settings.Default.Save();
        }
    }

}
