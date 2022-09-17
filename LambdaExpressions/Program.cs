using System;

namespace LambdaExpressions
{
    public class Program
    {
        static void Main(string[] args)
        {
            Func<string> greeting = () => "Hello";
            Console.WriteLine(greeting());

            Func<string, string> greeting2 = (name) => $"Hello, {name}";
            Console.WriteLine(greeting2("Susanna"));

            Action greeting3 = () => Console.WriteLine("Hello");
            greeting3();

            Action<string> greeting4 = (name) => Console.WriteLine($"Hello, {name}");
            greeting4("Susanna");

            Action<int, int> ToAdd = (firstValue, secondValue) => {
                int result = firstValue + secondValue;

                Console.WriteLine($"{firstValue} + {secondValue} = {result}");
            };
            ToAdd(10, 5);
        }
    }
}