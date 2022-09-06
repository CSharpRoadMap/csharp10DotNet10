using System;


namespace MetodiRicorsivi
{
    public class Program
    {
        static void Main(string[] args) {

            Console.Write("Enter a number bigger than zero: ");
            string aValue = Console.ReadLine();

            Console.WriteLine($"Il fattoriale di {aValue} è {Program.Fattoriale(Convert.ToInt32(aValue))}");
        }

        /*
        This method is used to calcolate the factorial of 
        a given number.
        */
        static int Fattoriale(int aNumber)
        {
            if (aNumber <= 0)
            {
                return 1;
            }
            else
            {
                return aNumber * Fattoriale(aNumber - 1);
            }
        }
    }
}