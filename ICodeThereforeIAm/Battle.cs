using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICodeThereforeIAm
{
    class Battle
    {
        public static void StartFight(Warrior warrior1, Warrior warrior2)
        {
            while (true)
            {
                if(GetAttackResult(warrior1, warrior2) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
                if (GetAttackResult(warrior2, warrior1) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
        }
        public static string GetAttackResult(Warrior warriorA, Warrior warriorB)
        {
            int warriorAAttackAmt = warriorA.Attack();
            int warriorBBlockAmt = warriorB.Block();
            int damage2WarriorB = warriorAAttackAmt - warriorBBlockAmt;
            if (damage2WarriorB > 0)
            {
                warriorB.Health = warriorB.Health - damage2WarriorB;
            }
            else damage2WarriorB = 0;
            Console.WriteLine("{0} attacks {1} and deals {2} damage",
                warriorA.Name, warriorB.Name, damage2WarriorB);
            Console.WriteLine("{0} has {1} health \n", warriorB.Name, warriorB.Health);
            if (warriorB.Health <= 0)
            {
                Console.WriteLine("{0} has died and {1} is victorious \n", warriorB.Name, warriorA.Name);
                return "Game Over";
            }
            else return "Next Round!";
        }
    }
}
