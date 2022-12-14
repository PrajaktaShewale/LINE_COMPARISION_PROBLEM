using System;
namespace lineComparision
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool flag=true;
            while(flag)
            {
                Console.WriteLine("Line Comparision Problem Statments ");
                Console.WriteLine("1.CalculateLength\n2.Check Equlity Of Two Lines\n3.Compare Two Lines");
                int check=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter start and end point of 1 st line ");
                double x1 = Convert.ToDouble(Console.ReadLine());
                double y1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter start and end point of 2 nd line ");
                double x2 = Convert.ToDouble(Console.ReadLine());
                double y2 = Convert.ToDouble(Console.ReadLine());
                switch (check)
                {
                    case 1:                       
                            CalculateLengthUC1 uc1 = new CalculateLengthUC1();                           
                            uc1.cal(x1, y1, x2, y2);                        
                        break;
                    case 2:
                        EquilityOfTwoLinesUC2 uc2 = new EquilityOfTwoLinesUC2();
                         Console.WriteLine("To check Both lines are Equals or no using equals method");
                         uc2.Equility(x1,y1,x2,y2);
                        break;
                    case 3:
                        CompareTwoLinesUC3 uc3 = new CompareTwoLinesUC3();
                        uc3.CompareLines(x1, y1, x2, y2);
                        break; 
                    default:
                        flag=false;
                        break;
                }
            }
        }
    }
}