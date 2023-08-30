namespace NumericalVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Numerical variables
             */
             
                bool canIVote = true;

                Console.WriteLine("Smallest Integer: {0}", int.MinValue);
                Console.WriteLine("Biggest Integer: {0}", int.MaxValue);
                Console.WriteLine("Smallest Unsigned Integer: {0}", uint.MinValue);
                Console.WriteLine("Biggest Unsigned Integer: {0}\n", uint.MaxValue);

                Console.WriteLine("Smallest Long: {0}", long.MinValue);
                Console.WriteLine("Biggest Long: {0}", long.MaxValue);
                Console.WriteLine("Smallest Unsigned Long: {0}", ulong.MinValue);
                Console.WriteLine("Biggest Unsigned Long: {0}\n", ulong.MaxValue);

                Console.WriteLine("Smallest Double: {0}", double.MinValue);
                Console.WriteLine("Biggest Double: {0}\n", double.MaxValue);

                Console.WriteLine("Smallest Decimal: {0}", decimal.MinValue);
                Console.WriteLine("Biggest Decimal: {0}\n", decimal.MaxValue);

                Console.WriteLine("Smallest Float: {0}", float.MinValue);
                Console.WriteLine("Biggest Float: {0}", float.MaxValue);

                decimal decPiVal = 3.1415926535897932384M;
                decimal decBigNum = 3.000000000000000011M;

                double douPiVal = 3.1415926535897932384;
                double douBigNum = 3.000000000000000011;

                float fPiVal = 3.1415926535897932384F;
                float fBigNum = 3.000000000000000011F;

                Console.WriteLine("DEC: Pi + bigNumber = {0}", decPiVal + decBigNum);
                Console.WriteLine("DOU: Pi + bigNumber = {0}", douPiVal + douBigNum);
                Console.WriteLine("FLT: Pi + bigNumber = {0}\n", fPiVal + fBigNum);

                Console.WriteLine("Currency: {0:c}", 23.2344342);
                Console.WriteLine("Pad with zeros: {0:d4}", 23);
                Console.WriteLine("3 decimals: {0:f3}", 23.2344342);
                Console.WriteLine("Commas: {0:n4}\n\n", 232344342);
        }
    }
}