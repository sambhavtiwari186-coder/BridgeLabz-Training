using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_2.Address_Book_System
{
    class AddressBookUtility : IAddressBook
    {
        private AddressBook addressBook;
        public AddressBookUtility(AddressBook addressBook)
        {
            this.addressBook = addressBook;
        }

        public void AddContact(Contact contact)
        {
            if (addressBook.count >= addressBook.Contacts.Length)
            {
                Console.WriteLine("Address Book is Full");
                return;
            }

            addressBook.Contacts[addressBook.count] = contact;
            addressBook.count++;

            Console.WriteLine("Contact added successfully");
        }

        public void EditContact(string firstName)
        {
            int index = -1;

            for (int i = 0; i < addressBook.count; i++)
            {
                if (addressBook.Contacts[i].FirstName
                    .Equals(firstName, StringComparison.OrdinalIgnoreCase))
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
            {
                Console.WriteLine("Contact not found");
                return;
            }

            Contact contact = addressBook.Contacts[index];

            Console.WriteLine("1. Address");
            Console.WriteLine("2. City");
            Console.WriteLine("3. State");
            Console.WriteLine("4. Zip");
            Console.WriteLine("5. Phone");
            Console.WriteLine("6. Email");

            Console.Write("Enter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter new value: ");
            string value = Console.ReadLine();

            switch (choice)
            {
                case 1: contact.Address = value; break;
                case 2: contact.City = value; break;
                case 3: contact.State = value; break;
                case 4: contact.Zip = value; break;
                case 5: contact.PhoneNumber = value; break;
                case 6: contact.Email = value; break;
                default:
                    Console.WriteLine("Invalid choice");
                    return;
            }

            Console.WriteLine("Contact updated successfully");
        }

        public void DisplayContacts()
        {
            if (addressBook.count == 0)
            {
                Console.WriteLine("No contacts found");
                return;
            }

            Console.WriteLine("\n--- Address Book Contacts ---");

            for (int i = 0; i < addressBook.count; i++)
            {
                addressBook.Contacts[i].DisplayDetails();
            }
        }
    }
}
