using System;

namespace ICodeThereforeIAm
{
    class Animal
    {
        public string name;
        public string sound;

        public Animal()
        {
            name = "No Name";
            sound = "No Sound";
            numOfAnimals++;
        }

        public Animal(string name = "No Name")
        {
            this.name = name;
            this.sound = "No Sound";
            numOfAnimals++;
        }

        public Animal(string name = "No Name", string sound = "No Sound")
        {
            this.name = name;
            this.sound = sound;
            numOfAnimals++;
        }

        public void MakeSound()
        {
            Console.WriteLine("{0} says {1}",
                name, sound);
        }

        static int numOfAnimals = 0;

        public static int GetNumAnimals()
        {
            return numOfAnimals;
        }
    }
    class Animals
    {
        private string name;
        private string sound;
        public const string SHELTER = "Jessica's Home for Animals"; //can not be changed.
        public readonly int idNum; //can only be changed at run time
        public void MakeSound()
        {
            Console.WriteLine("{0} says {1}",
                name, sound);
        }
        public Animals()
        : this("No Name", "No Sound") { }
        public Animals(string name)
        : this(name, "No Sound") { }
        public Animals(string name, string sound)
        {
            SetName(name);
            Sound = sound;
            NumOfAnimal = 1;
            Random rnd = new Random();
            idNum = rnd.Next(1, 211345797);
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }
        public string Sound
        {
            get { return sound; }
            set
            {
                if(value.Length > 10)
                {
                    sound = "No Sound";
                    Console.WriteLine("Sound is too long");
                }
                sound = value;
            }
        }
        public string Owner { get; set; } = "No Owner";
        public static int numOfAnimal = 0;
        public static int NumOfAnimal
        {
            get { return numOfAnimal; }
            set { numOfAnimal += value; }
        }
    }
}
