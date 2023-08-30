using System.Reflection;

namespace Functions
{
    class Program
    {
        private static void SayHello()
        {
            string name = "";
            Console.Write("What is your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);
        }

        static double GetSum(double x = 1, double y = 1)
        {
            return x + y;
        }

        static void DoubleIt(int x, out int solution)
        {
            solution = x * 2;
        }
        //pass by reference
        static void Swap(ref int x, ref int y)
        {
            int tmp = x;
            x = y;
            y = tmp;
        }
        //Passing unknown number of parameters
        static double GetSumMore(params double[] nums)
        {
            double sum = 0;
            foreach(double x in nums)
            {
                sum += x;
            }
            return sum;
        }
        static void PrintInfo(string name, int zipcode)
        {
            Console.WriteLine("{0} lives in the zip code {1}", name, zipcode);
        }
        //Method overloading
        static double GetSum2(double x = 1, double y = 1)
        {
            return x + y;
        }
        static double GetSum2(string x = "1", string y = "1")
        {
            double dx = Convert.ToDouble(x);
            double dy = Convert.ToDouble(y);
            return dx + dy;
        }
        static void Main(string[] args)
        {
            double x = 5;
            double y = 4;

            Console.WriteLine("5 + 4 = {0}", GetSum(x, y));

            //------------------//
            int solution;
            DoubleIt(15, out solution);
            Console.WriteLine("15 * 2 = {0}", solution);

            //pass by reference
            int num1 = 10;
            int num2 = 20;
            Console.WriteLine("Before swap num1: {0}, num2: {1}", num1, num2);
            Swap(ref num1, ref num2);
            Console.WriteLine("After swap num1: {0}, num2: {1}", num1, num2);

            // Passing unknown number of parameters
            Console.WriteLine("1+2+3+4+5 = {0}", GetSumMore(1, 2, 3, 4, 5));
            PrintInfo(zipcode: 210370, name: "Stefan");

            //Method overloading
            Console.WriteLine("5.0 + 4.0 = {0}", GetSum2(5.0, 4.5));
            Console.WriteLine("5.0 + 4.0 = {0}", GetSum2("5.0", "4.5"));
        }
    }
}