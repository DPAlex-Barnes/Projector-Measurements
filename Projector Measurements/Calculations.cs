using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projector_Measurements
{
    class Calculations
    {
        public static double Lumens(double[] reading, double area)
        {
            double mean = reading.Average();
            int lumens = Convert.ToInt32(mean * area);
            return lumens;
        }

        
    }
}
