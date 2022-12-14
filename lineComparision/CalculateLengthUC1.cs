using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lineComparision
{
    public class CalculateLengthUC1

    {
        public void cal(double x1, double x2, double y1, double y2)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            double sum, length;
            sum = ((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            length = Math.Sqrt(sum);
            Console.WriteLine("length of Line - " + length);
            Console.ReadLine();
        }
        

    }
}
