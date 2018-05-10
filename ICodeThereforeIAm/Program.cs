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

            Console.ReadLine();
        }
    }
}
