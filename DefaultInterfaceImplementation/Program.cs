using System;

namespace DefaultInterfaceImplementation
{
    public interface IMyInterface {
        void MyMethod(string value);
        string MyMethod2(string value) => value.ToUpper();
    }
    public class Program : IMyInterface
    {
        public void MyMethod(string value) => Console.WriteLine(value);
        // string MyMethod2(string value) => value.ToLower();
        static void Main(string[] args)
        {
            Program aProgram = new Program();
            aProgram.MyMethod("Hello");
            string anString = (aProgram as IMyInterface).MyMethod2("Susanna");
            Console.WriteLine(anString);

        }
    }
}