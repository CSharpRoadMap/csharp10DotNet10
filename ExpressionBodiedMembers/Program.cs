
using System;

namespace ExpressionBodiedMembers
{
    public class Program
    {
        private static string name;

        static string Name {
            get => this.name.ToUpper();
            set => this.name = value;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Greeting("Mario"));

            Name = "Susanna";
            Console.WriteLine(Name);

        }

        /*
        static string Greeting(string name)
        {
            return $"Hello, {name}";
        }
        */

        /*
            Since the previous method is composed by a single expression, it can
            be converted in a expression-bodied member
        */
        static string Greeting(string name) => $"Hello, {name}";
    }
}