using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lineComparision
{
    public class EquilityOfTwoLinesUC2
    {
        public void Equility(double x1, double y1, double x2, double y2)
        {
            double length1, length2;
            if (x1 == x2)//start point equal
            {
                Console.WriteLine("Both Lines are Equal - "+ y1.Equals(y2));//check end points are equal
            }
            else
            {
                length1 = x1 - x2;
                length2 = y1 - y2;
                Console.WriteLine("Both Lines are Equal - "+length1.Equals(length2));
                Console.ReadLine();
            }
        }
    }

}
