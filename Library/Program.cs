namespace Library {

    /*
        This class represents a Person.
    */
    public class Person {
        public string Name { get; set; }
        public string LastName { get; set; }

        public virtual string Denomination {
            get {
                return $"{Name} {LastName}";
            }
        }
    }

    /*
        This class represents a User.
    */
    public class User : Person {
        public string Id { get; set; }

        public int YearOfSubscription { get; set; }

        public override string Denomination {
            get {
                return $"{Id} {Name} {LastName}";
            }
        }
    }

    /*
        This class represents a Book.
    */
    public class Book {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        private User user = null;

        /* Method to return a custom description of a book */
        public string Description {
            get {
                return String.Format("'{0}' by {1}", Title, Author);
            }
        }

        /* Method use to loan a book to an user */
        public void LoanTo(User user) {
            if (this.user != null) {
                Console.WriteLine($"The book '{Title}' is already loaned by {this.user.Denomination}");
                return;
            }

            this.user = user;
            Console.WriteLine($"The book '{Title}' has been loaned to {this.user.Denomination}");
        }

        /* Method use to return back the book */
        public void ReturnBack() {
            Console.WriteLine($"The user {this.user.Denomination} returned back the book {this.Description}");
            this.user = null;
        }
    }

    /*
        This class represents a User.
    */
    public class TheLibrary {
        public static void Main(string[] args) {
            User firstUser = new User { Id = "0001", Name = "Ernesto", LastName = "Acosta", YearOfSubscription = 2022 };
            Console.WriteLine($"User {firstUser.Denomination} created.");

            User secondUser = new User { Id = "0002", Name = "Paola", LastName = "Damiani", YearOfSubscription = 2021 };
            Console.WriteLine($"User {secondUser.Denomination} created.");

            Book book = new Book{ Id = "L001", Title = "Cent'anni di solitudine", Author = "Gabriel Garcia Marquez" };
            Console.WriteLine($"Book {book.Description} created.");

            // To loan the book to the first user
            book.LoanTo(firstUser);

            // Try to loan the book to the second user
            book.LoanTo(secondUser);

            // To return back the book to the library
            book.ReturnBack();

            // Trying again to loan the book to the second user
            book.LoanTo(secondUser);
        }
    }
}