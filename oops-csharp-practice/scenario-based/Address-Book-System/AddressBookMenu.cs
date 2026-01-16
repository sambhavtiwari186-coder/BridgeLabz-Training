using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_2.Address_Book_System
{
     class AddressBookMenu
    {
        private AddressBook addressBook;
        private AddressBookUtility addressBookUtility;

        public AddressBookMenu()
        {
            addressBook = new AddressBook();
            addressBookUtility = new AddressBookUtility(addressBook); 
        }

        public void ShowMenu()
        {
            int choice;

            do
            {
                Console.WriteLine("\n----- Address Book Menu -----");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Edit Contact");
                Console.WriteLine("3. Display Contacts");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddContactFromConsole();
                        break;
                    case 2:
                        EditContactFromConsole();
                        break;
                    case 3:
                        addressBookUtility.DisplayContacts();
                        break;
                    case 4:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

            } while (choice != 4);
        }

        private void AddContactFromConsole()
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

            Console.Write("Zip: ");
            string zip = Console.ReadLine();

            Console.Write("Phone: ");
            string phone = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Contact contact = new Contact(
                firstName, lastName, address, city, state, zip, phone, email
            );

            addressBookUtility.AddContact(contact);
        }

        private void EditContactFromConsole()
        {
            Console.Write("Enter First Name to Edit: ");
            string name = Console.ReadLine();

            addressBookUtility.EditContact(name);
        }
    }
}
