using System;
using System.IO;

/*
1) Prelevare una stringa dal terminale.
2) Creare un test condizionale:
   - se è stato scritto "primo", visualizzare: "Hai scritto primo"
   - se è stato scritto "secondo", visualizzare: "Hai scritto secondo"
   - altrimenti, visualizzare: "Hai scritto" seguito dalla stringa

3) Usa per prima cosa uno statement if/else
4) Poi, usa lo statement switch, per fare la stessa cosa
*/
namespace Condizioni
{ 
    public class Program {
        static void Main(string[] args) {
            Console.Write("Scrivi qualcosa: ");
            string inputValue = Console.ReadLine();

            if (inputValue == "primo") {
                Console.WriteLine("Hai scritto primo");
            } else if (inputValue == "secondo") {
                Console.WriteLine("Hai scritto secondo");
            } else {
                Console.WriteLine($"Hai scritto {inputValue}");
            }

            switch (inputValue) {
                case "primo":
                    Console.WriteLine("Hai scritto primo");
                    break;
                case "secondo":
                    Console.WriteLine("Hai scritto secondo");
                    break;
                default:
                    Console.WriteLine($"Hai scritto {inputValue}");
                    break;
            }
        }
    }
}