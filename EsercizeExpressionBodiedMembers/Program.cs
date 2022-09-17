using System;

namespace EsercizeExpressionBodiedMembers
{
    public class Program
    {
        private string name;

        public string Name {
            get => this.name.ToUpper();
            set => this.name = value;
        }

        public Program(string aName) => this.name = aName;

        static void Main(string[] args)
        {
            Program aProgram = new Program("Ernesto");
            Console.WriteLine(aProgram.Name);
        }
    }
}