using System;

namespace ModificatoreRef
{
    class MyClass
    {
        public int x = 5;
    }
    public class Program
    {
        static void Main(string[] args)
        {
            int k = 5;
            MyClass myClass = new MyClass();
            Console.WriteLine($"Before calling MyMethod ==> myClass.x = {myClass.x}, k = {k}"); // 5, 5

            MyMethod(ref myClass, ref k);
            Console.WriteLine($"After calling MyMethod ==> myClass.x = {myClass.x}, k = {k}"); // 10, 10
        }

        static void MyMethod(ref MyClass myClass, ref int k)
        {
            // nel passaggio del reference type per reference, non andiamo a cambiare l'oggetto puntato
            // myClass.x = 10;

            // nel passaggio del reference type per reference, andiamo a cambiare l'oggetto puntato
            myClass = new MyClass();
            myClass.x = 10;
            k = 10;
        }
    }
}