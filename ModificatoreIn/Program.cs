using System;

namespace ModificatoreIn
{
    class MyClass
    {
        public int x = 5;
    }
    public class Program
    {
        static void Main(string[] args)
        {
            int m = 5;
            MyClass mc = new MyClass();
            Console.WriteLine($"Before calling MyMethod ==> mc.x = {mc.x}, m = {m}");

            MyMethod(mc, m);
            Console.WriteLine($"After calling MyMethod ==> mc.x = {mc.x}, m = {m}");
        }

        static void MyMethod(in MyClass y, in int k)
        {
            //myClass = new MyClass();    // ERROR!!
            //k = 10; // ERROR!!
            y.x = 10;
        }
    }
}