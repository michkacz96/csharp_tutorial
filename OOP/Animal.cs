using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Animal
    {
        public static int numberOfAnimals = 0;
        private string name;
        protected string sound;
        public const string SHELTER = "Derek's home for animals";
        public readonly int idNum;

        protected AnimalIdInfo animalIDInfo = new AnimalIdInfo();

        /*
        public Animal()
        {
            numberOfAnimals++;
            name = "No name";
            sound = "No sound";
        }
        public Animal(string name = "No name")
        {
            numberOfAnimals++;
            name = name;
            sound = "No sound";
        }

        public Animal(string name, string sound)
        {
            numberOfAnimals++;
            name = name;
            sound = sound;
        }
        */
        public void SetAnimalIDInfo(int idnum, string owner)
        {
            animalIDInfo.IDNumber = idnum;
            animalIDInfo.Owner = owner;
        }

        public void GetAnimalIDInfo()
        {
            Console.WriteLine($"{Name} has the ID of {animalIDInfo.IDNumber} and is owned by {animalIDInfo.Owner}");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound}");
        }
        public Animal() : this("No name", "No sound") { }
        public Animal(string name) : this(name, "No sound") { }
        public Animal(string name, string sound)
        {
            Name = name;
            sound = sound;
        }
        /*
        public Animal(string name, string sound)
        {
            SetName(name);
            Sound = sound;
            NumberOfAnimals = 1;
            Random rnd = new Random();
            idNum = rnd.Next(1, 214743640);
        }
        */
        /*
        public void MakeSound()
        {
            Console.WriteLine("{0} says {1}", name, sound);
        }
        */

        public static int GetNumberOfAnimals()
        {
            return numberOfAnimals;
        }
        /*
        public void SetName(string name)
        {
            if (!name.Any(char.IsDigit))
            {
                this.name = name;
            }
            else
            {
                this.name = "No name";
                Console.WriteLine("Name can't contain numbers");
            }
        }
        public string GetName()
        {
            return name;
        }
        */
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Any(char.IsDigit))
                {
                    name = "No name";
                    Console.WriteLine("Name can't contain numbers");
                }
                else
                {
                    name = value;
                }
            }
        }
        public string Sound
        {
            get { return sound; }
            set
            {
                if(value.Length > 10)
                {
                    sound = "No sound";
                    Console.WriteLine("Sound is too long");
                }
                else
                {
                    sound = value;
                }
            }
        }

        /*
        public string Owner { get; set; } = "No owner";

        public static int NumberOfAnimals
        {
            get { return numberOfAnimals;  }
            set { numberOfAnimals += value; }
        }
        */

        public class AnimalHealth
        {
            public bool HealthyWeight(double height, double weight)
            {
                double calc = height / weight;
                if ((calc >= .18) && (calc <= .27))
                {
                    return true;
                }
                else return false;
            }
        }
    }
}
