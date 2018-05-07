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
            CarColor car1 = CarColor.Blue;
            PaintCar(car1);
            Console.ReadLine();
        }
        enum CarColor : byte
        {
            Orange = 1,
            Blue,
            Green,
            Purple,
            Red,
            Yellow
        }
        static void PaintCar(CarColor cc)
        {
            Console.WriteLine("The car was painted {0} with the code {1}", cc, (int)cc);
        }
    }
}
