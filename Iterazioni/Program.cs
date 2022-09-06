using System;

namespace Iterazioni
{
    public class Program {
        static void Main(string[] args) {
        
            int rowsNumber = 0;

            while (true) {
                Console.Write("Numero di righe ('no' per uscire): ");
                string rowsNumberStr = Console.ReadLine();

                if (rowsNumberStr == "no") {
                    Console.WriteLine("Arrivederci!");
                    break;
                } 

                rowsNumber = Convert.ToInt32(rowsNumberStr);

                for (int i = 1; i <= rowsNumber; i++) {
                    for (int j = 1; j <= i; j++) {
                        Console.Write("* ");
                    }
                    Console.Write("\n");
                }
            }
        }
    }
}