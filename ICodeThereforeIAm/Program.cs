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
            string op = "WOrds yo!";
            for (int i = 0; i < op.Length; i++)
            {
                Console.WriteLine("Hello {0} : {1}!", i, op[i]);
            }
            Console.ReadLine();
        }
    }
}
