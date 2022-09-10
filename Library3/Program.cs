using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library3
{
    /* This represents the IUser interface. To be implemented. */
    public interface IUser {
        string? Id { get; set; }
        int YearOfSubscription { get; set; }
        string? Denomination { get; }
    }

    /* This object represents the Person class. */
    public class Person : IUser {
        public string? Id { get; set; }
        public int YearOfSubscription { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string Denomination {
            get {
                return $"{Id} {Name} {LastName}";
            }
        }
    }

    /* This object represents the Organization class. */
    public class Organization : IUser {
        public string? Id { get; set; }
        public int YearOfSubscription { get; set; }
        public string? SocialReason { get; set; }
        public string Denomination {
            get {
                return $"{Id} {SocialReason}";
            }
        }
    }
    /* This object represents the TheLibrary class. */
    public class TheLibrary {

        static IUser[] users;

        public static void printUsers() {
            foreach (IUser user in users) {
                Console.WriteLine(user.Denomination);
            }
        }
        public static void Main(string[] args) {
            Person aPerson = new Person { Id = "0001", Name = "Ernesto", LastName = "Acosta", YearOfSubscription = 2016 };
            Organization anOrganization = new Organization { Id = "0002", SocialReason = "Children care", YearOfSubscription = 2010 };
            users = new IUser[] { aPerson, anOrganization };

            printUsers();
        }
    }
}