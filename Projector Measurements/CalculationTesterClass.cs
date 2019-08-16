using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projector_Measurements
{
    class CalculationTesterClass
    {
        


        public static void AlexUniformityCalcs()
        {
            double[] alanLuxData = { 5869, 6835, 5890, 5922, 6709, 5911, 5239, 6090, 5376 };
            double[] alanCornerData = { 4966, 4578, 4441, 4315 };
            double[] alexLuxData = { 5869, 6846, 5890, 5922, 6720, 5901, 5250, 6090, 5365 };
            double[] alexCornerData = { 4966, 4557, 4452, 4305 };

            Console.WriteLine("Alex App Calculations: ");
            double alanUniformity = Calculations.AnsiUniformity(alanLuxData, alanCornerData);
            double alexUniformity = Calculations.AnsiUniformity(alexLuxData, alexCornerData);

            Console.WriteLine("Alan data: " + alanUniformity);
            Console.WriteLine("Alex data: " + alexUniformity);
            Console.WriteLine();
        }

       public static void AlanUniformityCalcs()
        {
            double[] alanLuxData = { 5869, 6835, 5890, 5922, 6709, 5911, 5239, 6090, 5376 };
            double[] alanCornerData = { 4966, 4578, 4441, 4315 };
            double[] alexLuxData = { 5869, 6846, 5890, 5922, 6720, 5901, 5250, 6090, 5365 };
            double[] alexCornerData = { 4966, 4557, 4452, 4305 };

            Console.WriteLine("Alan App Calculations: ");
            double alanUniformity = AlanUniformity(alanLuxData, alanCornerData);
            double alexUniformity = AlanUniformity(alexLuxData, alexCornerData);

            Console.WriteLine("Alan data: " + alanUniformity);
            Console.WriteLine("Alex Data: " + alexUniformity);

            Console.WriteLine();

        }

        private static double AlanUniformity(double[] alanlux, double[] alancorners)
        {
            double[] allpoints = CombineNineWithCorners(alanlux, alancorners);
            double mean = allpoints.Average();

            int difference = 0;
            double value = 0;
            
            int test;
            double result;

            for (int i = 0; i < 13; i++)
            {
                if (allpoints[i] > mean)
                {
                    test = (int)Math.Floor(allpoints[i]) - (int)Math.Floor(mean);
                }
                else
                {
                    test = (int)Math.Floor(mean) % (int)Math.Floor(allpoints[i]);
                }
                Console.WriteLine(i + " " + test);
                
                if (test > difference)
                {
                    difference = test;
                    value = allpoints[i];
                }                
                
            }

            Console.WriteLine();

            if (value > mean)
            {
                result = mean / value;
            }
            else
            {
                result = value / mean;
            }
            
            return result * 100;
        }

        private static double[] CombineNineWithCorners(double[] ninePoint, double[] corners)
        {
            // create 13 point array
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
