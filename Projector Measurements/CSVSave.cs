using System;
using System.IO;

namespace Projector_Measurements
{
    public static class CSVSave
    {
 
        public static void SaveData(DataCentreClass importdata)
        {

            string currentYear = DateTime.Now.Year.ToString();
            string currentMonth = DateTime.Now.ToString("MMM");
            string data = $"{DateTime.Now.ToShortDateString()},{importdata.name},{importdata.projectorID},{importdata.lampType},{importdata.resolution},{importdata.ansiLumens.ToString("#")},{importdata.ansiUniformity.ToString("#00")},{importdata.dpUniformity.ToString("#00")},{importdata.fullScreenContrast.ToString("#")},{importdata.centreLumens.ToString("#")},{importdata.centreContrast.ToString("#")},{Environment.NewLine}";
            string extraData = $"{DateTime.Now.ToShortDateString()},{importdata.name},{importdata.projectorID},{importdata.lampType},{importdata.whiteNinePoint[0]},{importdata.whiteNinePoint[1]},{importdata.whiteNinePoint[2]},{importdata.whiteNinePoint[3]},{importdata.whiteNinePoint[4]},{importdata.whiteNinePoint[5]},{importdata.whiteNinePoint[6]},{importdata.whiteNinePoint[7]},{importdata.whiteNinePoint[8]},{importdata.whiteCorners[0]},{importdata.whiteCorners[1]},{importdata.whiteCorners[2]},{importdata.whiteCorners[3]},{importdata.blackNinePoint[0]},{importdata.blackNinePoint[1]},{importdata.blackNinePoint[2]},{importdata.blackNinePoint[3]},{importdata.blackNinePoint[4]},{importdata.blackNinePoint[5]},{importdata.blackNinePoint[6]},{importdata.blackNinePoint[7]},{importdata.blackNinePoint[8]},{importdata.darkNinePoint[0]},{importdata.darkNinePoint[1]},{importdata.darkNinePoint[2]},{importdata.darkNinePoint[3]},{importdata.darkNinePoint[4]},{importdata.darkNinePoint[5]},{importdata.darkNinePoint[6]},{importdata.darkNinePoint[7]},{importdata.darkNinePoint[8]},{Environment.NewLine}";

            string directory = importdata.CSVpath + $@"\{currentYear}\{currentMonth}";
            Directory.CreateDirectory(directory);
            Console.WriteLine(directory);
            string LumensDataPath = directory + @"\LumensData.csv";
            string ExtraDataPath = directory + @"\ExtraData.csv";

            
                Console.WriteLine("data" + data);
            
            
            
            if (!File.Exists(LumensDataPath))
            {
                

                string DefaultData = "Date,Name,Projector Serial Number,LampType,Resolution,ANSI Lumens,ANSI Uniformity,DP Uniformity,Full Screen Contrast,Centre Lumens,Centre Contrast,\n";

                File.WriteAllText(LumensDataPath, DefaultData);
            }

            File.AppendAllText(LumensDataPath, data);
            

            if (!File.Exists(ExtraDataPath))
            {
                string DefaultExtra = "Date,Name,Projector Serial Number,Lamp Type,WhiteSensor01,WhiteSensor02,WhiteSensor03,WhiteSensor04,WhiteSensor05,WhiteSensor06,WhiteSensor07,WhiteSensor08,WhiteSensor09,WhiteSensor10(TL),WhiteSensor11(TR),WhiteSensor12(BL),WhiteSensor13(BR),BlackSensor01,BlackSensor02,BlackSensor03,BlackSensor04,BlackSensor05,BlackSensor06,BlackSensor07,BlackSensor08,BlackSensor09,DarkSensor01,DarkSensor02,DarkSensor03,DarkSensor04,DarkSensor05,DarkSensor06,DarkSensor07,DarkSensor08,DarkSensor09," + Environment.NewLine;
                File.WriteAllText(ExtraDataPath,DefaultExtra);
            }

            File.AppendAllText(ExtraDataPath, extraData);
        }
    }
}
