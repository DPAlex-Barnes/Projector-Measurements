using System;
using System.Collections.Generic;

namespace Projector_Measurements
{
    public static class Processing

    {
        public static double compensationFactor = Properties.Settings.Default.CompensationFactor;
        
        private static double[] referenceMultipliers = { 0.0001, 0.001, 0.01 ,0.1, 1,
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
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == null)
                {
                    throw new ArgumentNullException(data[i], "data array must not contain null value");
                }
            }
            

            double[] multipliers = GetMultipliers(data);
            double[] numbers = ExtractNumber(data);
            double[] processed = ApplyMultiplier(numbers, multipliers);

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
                    throw new ArgumentException(dataArray[i], "Unknown value Received");
                }
            }

            return converted;
        }

        private static double[] GetMultipliers(string[] data)
        {
            double[] multipliers = new double[data.Length];

            for(int i=0; i < data.Length; i++)
            {
                int index = int.Parse(data[i][data[i].Length - 1].ToString());
                Console.WriteLine("multiplier index = " + index);

                multipliers[i] = referenceMultipliers[index];
            }
            /*
            foreach (var item in data)
            {
                int index = int.Parse(item[item.Length - 1].ToString());
                //Console.WriteLine(item);
                Console.WriteLine("multiplier index = " + index);
                //Console.WriteLine(referenceMultipliers[index]);
                multipliers[Array.IndexOf(data, item)] = referenceMultipliers[index];                
            }

            */

            foreach(double item in multipliers)
            {
                Console.WriteLine("multiplier = " + item);
            }
            return multipliers;

        }

        private static double[] ApplyMultiplier(double[] data, double[] multiplier)
        {
            double[] applied = new double[data.Length];

            for (int i =0; i < applied.Length; i++)
            {
                applied[i] = (data[i] * multiplier[i]) * compensationFactor;
            }
            return applied;
        }
        #endregion

        
    }
}
