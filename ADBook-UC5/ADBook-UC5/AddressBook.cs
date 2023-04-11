using System;
using System.Net;
using System.Collections.Generic;

class AddressBook
{
    private List<Person> addressBookList = new List<Person>();
    public List<Person> AddressBookList
    {
        get { return addressBookList; }
        set { this.addressBookList = value; }
    }


    public AddressBook()
    {
        AddressBookList = new List<Person>();
    }

    // Create instance of Person-class and call AddPersonToList-method
    public void CreateUser()
    {
        Console.WriteLine("Enter firstName:");
        var firstName = Console.ReadLine();

        Console.WriteLine("Enter lastName:");
        var lastName = Console.ReadLine();

        Console.WriteLine("Enter address:");
        var address = Console.ReadLine();
        
        Console.WriteLine("Enter city:");
        var city = Console.ReadLine();
        
        Console.WriteLine("Enter state:");
        var state = Console.ReadLine();
        
        Console.WriteLine("Enter zip code:");
        var zip = Console.ReadLine();
        
        Console.WriteLine("Enter phone number:");
        var phno = Console.ReadLine();
        
        Console.WriteLine("Enter email id:");
        var mailid = Console.ReadLine();


        Person person = new Person(firstName, lastName, address, city, state, zip, phno, mailid);
        AddPersonToList(person);
    }

    // Add new person to AdressBookList
    private void AddPersonToList(Person person) => AddressBookList.Add(person);

    //Remove user from list where first and last name match
    public void RemovePersonFromList()
    {
        Console.WriteLine("Enter firstName of the user you want to remove");
        var firstName = Console.ReadLine();

        Console.WriteLine("Enter lastname of the user you want to remove");
        var lastName = Console.ReadLine();

        AddressBookList.RemoveAll(item => item.FirstName == firstName && item.LastName == lastName);
    }

    //Show all Persons in AdressBookList
    public void ShowAllPersonsInList()
    {
        foreach (var person in AddressBookList)
        {
            Console.WriteLine("FirstName: {0}, LastName: {1}, Adress: {2}", person.FirstName, person.LastName, person.Adress);
        }
    }

    public void UpdateUserInformation()
    {
        Console.WriteLine("Which information do you want to update?");
        Console.WriteLine("#1: Firstname, #2: Lastname, 3# Adress");
        var userOption = Console.ReadLine();

        Console.WriteLine("Enter firstname on existing user to be updated");
        var oldFirstName = Console.ReadLine();
        UpdateUserFunction(userOption, oldFirstName);
    }

    private void UpdateUserFunction(string userOption, string oldFirstName)
    {
        var personsWithMatchingFirstName = AddressBookList.Where(person => person.FirstName == oldFirstName);
        string newValue;

        if (userOption == "1")
        {
            Console.WriteLine("Enter a new first Name");
            newValue = Console.ReadLine();

            foreach (var person in personsWithMatchingFirstName)
            {
                person.FirstName = newValue;
            }
        }
        else if (userOption == "2")
        {
            Console.WriteLine("Enter a new last name");
            newValue = Console.ReadLine();

            foreach (var person in personsWithMatchingFirstName)
            {
                person.LastName = newValue;
            }
        }
        else if (userOption == "3")
        {
            Console.WriteLine("Enter a new adress");
            newValue = Console.ReadLine();

            foreach (var person in personsWithMatchingFirstName)
            {
                person.Address = newValue;
            }
        }
    }
}