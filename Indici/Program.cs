using System;

namespace Indici
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] myArray = { "primo", "secondo", "terzo", "quarto" };

            // two Index instances
            Index first = 0;
            Index last = ^1;    // using the index from end operator, for the last array position

            string anStr = myArray[first];
            Console.WriteLine(anStr);

            anStr = myArray[last];
            Console.WriteLine(anStr);

            // reducing the code using the index from end operator directly

            string anotherStr = myArray[^1];
            Console.WriteLine(anotherStr);

            anotherStr = myArray[^3];
            Console.WriteLine(anotherStr);
        }
    }
}