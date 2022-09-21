using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // UC-2
            // Comparing two lines and finding they are equal or not

            Console.WriteLine("Enter Line Points");

            //Decalre Variables
            int x1, y1, x2, y2; // line 1 coordinates
            int x3, y3, x4, y4; // Line 2 coordinates
            double Length1, Length2; // float output

            // difference: here taking two lines
            // Line 1
            Console.WriteLine("Enter Line 1 ");
            Console.WriteLine("X1: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y1: ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("X2: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y2: ");
            y2 = Convert.ToInt32(Console.ReadLine());

            // Line 2
            Console.WriteLine("Enter Line 2 ");
            Console.WriteLine("X1: ");
            x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y1: ");
            y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("X2: ");
            x4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y2: ");
            y4 = Convert.ToInt32(Console.ReadLine());

            //Formula for finding length of a line 
            Length1 = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            Length2 = Math.Sqrt((x4 - x3) ^ 2 + (y4 - y3) ^ 2);
            
            //Now comparing both Length1 & Length2
            if (Length1 == Length2)
            {
                Console.WriteLine("Two Lines are Eqaul");
            }
            else
            {
                Console.WriteLine("Two Lines are not Eqaul");
            }

            Console.ReadLine();
        }
    }
}
