using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thomsonreuters.formulae
{
    public class Area
    {
        public static double AreaOfCircle(double r)
        {
            double result = 3.14 * r * r;
            return result;

        }

        public double AreaofRectangle(double l, double w)
        {
            return (l * w);
        }

        public double AreaOfTriangle(double bs, double he)
        {
            return (0.5 * bs * he);
        }

        public static string MyName()
        {
            return "Pratik Sankhe";
        }
        
        public void Quit() // Method to Close browser void does nt return anything
        {

        }
    }
}
