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
            // UC-1
            // Calculate Length of a Line
            Console.WriteLine("Enter Line Points");

            //Decalre Variables
             int x1, y1, x2, y2; // line coordinates
             double Length; // float output
            
            //take Values from User
            Console.WriteLine("X1: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y1: ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("X2: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y2: ");
            y2 = Convert.ToInt32(Console.ReadLine());

            //Formula for finding length of a line 
            Length = Math.Sqrt((x2 - x1 ^ 2 + y2 - y1 ^ 2));

            //Printing Lenght of a line
            Console.WriteLine("Length of a Line is: " + Length);

            Console.ReadLine();
        }
    }
}
