using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace ADBook_UC2
{
    internal class Program
    {
        public class Contact
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Zip { get; set; }
            public string PhNo { get; set; }
            public string Mail { get; set; }
        }
        private static void AddContact()
        {
            Contact contact = new Contact();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("*****To Add a Contact to Address Book*****");
            
            Contact contact = new Contact();

            Console.WriteLine("Enter First Name: ");
            contact.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name: ");
            contact.LastName = Console.ReadLine();

            Console.WriteLine("Enter Address: ");
            contact.Address = Console.ReadLine();

            Console.WriteLine("Enter City: ");
            contact.City = Console.ReadLine();

            Console.WriteLine("Enter State: ");
            contact.State = Console.ReadLine();

            Console.WriteLine("Enter Zip Code: ");
            contact.Zip = Console.ReadLine();

            Console.WriteLine("Enter Phone Number: ");
            contact.PhNo = Console.ReadLine();

            Console.WriteLine("Enter Email Id: ");
            contact.Mail = Console.ReadLine();

        }
    }
}
