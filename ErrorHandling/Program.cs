namespace ErrorHandling
{
    class Program
    {
        /**
         * Functions
         */
        private static double DoDevision(double x, double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }
            return x / y;
        }

        static void Main(string[] args)
        {
            /**
            * Error handling
            */

            double num1 = 5;
            double num2 = 0;

            try
            {
                Console.WriteLine("5 / 0 = {0}", DoDevision(num1, num2));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("you cannot devide by 0");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error cooured");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.WriteLine("Cleaning up");
            }
        }
    }
}