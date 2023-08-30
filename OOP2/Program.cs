namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new Circle(5), new Rectangle(4, 5) };

            foreach(Shape s in shapes)
            {
                s.GetInfo();

                Console.WriteLine("{0} area: {1:f2}", s.Name, s.Area());
                Circle testCirc = s as Circle;
                if(testCirc == null)
                {
                    Console.WriteLine("This isn't a circle");
                }

                if(s is Circle)
                {
                    Console.WriteLine("This isn't a rectangle");
                }

                Console.WriteLine();
            }
            Console.WriteLine();

            object circ1 = new Circle(4);
            Circle circ2 = (Circle)circ1;

            Console.WriteLine("The {0} area is {1:f2}", circ2.Name, circ2.Area());
        }
    }
}