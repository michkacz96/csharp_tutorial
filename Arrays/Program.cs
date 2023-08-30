namespace Arrays
{
    class Program
    {
        /*
         * Functions
         */
        static void PrintArray(int[] intArray, string message)
        {
            foreach (int k in intArray)
            {
                Console.WriteLine("{0} : {1}", message, k);
            }
        }

        static void Main(string[] args)
        {
            /*
             * Arrays
             */

            int[] favNums = new int[3];

            favNums[0] = 13;
            Console.WriteLine("favNum 0: {0}", favNums[0]);

            string[] customers = { "Bob", "Sally", "Sue" };

            var employees = new[] { "Mike", "Paul", "Rick" };
            object[] randomArray = { "Paul", 45, 1.23 };
            Console.WriteLine("randomArray 0: {0}", randomArray[0].GetType());
            Console.WriteLine("Array size: {0}", randomArray.Length);

            for(int i = 0; i < randomArray.Length; i++)
            {
                Console.WriteLine("Index: {0} | Value: {1}", i, randomArray[i]);
            }

            Console.WriteLine("\n----------------------------------\n");

            string[,] customerNames = new string[3, 2] { { "Bob", "Smith" }, { "Sally", "Smith" }, { "Mike", "Doe" } };

            Console.WriteLine("Multri dimentional value: {0}", customerNames[0, 0]);
            Console.WriteLine("Multri dimentional value: {0}", customerNames.GetValue(1, 0));

            for(int i = 0; i<customerNames.GetLength(0); i++)
            {
                for(int j = 0; j < customerNames.GetLength(1); j++)
                {
                    Console.Write("{0} ", customerNames[i, j]);
                }
                Console.WriteLine();
            }

            int[] ranomNums = { 1, 5, 9, 8, 10, 2 };
            PrintArray(ranomNums, "Foreach");
            Array.Sort(ranomNums);
            Array.Reverse(ranomNums);
            Console.WriteLine("1 at index: {0}", Array.IndexOf(ranomNums, 1));

            ranomNums.SetValue(0, 1);

            int[] srcArray = { 1, 2, 3 };
            int[] descArray = new int[2];
            int startInd = 0;
            int length = 2;

            //Array anotherArray = Array.CreateInstance(typeof(int), srcArray);
            Array.Copy(srcArray, startInd, descArray, 0, length);

            PrintArray(descArray, "copy");
            Array anotherArray = Array.CreateInstance(typeof(int), 10);
            srcArray.CopyTo(anotherArray, 5);

            foreach(int m in anotherArray)
            {
                Console.WriteLine("copyTo: {0}", m);
            }

            int[] numArray = { 1, 11, 22 };
            //Console.WriteLine("> 10: {0}", Array.Find(numArray, >10));
        }
    }
}