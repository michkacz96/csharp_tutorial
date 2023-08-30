using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp1
{
    public class Program
    {

        static void Main(string[] args)
        {
            /*
             * First steps
             */

            Console.WriteLine("Hello world!");
            Console.ForegroundColor = ConsoleColor.DarkCyan; //font
            Console.BackgroundColor = ConsoleColor.Magenta; //background
            Console.Clear();

            Console.Write("What is your name?: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Hello {name}");
        }

    }
}