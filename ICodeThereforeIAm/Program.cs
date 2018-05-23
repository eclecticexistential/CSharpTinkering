using System;

namespace ICodeThereforeIAm
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            Console.WriteLine("1 for Dice Game or 2 for Gladiator or 3 for Shapes");
            try
            {
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    DiceGame();
                }
                else if (choice == "2")
                {
                    Gladiator();
                }
                else if (choice == "3")
                {
                    Shapes();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("That was not a number.");
            }

            Console.WriteLine("Goodbye!");
        }

        public static void DiceGame()
        {
            RollAgain();
            Console.WriteLine("Roll again?");
            string ans = Console.ReadLine();

            while (ans.ToLower() == "yes")
            {
                RollAgain();
                Console.WriteLine("Roll again?");
                ans = Console.ReadLine();
            };

            Console.WriteLine("Play Gladiator?");
            string nav = Console.ReadLine();
            if(nav.ToLower() == "yes")
            {
                Gladiator();
            }
            else Console.WriteLine("Goodbye!");
        }

        public static void RollAgain()
        {
            Random rnd = new Random();
            int chance = rnd.Next(1, 21);
            int counter = 1;
            while (chance != 20)
            {

                if (chance <= 10)
                {
                    counter++;
                }
                else if (chance < 20)
                {
                    counter++;
                }
                chance = rnd.Next(1, 21);
            }
            Console.WriteLine($"Congrats You Rolled a Critical after {counter} rolls!");
        }
        public static void Gladiator()
        {
            Console.WriteLine("Welcome to Gladiator! \n What is your contender's name?");
            string gladName = Console.ReadLine();
            Console.WriteLine($"What is {gladName}'s health?");
            int health = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"What is {gladName}'s power?");
            int power = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"What is {gladName}'s toughness?");
            int toughness = Convert.ToInt32(Console.ReadLine());
            Warrior maximus = new Warrior(gladName, health, power, toughness);
            Warrior bob = new Warrior("Bob", 1000, 120, 40);
            Battle.StartFight(maximus, bob);
            Console.WriteLine("Want to play again?");
            string ans = Console.ReadLine();
            if (ans.ToLower() == "yes")
            {
                Gladiator();
            }
            else Menu();
        }
        public static void Shapes()
        {
            Console.WriteLine("Circle radius?");
            int circRad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Rectangle length?");
            int recLen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Rectangle width?");
            int recWid = Convert.ToInt32(Console.ReadLine());
            Shape[] shapes = { new Circle(circRad), new Rectangle(recLen, recWid) };

            foreach(Shape s in shapes)
            {
                s.GetInfo();
                Console.WriteLine("{0} Area : {1:f2}", s.Name, s.Area());
                Circle testCirc = s as Circle;
                if(testCirc == null)
                {
                    Console.WriteLine("This is not a circle");
                }
                if(s is Circle)
                {
                    Console.WriteLine("This isn't a rectangle");
                    Console.WriteLine();
                    object circ1 = new Circle(4);
                    Circle circ2 = (Circle)circ1;

                    Console.WriteLine("The {0} Area is {1:f2}", circ2.Name, circ2.Area());
                }
            }

            Console.WriteLine("Want to run again?");
            string ans = Console.ReadLine();
            if (ans.ToLower() == "yes")
            {
                Shapes();
            }
            else Menu();
        }
    }
}
