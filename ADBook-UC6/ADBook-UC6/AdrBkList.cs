using System;
using System.Collections.Generic;
using System.Net;

public class AddressBookList
{
    class AddressbookList
    {
        public string Name { get; private set; }
        public string Address { get; private set; }

        public void AddressBook(string name, string address)
        {
            Name = name;
            Address = address;
        }
        public void EditInfo(string address = "")
        {

        }
        public override string ToString()
        {
            return $"{Name}\n{Address}\n";
        }
    } 
    class AddressBookCollection
    {
    class AddressBook
        Dictionary<string, AddressBook> Addressbooks = new Dictionary<string, AddressBook>();
        Dictionary<string, List<AddressBook>> index = new Dictionary<string, List<AddressBook>>();
        public static bool AddEntry(string name, string address)
        {

        }
        public static bool EditEntry(string name)
        {

        }
        public void ShowEntry(string name)
        {

        }
        public void ShowAll()
        {

        }
    }
    AddressbookList ablist = new AddressbookList();
    void ShowMenu()
    {

    }
}