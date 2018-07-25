using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projector_Measurements
{
    class Processing

    {
        public static double compensationFactor { get; set; }
        
        private static double[] multipliers = { 0.0001, 0.001, 0.01 ,0.1, 1,
                10, 100, 10000, 100000, 1000000 };

        public static string[] ConcatArrays(string[]NinePoint, string[]corners)
        {
            List<string> fullArray = new List<string>();
            fullArray.AddRange(NinePoint);
            fullArray.AddRange(corners);
            string[] sArray = fullArray.ToArray();
            
            return fullArray.ToArray();
        }

        #region Gets a string array of data, extracts numbers and applies multiplier from data

        public static double[] ProcessData(string[] data)
        {
            double multiplier = GetMultiplier(data);
            double[] numbers = ExtractNumber(data);
            double[] processed = ApplyMultiplier(numbers, multiplier);

            return processed;
        }

        private static double[] ExtractNumber(string[] dataArray)
        {
            double[] converted = new double[dataArray.Length];

            for (int i = 0; i < dataArray.Length; i++)
            {
                string s = dataArray[i];
                if (s.StartsWith("+") || s.StartsWith("=") || s.StartsWith("-"))
                {
                    dataArray[i] = s.Substring(1, 4);
                    dataArray[i] = dataArray[i].Trim();
                    converted[i] = double.Parse(dataArray[i]);

                }
                else
                {
                    throw new ArgumentException(dataArray[i], "Unknown value Recieved");
                }
            }

            return converted;
        }

        private static double GetMultiplier(string[] data)
        {
            string FirstString = data[0];
            int index = int.Parse(FirstString[FirstString.Length - 1].ToString());
            
            return multipliers[index];
        }

        private static double[] ApplyMultiplier(double[] data, double multiplier)
        {
            double[] applied = new double[data.Length];

            for (int i =0; i < applied.Length; i++)
            {
                applied[i] = (data[i] * multiplier) * compensationFactor;
            }
            return applied;
        }
        #endregion

        
    }
}
