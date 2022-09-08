using System;

namespace Strutture
{
    public class MyClass {
        public string myString;
        public int myInteger;
    }

    public struct MyStruct {
        public string myString;
        public int myInteger;
    }
    public class Program {
        static void Main(string[] args) {
            MyClass myClass = new MyClass();
            myClass.myInteger = 1;
            myClass.myString = "Ernesto";

            MyStruct myStruct = new MyStruct();
            myStruct.myInteger = 2;
            myStruct.myString = "Paola";

            Console.WriteLine($"Prima myClass.myInteger = {myClass.myInteger}, myClass.myString = {myClass.myString}");
            Console.WriteLine($"Prima myStruct.myInteger = {myStruct.myInteger}, myStruct.myString = {myStruct.myString}");

            ClassMethod(myClass, myStruct, 3, "Chunita");

            Console.WriteLine($"Dopo myClass.myInteger = {myClass.myInteger}, myClass.myString = {myClass.myString}");
            Console.WriteLine($"Dopo myStruct.myInteger = {myStruct.myInteger}, myStruct.myString = {myStruct.myString}");
        }
        static void ClassMethod(MyClass myClass, MyStruct myStruct, int p_int, string p_string) {
            myClass.myInteger = p_int;
            myStruct.myInteger = p_int;

            myClass.myString = p_string;
            myStruct.myString = p_string;
        }
    }
}