namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Strings
             */
        
                string randString = "This is a string";

                Console.WriteLine("String Length: {0}", randString.Length);
                Console.WriteLine("String contains IS: {0}", randString.Contains("is"));
                Console.WriteLine("Index of IS: {0}", randString.IndexOf("is"));
                Console.WriteLine("Remove String: {0}", randString.Remove(10, 6));
                Console.WriteLine("Insert String: {0}", randString.Insert(10, "short "));
                Console.WriteLine("Replace STRING: {0}", randString.Replace("string", "sentence"));
                Console.WriteLine("Compare A to B: {0}", string.Compare("A", "B", StringComparison.OrdinalIgnoreCase));
                Console.WriteLine("A = a: {0}", string.Equals("A", "a"));
                Console.WriteLine("A = a: {0}", string.Equals("A", "a", StringComparison.OrdinalIgnoreCase));
                Console.WriteLine("Pad left: {0}", randString.PadLeft(20, '.'));
                Console.WriteLine("Pad left: {0}", randString.PadRight(20, '_'));
                Console.WriteLine("Trim: {0}", randString.Trim());
                Console.WriteLine("Uppercase: {0}", randString.ToUpper());
                Console.WriteLine("Lowercase: {0}", randString.ToLower());

                string newString = string.Format("{0} saw a {1} {2} in the {3}", "Paul", "rabbit", "eating", "field");
                Console.Write(newString + "\n");
                Console.WriteLine(@"Exacly what I typed\n
                                    sdfsdfsdf");
        }
    }
}