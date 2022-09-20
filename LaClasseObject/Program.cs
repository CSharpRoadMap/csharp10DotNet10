using System;

namespace LaClasseObject
{
    public class Book
    {
        public string Title { get; set;}
        public string Author { get; set;}

        public override string ToString()
        {
            return $"{base.ToString()}: {Title} from {Author}";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine<string, string>(Title, Author);
        }

        public override bool Equals(object obj)
        {
            return (this.ToString() == obj.ToString());
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Book myBook1 = new Book {Title = "L'isola misteriosa", Author = "Jules Verne"};
            Book myBook2 = new Book {Title = "Neuromante", Author = "William Gibson"};

            myBook2 = myBook1;  // both instances are pointing to the same object now

            Console.WriteLine(myBook1.GetHashCode());
            Console.WriteLine(myBook2.GetHashCode());

            // Console.WriteLine(myBook1.Equals(myBook2));

            // invoking the static form of the Equals() method
            Console.WriteLine(Object.Equals(myBook1, myBook2));
            Console.WriteLine(myBook1.Author);
            Console.WriteLine(myBook2.Author);
        }
    }
}