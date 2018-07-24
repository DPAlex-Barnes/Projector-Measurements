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

        public static double Lumens(double[] WhiteData)
        {
            double mean = WhiteData.Average();
            int lumens = Convert.ToInt32(mean * area);
            return lumens;
        }     
    }
}
