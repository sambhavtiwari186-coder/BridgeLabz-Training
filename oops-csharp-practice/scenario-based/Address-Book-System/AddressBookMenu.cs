using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_2.Address_Book_System
{
     class AddressBookMenu
    {
        private IAddressBook utility;

        public AddressBookMenu()
        {
            AddressBook book = new AddressBook(10);
            utility = new AddressBookUtility(book);
        }

        public void Start()
        {
            int choice;

            do
            {
                Console.WriteLine("\n===== Address Book Menu =====");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Display Contacts");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddContactMenu();
                        break;

                    case 2:
                        utility.DisplayContacts();
                        break;

                    case 3:
                        Console.WriteLine("Exiting Address Book...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice ❌");
                        break;
                }
            }
            while (choice != 3);
        }

        private void AddContactMenu()
        {
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Address: ");
            string address = Console.ReadLine();

            Console.Write("City: ");
            string city = Console.ReadLine();

            Console.Write("State: ");
            string state = Console.ReadLine();

            Console.Write("Phone Number: ");
            string phone = Console.ReadLine();

            Console.Write("Zip Code: ");
            string zip = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Contact contact = new Contact(
                firstName, lastName, address,
                city, state, phone, zip, email
            );

            utility.AddContact(contact);
        }
    }
}
