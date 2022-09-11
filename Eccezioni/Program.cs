using System;

namespace Eccezioni
{
    public class Program {
        static void Main(string[] args) {
            int? aNumber = 0;

            Console.Write("Type a number: ");
            string aNumberStr = Console.ReadLine();

            try {
                aNumber = Convert.ToInt32(aNumberStr);
            } catch (System.FormatException formatException) {
                Console.WriteLine($"You must type a valid number");
                aNumber = -1;
            } finally {
                Console.WriteLine($"You typed {aNumberStr}");
            }
        }
    }
}