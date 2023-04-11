using System;
using System.Net;
using System.Collections.Generic;

namespace ADBook_UC5
{
    internal class MainProgram
    {
        static void Main(string[] args)
        {
            bool ProgramIsRunning = true;
            AddressBook ab = StartProgram();

            Console.WriteLine("*********** Address Book **********");

            while (ProgramIsRunning)
            {
                // Print user options
                PrintUserOptions();
                var userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        ab.CreateUser();
                        break;
                    case "2":
                        ab.UpdateUserInformation();
                        break;
                    case "3":
                        ab.RemovePersonFromList();
                        break;
                    case "4":
                        ab.ShowAllPersonsInList();
                        break;
                    case "x":
                        ProgramIsRunning = false;
                        break;
                }
            }
        }

        private static void PrintUserOptions()
        {
            Console.WriteLine("Choose one of the following options: ");
            Console.WriteLine("1 Create new user");
            Console.WriteLine("2 Edit user information");
            Console.WriteLine("3 Delete existing user");
            Console.WriteLine("4 Show all users in adressBook");
        }

        private static AddressBook StartProgram()
        {
            AddressBook ab = new AddressBook();

            return ab;
        }

    }
}