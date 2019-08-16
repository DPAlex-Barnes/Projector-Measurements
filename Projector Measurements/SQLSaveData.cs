using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Projector_Measurements
{
    public static class SQLSaveData
    {
        public static bool saveData(DataCentreClass data)
        {
            string userID = "userid";
            string password = "password";
            string server = @"UKMANNB017\SQLEXPRESS";
            string database = "Projector Optical Measurements";
            string timeout = "30";
            bool success = false;
            
            SqlConnection connection = new SqlConnection($"user id={userID}; password={password}; server={server};"
               + $"Trusted_Connection=Yes; database={database}; connection timeout={timeout}");

            try
            {
                connection.Open();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            SqlCommand mycommand = new SqlCommand();


            mycommand.Connection = connection;
            mycommand.CommandText = "INSERT INTO [Light Data]([Date],[Projector ID],[Operator ID],[Lamp ID],[Resolution], " + 
                "[ANSI Lumens],[ANSI Uniformity], [DP Uniformity], [Full Screen Contrast], [Centre Lumens], [Centre Contrast], " +
                "[White Sensor01], [White Sensor02],[White Sensor03], [White Sensor04], [White Sensor05],[White Sensor06], " +
                "[White Sensor07], [White Sensor08], [White Sensor09], [White Sensor10], [White Sensor11], [White Sensor12], " +
                "[White Sensor13], [Black Sensor01], [Black Sensor02], [Black Sensor03], [Black Sensor04], [Black Sensor05], [Black Sensor06], " +
                "[Black Sensor07],[Black Sensor08], [Black Sensor09], [Dark Sensor01], [Dark Sensor02], [Dark Sensor03], [Dark Sensor04], " +
                "[Dark Sensor05], [Dark Sensor06], [Dark Sensor07], [Dark Sensor08], [Dark Sensor09]) " +
                $"VALUES ('{data.date}', '{data.projectorID}', '{data.name}', '{data.lampType}', '{data.resolution}', {data.ansiLumens}, " + 
                $"{data.ansiUniformity}, {data.dpUniformity}, {data.fullScreenContrast}, {data.centreLumens}, {data.centreContrast}, " +
                $"{Math.Round(data.whiteNinePoint[0], 2)}, {Math.Round(data.whiteNinePoint[1], 2)}, {Math.Round(data.whiteNinePoint[2], 2)}, " +
                $"{Math.Round(data.whiteNinePoint[3], 2)}, {Math.Round(data.whiteNinePoint[4], 2)}, {Math.Round(data.whiteNinePoint[5], 2)}, " + 
                $"{Math.Round(data.whiteNinePoint[6], 2)}, {Math.Round(data.whiteNinePoint[7], 2)}, {Math.Round(data.whiteNinePoint[8], 2)}, " + 
                $"{Math.Round(data.whiteCorners[0], 2)}, {Math.Round(data.whiteCorners[1], 2)}, {Math.Round(data.whiteCorners[2], 2)}, " +
                $"{Math.Round(data.whiteCorners[3], 2)}, {Math.Round(data.blackNinePoint[0], 2)}, {Math.Round(data.blackNinePoint[1], 2)}, " +
                $"{Math.Round(data.blackNinePoint[2], 2)}, {Math.Round(data.blackNinePoint[3], 2)}, {Math.Round(data.blackNinePoint[4], 2)}, " +
                $"{Math.Round(data.blackNinePoint[5], 2)}, {Math.Round(data.blackNinePoint[6], 2)}, {Math.Round(data.blackNinePoint[7], 2)}, " +
                $"{Math.Round(data.blackNinePoint[8], 2)}, {Math.Round(data.darkNinePoint[0], 2)}, {Math.Round(data.darkNinePoint[1], 2)}, " +
                $"{Math.Round(data.darkNinePoint[2], 2)}, {Math.Round(data.darkNinePoint[3], 2)}, {Math.Round(data.darkNinePoint[4], 2)}, " +
                $"{Math.Round(data.darkNinePoint[5], 2)}, {Math.Round(data.darkNinePoint[6], 2)}, {Math.Round(data.darkNinePoint[7], 2)}, " +
                $"{Math.Round(data.darkNinePoint[8], 2)})";


            mycommand.ExecuteNonQuery();


            connection.Close();
            return success;
        }
    }
}
