using System;

namespace ModificatoreOut
{
    class MyClass
    {
        public int x = 5;
    }
    public class Program
    {
        static void Main(string[] args)
        {
            int k;
            MyClass myClass;
            MyMethod(out myClass, out k);
            Console.WriteLine($"myClass.x = {myClass.x}, k = {k}"); // 10, 10
        }

        static void MyMethod(out MyClass myClass, out int k)
        {
            myClass = new MyClass();
            myClass.x = 10;
            k = 10;
        }
    }
}