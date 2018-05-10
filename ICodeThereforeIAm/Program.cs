using System;

namespace ICodeThereforeIAm
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Animal fox = new Animal()
            {
                name = "Red",
                sound = "Raaw"
            };

            fox.name = "Red";
            fox.sound = "Raaw";

            fox.MakeSound();

            Console.WriteLine("# of Animals : {0}",
                Animal.GetNumAnimals());

            Console.WriteLine("Area of Rectangle : {0}",
                ShapeMath.GetArea("rectangle", 5, 6));
            Console.WriteLine("Area of Triangle : {0}",
                ShapeMath.GetArea("triangle", 7, 4));
            Console.WriteLine("Area of Circle : {0}",
                ShapeMath.GetArea("circle", 7, 4));

            Console.ReadLine();
        }
    }
}
