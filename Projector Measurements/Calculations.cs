using System;
using System.Linq;

namespace Projector_Measurements
{
    class Calculations
    {
        public static double screenArea;

        public static void CalculateScreenSize(int width, int height, double screenWidth)
        {
            double screenHeight = (screenWidth / width) * height;
            screenArea = screenWidth * screenHeight;
        }

        public static double AnsiLumens(double[] lxData)
        {
            
            double mean = lxData.Average();
            Console.WriteLine("Lumens: " + (mean * screenArea));
            Console.WriteLine("Area = " + screenArea);
            return mean * screenArea;
            
        }

        //public static double AnsiUniformity(double[] lxData, double[] corners)
        //{
        //    double mean = lxData.Average();
        //    double lowestCorner = GetLowest(corners);
        //    try
        //    {
        //        ansiUniformity = (lowestCorner / mean) * 100;
        //    }
        //    catch (DivideByZeroException)
        //    {
        //        ansiUniformity = 0;
        //    }

        //    return ansiUniformity; 
        //}

        public static double AnsiUniformity(double[] lxData, double[] corners)
        {
            double[] allpoints = CombineNineWithCorners(lxData, corners);
            double mean = allpoints.Average();

            double biggestDeviation = BiggestDeviation(allpoints, mean);

            try {
                if (mean > biggestDeviation)
                {
                    return (biggestDeviation / mean) * 100;
                }
                else
                {
                    return (mean / biggestDeviation) * 100;
                }
            }
            catch (DivideByZeroException)
            {
                return 0;
            }
            

        }

        public static double DPUniformity (double[] lxData)
        {
            double mean = lxData.Average();
            double deviation = BiggestDeviation(lxData, mean);

            try
            {
                if(mean > deviation)
                {
                    return (deviation / mean) * 100;
                }
                else
                {
                    return(mean / deviation) * 100;
                }
                
            }

            catch (DivideByZeroException)
            {
                return 0;
            }
            
        }
        
        public static double FullScreenContrast(double[] WhiteData, double[] BlackData, double[] Ambient)
        {
            double whiteSum = WhiteData.Sum();
            double blackSum = BlackData.Sum();
            double ambientSum = Ambient.Sum();

            try
            {
                return (whiteSum - ambientSum) / (blackSum - ambientSum);
            }
            catch (DivideByZeroException)
            {
                return 0;
            }
            
        }

        public static double CenterLumens(double center)
        {
            return center * screenArea;
        }
   
        public static double CenterContrast(double centerWhite, double centerBlack, double centerDark)
        {
            return centerWhite / (centerBlack - centerDark);
        }
        
        private static double GetLowest(double[] data)
        {
            double lowest = data[0];
            foreach (var number in data)
            {
                if (number < lowest)
                {
                    lowest = number;
                }
            }

            return lowest;
        }

        private static double BiggestDeviation(double[] data, double Value)
        {
            
            double deviation;
            double biggest = Math.Abs(data[0] - Value);

            for (int i = 0; i < data.Length; i++)
            {
               deviation = Math.Abs(data[i] - Value);
                if (deviation > biggest)
                {
                    biggest = data[i];
                }
            }

            return biggest;

        }

        private static double[] CombineNineWithCorners(double[] ninePoint, double[] corners)
        {

            double[] allpoints = new double[13];

            for (int i = 0; i < 9; i++)
            {
                allpoints[i] = ninePoint[i];
            }

            for (int i = 9; i < 13; i++)
            {
                allpoints[i] = corners[i - 9];
            }
            return allpoints;
        }

    }
}
