using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICodeThereforeIAm
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 5;
            double num2 = 0;

            try
            {
                Console.WriteLine("5 / 0 = {0}", DoDivision(num1, num2));
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine( "You can't divide by zero.");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }

        static double DoDivision(double x, double y)
        {
            if(y == 0 || x == 0)
            {
                throw new DivideByZeroException();
            }
            return x / y;
        }
    }
}
