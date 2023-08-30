using System.Runtime.InteropServices;

namespace OOP
{
    class Program
    {
        struct Rectangle
        {
            public double length;
            public double width;

            public Rectangle(double length = 1, double width = 1)
            {
                this.length = length;
                this.width = width;
            }

            public double Area()
            {
                return length * width;
            }
        }
        static void Main(string[] args)
        {
            /*
            //structs
            Rectangle rect1;
            rect1.length = 200;
            rect1.width = 50;

            Console.WriteLine("Area of rect1: {0}", rect1.Area());

            Rectangle rect2 = new Rectangle(100, 40);
            rect2 = rect1;
            rect1.length = 33;
            Console.WriteLine("rect2.length: {0}", rect2.length);

            //classes
            Animal fox = new Animal()
            {
                name = "Red",
                sound = "Raaw"
            };

            Console.WriteLine("# of animals: {0}", Animal.GetNumberOfAnimals());

            Console.WriteLine("Area of rectangle: {0}", ShapeMath.GetArea("rectangle", 5, 6));

            int? randNum = null;
            if(randNum == null)
            {
                Console.WriteLine("randNum is null");
            }

            if (!randNum.HasValue)
            {
                Console.WriteLine("randNum is null");
            }
            */
            /*
            Animal cat = new Animal();
            cat.SetName("Whiskers");
            cat.Sound = "Meow";

            Console.WriteLine("The cat is named {0} and says {1}", cat.GetName(), cat.Sound);
            cat.Owner = "Derek";
            Console.WriteLine("{0} owner is {1}", cat.GetName(), cat.Owner);
            Console.WriteLine("{0} shelter id is {1}", cat.GetName(), cat.idNum);
            Console.WriteLine("Number of animals: {0}", Animal.NumberOfAnimals);
            */

            Animal whiskers = new Animal()
            {
                Name = "Whiskers",
                Sound = "Meow"
            };

            Dog grover = new Dog()
            {
                Name = "Grover",
                Sound = "Woof",
                Sound2 = "Grrrrrr"
            };

            grover.Sound = "Woooof";

            whiskers.MakeSound();
            grover.MakeSound();
            whiskers.SetAnimalIDInfo(1254, "Sally Smith");
            grover.SetAnimalIDInfo(1255, "Paul Brown");
            whiskers.GetAnimalIDInfo();
            Animal.AnimalHealth getHealth = new Animal.AnimalHealth();
            Console.WriteLine("Is my animal healthy: {0}", getHealth.HealthyWeight(11, 46));

            Animal monkey = new Animal()
            {
                Name = "Happy",
                Sound = "Eeeeeeee"
            };

            Animal spot = new Dog()
            {
                Name = "Spot",
                Sound = "Wooooofff",
                Sound2 = "Geeerrrrr"
            };

            spot.MakeSound();
        }
    }
}