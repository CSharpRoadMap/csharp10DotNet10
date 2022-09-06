namespace Library {

    /*
        This class represents a User.
    */
    public class User {
        private string id;
        private string name;
        private string lastName;
        private int yearOfSubscription;
        
        public User (string id, string name, string lastName, int yearOfSubscription) {
            this.id = id;
            this.name = name;
            this.lastName = lastName;
            this.yearOfSubscription = yearOfSubscription;
        }

        public string Denomination() {
            return $"{this.name} {this.lastName}";
        }
    }

    /*
        This class represents a Book.
    */
    public class Book {
        private string id;
        private string title;
        private string author;
        private User user;

        public Book (string id, string title, string author) {
            this.id = id;
            this.title = title;
            this.author = author;
            this.user = null;
        }

        /* Method to return a custom description of a book */
        public string Description() {
            return String.Format("'{0}' by {1}", this.title, this.author);
        }

        /* Method use to loan a book to an user */
        public void LoanTo(User user) {
            if (this.user != null) {
                Console.WriteLine($"The book '{this.title}' is already loaned by {this.user.Denomination()}");
                return;
            }

            this.user = user;
            Console.WriteLine($"The book '{this.title}' has been loaned to {this.user.Denomination()}");
        }

        /* Method use to return back the book */
        public void ReturnBack() {
            Console.WriteLine($"The user {this.user.Denomination()} returned back the book {this.Description()}");
            this.user = null;
        }
    }

    /*
        This class represents a User.
    */
    public class TheLibrary {
        public static void Main(string[] args) {
            User firstUser = new User("0001", "Ernesto", "Acosta", 2022);
            Console.WriteLine($"User {firstUser.Denomination()} created.");

            User secondUser = new User("0002", "Paola", "Damiani", 2021);
            Console.WriteLine($"User {secondUser.Denomination()} created.");

            Book book = new Book("L001", "Cent'anni di solitudine", "Gabriel Garcia Marquez");
            Console.WriteLine($"Book {book.Description()} created.");

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