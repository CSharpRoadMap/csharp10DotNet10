using System;

namespace TypeInference
{
    public class Program
    {
        public static void Main(string[] args)
        {
            float myFloat = 12.5f;
            double myDouble = 130.78;
            decimal myDecimal = 1500.456m;
            double mySecondDouble = 5e-7;
            var myString = "type inference";
            var myBoolean = false;

            Console.WriteLine($"myFloat = {myFloat}, myDouble = {myDouble}, myDecimal = {myDecimal}, mySecondDouble = {mySecondDouble}, myString = {myString}, myBoolean = {myBoolean}");
        }
    }
}