using System;

namespace TuplesInAction
{
    public class Program
    {
        static void Main(string[] args)
        {
            // unnamed tupe declaration
            (int, int, int) myColor = TheColor("ambra");

            Console.WriteLine(myColor.Item1);
            Console.WriteLine(myColor.Item2);
            Console.WriteLine(myColor.Item3);

            // or
            var (red, green, blue) = TheColor("ambra");

            Console.WriteLine(red);
            Console.WriteLine(green);
            Console.WriteLine(blue);

            // or named tuple declaration
            (int red, int green, int blue) myColor2 = TheColor("ambra");

            Console.WriteLine(myColor2.red);
            Console.WriteLine(myColor2.green);
            Console.WriteLine(myColor2.blue);
        }

        /*
            Returns a tuple regarding the RGB representation
            of a color.
        */
        static (int, int, int) TheColor(string name)
        {
            if (name == "ambra")
            {
                return (255, 191, 0);
            } else
            {
                return (-1, -1, -1);
            }
        }
    }
}