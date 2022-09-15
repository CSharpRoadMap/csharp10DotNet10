using System;

namespace ParametriValueTypeEReference
{
    public class Program
    {
        class MyClass
        {
            public int x = 5;
        }
        static void Main(string[] args)
        {
            int x = 5;
            Console.WriteLine($"x value before MyMethod call: {x}");
            MyMethod(x);
            Console.WriteLine($"x value after MyMethod call: {x}");

            MyClass myClass = new MyClass();
            Console.WriteLine($"myClass.x value before MyMethod1 call: {myClass.x}");
            MyMethod1(myClass);
            Console.WriteLine($"myClass.x value after MyMethod1 call: {myClass.x}");
        }

        static void MyMethod(int y)
        {
            y = 10;
        }
        static void MyMethod1(MyClass myClass)
        {
            // myClass.x = 10;

            // new modification
            myClass = new MyClass();
            myClass.x = 10;
        }
    }
}