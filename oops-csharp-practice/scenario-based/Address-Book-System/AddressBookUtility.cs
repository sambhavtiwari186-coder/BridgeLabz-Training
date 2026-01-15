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
                Console.WriteLine("Address Book is Full ");
                return;
            }

            addressBook.Contacts[addressBook.count] = contact;
            addressBook.count++;

            Console.WriteLine("Contact added successfully ");
        }

        public void DisplayContacts()
        {
            if (addressBook.count == 0)
            {
                Console.WriteLine("No contacts found.");
                return;
            }

            Console.WriteLine("\n--- Address Book Contacts ---");

            for (int i = 0; i < addressBook.count; i++)
            {
                Contact c = addressBook.Contacts[i];

                Console.WriteLine($"Name    : {c.FirstName} {c.LastName}");
                Console.WriteLine($"Address : {c.Address}");
                Console.WriteLine($"City    : {c.City}");
                Console.WriteLine($"State   : {c.State}");
                Console.WriteLine($"Phone   : {c.PhoneNumber}");
                Console.WriteLine($"Zip     : {c.Zip}");
                Console.WriteLine($"Email   : {c.Email}");
                Console.WriteLine("--------------------------------");
            }
        }
    }
}
