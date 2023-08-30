namespace SimpleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Simple game
             */

            Random rand = new Random();
            int secretNumber = rand.Next(1, 11);
            int numberGuessed = 0;

            Console.WriteLine("Random num: ", secretNumber);

            do
            {
                Console.Write("Enter number between 1 - 10: ");
                numberGuessed = Convert.ToInt32(Console.ReadLine());

            } while (secretNumber != numberGuessed);

            Console.WriteLine("You guessed! It was {0}", secretNumber);

        }
    }
}