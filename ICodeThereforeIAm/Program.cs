using System;

namespace ICodeThereforeIAm
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals cat = new Animals();
            cat.SetName("Whiskers");
            cat.Sound = "Meow";
            Console.WriteLine("The cat is named {0} and says {1}", cat.GetName(), cat.Sound);
            cat.Owner = "Brutus";
            Console.WriteLine("{0} owner is {1}", cat.GetName(), cat.Owner);
            Console.WriteLine("{0} shelter id is {1}", cat.GetName(), cat.idNum);
            Animals bear = new Animals("George", "Rrrrr");
            Console.WriteLine("# of animals : {0}", Animals.NumOfAnimal);

            GetLessons();
            Console.ReadLine();
        }

        public static void GetLessons()
        {
            Animal fox = new Animal()
            {
                name = "Red",
                sound = "Raaw",
            };

            fox.MakeSound();

            Animal tiger = new Animal();
            tiger.name = "Strips";
            tiger.sound = "Roar";

            tiger.MakeSound();

            Console.WriteLine("# of Animals : {0}",
                Animal.GetNumAnimals());

            Console.WriteLine("Area of Rectangle : {0}",
                ShapeMath.GetArea("rectangle", 5, 6));
            Console.WriteLine("Area of Triangle : {0}",
                ShapeMath.GetArea("triangle", 7, 4));
            Console.WriteLine("Area of Circle : {0}",
                ShapeMath.GetArea("circle", 7, 4));
        }
    }
}
