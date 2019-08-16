using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projector_Measurements
{
    public partial class MeasurmentsForm : Form
    {
        MinoltaRig minolta;
        DataCentreClass data = new DataCentreClass();
        Projector projector = new Projector();
        PleaseWaitForm pleasewait = new PleaseWaitForm("Finished Taking Measurements...", true);
        string projectorcomms = Properties.Settings.Default.ProjectorComms;


        public MeasurmentsForm(MinoltaRig device, string resolution)
        {
            InitializeComponent();
            if (!String.IsNullOrEmpty(projectorcomms))
            {
                projector.InitialiseCommands("protocol\\", Properties.Settings.Default.ProjectorType);

            }
            minolta = device;
            resolutionLabel.Text = resolution;
            data.resolution = resolution;
        }

        private void GetMeasurementsButton_Click(object sender, EventArgs e)
        {
            
            data.name = nameTextBox.Text;
            data.projectorID = projectorSerialNumberTextBox.Text;
            data.lampType = lampTypeTextBox.Text;

            WhiteMeasurementsPanel.Enabled = true;
            WhiteLuxTextLabel.Text = "Measuring White...";

            projector.OpenShutter();
            projector.WhiteTP();
            refreshMinolta();
            WhiteLuxTextLabel.Text = "White";
            data.whiteNinePoint = GetLuxData(minolta.ReadNine());
            data.whiteCorners = GetLuxData(minolta.ReadNine());
            
            DisplayWhiteData(data.whiteNinePoint, data.whiteCorners);

            BlackMeasurmentsPanel.Enabled = true;
            BlackLuxTextLabel.Text = "Measuring Black...";
            this.Refresh();
            projector.BlackTP();         
            
            refreshMinolta();
            BlackLuxTextLabel.Text = "Black";
            data.blackNinePoint = GetLuxData(minolta.ReadNine());
            data.blackCorners = GetLuxData(minolta.ReadCorners());

            DisplayBlackData(data.blackNinePoint, data.blackCorners);
            
            DarkMeasurementsPanel.Enabled = true;
            DarkLuxTextLabel.Text = "Measuring Dark...";
            this.Refresh();
            projector.CloseShutter();

            refreshMinolta();
            DarkLuxTextLabel.Text = "Dark";
            data.darkNinePoint = GetLuxData(minolta.ReadNine());
            data.darkCorners = GetLuxData(minolta.ReadCorners());

            DisplayDarkData(data.darkNinePoint, data.darkCorners);
            this.Refresh();

            data.ansiLumens = Calculations.AnsiLumens(data.whiteNinePoint);
            Console.WriteLine("data class Lumens: "+ data.ansiLumens);
            data.ansiUniformity = Calculations.AnsiUniformity(data.whiteNinePoint, data.whiteCorners);
            data.dpUniformity = Calculations.DPUniformity(data.whiteNinePoint);
            data.fullScreenContrast = Calculations.FullScreenContrast(data.whiteNinePoint, data.blackNinePoint, data.darkNinePoint);
            data.centreLumens = Calculations.CenterLumens(data.whiteNinePoint[4]);
            data.centreContrast = Calculations.CenterContrast(data.whiteNinePoint[4], data.blackNinePoint[4], data.darkNinePoint[4]);

            DisplayReadings(data.ansiLumens,data.ansiUniformity,data.dpUniformity, data.fullScreenContrast,data.centreLumens, data.centreContrast);

            pleasewait.ShowDialog();
        }

        private double[] GetLuxData(string[] data)
        {
            double[] lxdata = Processing.ProcessData(data);
            return lxdata;
            
        }

        private void refreshMinolta()
        {
            for (int i = 0; i < 5; i++)
            {
                minolta.ReadNine();
                minolta.ReadCorners();
            }
        }

        private void DisplayWhiteData(double[] npData, double[] cData)
        {
            string round = "#.00";
            TopLeftWhite.Text = npData[0].ToString(round);
            TopWhite.Text = npData[1].ToString(round);
            TopRightWhite.Text = npData[2].ToString(round);
            LeftWhite.Text = npData[3].ToString(round);
            CentreWhite.Text = npData[4].ToString(round);
            RightWhite.Text = npData[5].ToString(round);
            BottomLeftWhite.Text = npData[6].ToString(round);
            BottomWhite.Text = npData[7].ToString(round);
            BottomRightWhite.Text = npData[8].ToString(round);
            TLCornerWhite.Text = cData[0].ToString();
            TRCornerWhite.Text = cData[1].ToString();
            BLCornerWhite.Text = cData[2].ToString();
            BRCornerWhite.Text = cData[3].ToString(); 
        }

        private void DisplayBlackData(double[] npData, double[] cData)
        {
            string round = "#.00";
            TopLeftBlack.Text = npData[0].ToString(round);
            TopBlack.Text = npData[1].ToString(round);
            TopRightBlack.Text = npData[2].ToString(round);
            LeftBlack.Text = npData[3].ToString(round);
            CentreBlack.Text = npData[4].ToString(round);
            RightBlack.Text = npData[5].ToString(round);
            BottomLeftBlack.Text = npData[6].ToString(round);
            BottomBlack.Text = npData[7].ToString(round);
            BottomRightBlack.Text = npData[8].ToString(round);
            TLCornerBlack.Text = cData[0].ToString();
            TRCornerBlack.Text = cData[1].ToString();
            BLCornerBlack.Text = cData[2].ToString();
            BRCornerBlack.Text = cData[3].ToString();
        }

        private void DisplayDarkData(double[] npData, double[] cData)
        {
            string round = "#.00";
            TopLeftDark.Text = npData[0].ToString(round);
            TopDark.Text = npData[1].ToString(round);
            TopRightDark.Text = npData[2].ToString(round);
            LeftDark.Text = npData[3].ToString(round);
            CentreDark.Text = npData[4].ToString(round);
            RightDark.Text = npData[5].ToString(round);
            BottomLeftDark.Text = npData[6].ToString(round);
            BottomDark.Text = npData[7].ToString(round);
            BottomRightDark.Text = npData[8].ToString(round);
            TLCornerDark.Text = cData[0].ToString();
            TRCornerDark.Text = cData[1].ToString();
            BLCornerDark.Text = cData[2].ToString();
            BRCornerDark.Text = cData[3].ToString();
        }

        private void DisplayReadings(double ansiLumens, double ansiUniformity, double dpUniformity, double fullScreenContrast, double centreLumens, double centreContrast)
        {
            AnsiLumensReadingLabel.Text = ansiLumens.ToString("#");
            AnsiUniformityReadingLabel.Text = ansiUniformity.ToString("#") + " %";
            DpUniformityReadingLabel.Text = dpUniformity.ToString("#") + " %";
            FullScreenContrastReadingLabel.Text = fullScreenContrast.ToString("#0") + " :1";
            CenterLumensReadingLabel.Text = centreLumens.ToString("#");
            CenterContrastReadingLabel.Text = centreContrast.ToString("#0") + " :1";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            try
            {
                CSVSave.SaveData(data);

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No data to Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //var pleasewait = new PleaseWaitForm("Saving...", false);

            //pleasewait.Show();

            //try
            //{
            //    SQLSaveData.saveData(data);
            //}
            //catch(Exception error)
            //{
            //    MessageBox.Show("Error saving to SQL Database" + error.ToString());
            //}

            //pleasewait.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            PrintForm print = new PrintForm(data);
            print.Show();
            */

            PrintDataForm print = new PrintDataForm(data);
            print.Print();
            
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
