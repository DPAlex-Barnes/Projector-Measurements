using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projector_Measurements
{
    class Calculations
    {
        public static double area { get; set; }

        public static double AnsiLumens(double[] WhiteData)
        {
            
            double mean = WhiteData.Average();
            double lumens = mean * area;
            return lumens;
        }     
    }
}
