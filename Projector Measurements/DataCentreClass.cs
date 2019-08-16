using System;

namespace Projector_Measurements
{
    public class DataCentreClass
    {
        public string date = DateTime.Now.ToShortDateString();
        public string time = DateTime.Now.ToShortTimeString();
        public string name { get; set; }
        public string projectorID { get; set; }
        public string lampType { get; set; }        
        
        public double[] whiteNinePoint { get; set; }
        public double[] whiteCorners { get; set; }
        public double[] blackNinePoint { get; set; }
        public double[] blackCorners { get; set; }
        public double[] darkNinePoint { get; set; }
        public double[] darkCorners { get; set; }

        public double ansiLumens { get; set; }
        public double ansiUniformity { get; set; }
        public double dpUniformity { get; set; }
        public double fullScreenContrast { get; set; }
        public double centreLumens { get; set; }
        public double centreContrast { get; set; }

        public string resolution; 
        public double compensationFactor = Processing.compensationFactor;
        public double area = Calculations.screenArea;
        public string CSVpath = Properties.Settings.Default.CSVPath;
        
        
    }
}
