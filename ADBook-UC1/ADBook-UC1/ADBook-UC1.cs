namespace ADBook_UC1
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
        static void Main(string[] args)
        {
           Console.WriteLine("*****Enter the details of Contact to create a Address Book*****");
           Contact contact = new Contact();
            
            var FirstName = "firstname";
            Console.WriteLine(FirstName);
            
            var LastName = "lastname";
            Console.WriteLine(LastName);

            var Address = "address";
            Console.WriteLine(Address);

            var City = "city";
            Console.WriteLine(City);

            var State = "state";
            Console.WriteLine(State);

            var Zip = "zipcode";
            Console.WriteLine(Zip);

            var PhNo = "phonenumber";            
            Console.WriteLine(PhNo);
            
            var Mail = "email id";
            Console.WriteLine(Mail);

        }
    }
}
