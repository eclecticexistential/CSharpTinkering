using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICodeThereforeIAm
{
    class Warrior
    {
        public string Name { get; set; } = "Warrior";
        public int Health { get; set; } = 0;
        public int AttackMax { get; set; } = 0;
        public int BlockMax { get; set; } = 0;

        Random rnd = new Random();

        public Warrior(string name = "Warrior", int health = 0, int attackMax = 0, int blockMax = 0)
        {
            Name = name;
            Health = health;
            AttackMax = attackMax;
            BlockMax = blockMax;
        }
        public int Attack()
        {
            return rnd.Next(1, AttackMax);
        }
        public int Block()
        {
            return rnd.Next(1, BlockMax);
        }
    }
}
