using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Dog : Animal
    {
        public string Sound2 { get; set; } = "Grr";

        public Dog(string name="No name", string sound = "No sound", string sound2 = "No sound 2") : base(name, sound)
        {
            Sound2 = sound2;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound} and {Sound2}");
        }
    }
}
