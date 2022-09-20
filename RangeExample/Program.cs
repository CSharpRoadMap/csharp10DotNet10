using System;

namespace RangeExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] myArray = { "primo", "secondo", "terzo", "quarto" };

            string[] anStrRange = myArray[..2];

            foreach (string item in anStrRange)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------------");

            string[] anotherStrRange = myArray[1..];

            foreach (string item in anotherStrRange)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------------");

            string[] anotherStringRange = myArray[1..3];

            foreach (string item in anotherStringRange)
            {
                Console.WriteLine(item);
            }
        }
    }
}