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
            string[] myArgs = Environment.GetCommandLineArgs();
            Console.WriteLine(string.Join(", ", myArgs));
            SayHello();
            Console.ReadLine();
        }
        private static void SayHello()
        {
            string name = "";
            Console.Write("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Greetings {0}!", name);
        }
    }
}
