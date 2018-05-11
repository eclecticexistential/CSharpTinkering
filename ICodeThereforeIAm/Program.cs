using System;

namespace ICodeThereforeIAm
{
    class Program
    {
        static void Main(string[] args)
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

            Console.WriteLine("Goodbye!");
        }
        public static void RollAgain()
        {
            Random rnd = new Random();
            int chance = rnd.Next(0, 21);
            int counter = 0;
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
                chance = rnd.Next(0, 21);
            }
            Console.WriteLine($"Congrats You Rolled a Critical after {counter} rolls!");
        }
    }
}
