using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_2.Address_Book_System
{
     interface IAddressBook
    {
        void AddContact(Contact contact);
        void DisplayContacts();
        void EditContact(string firstName);
    }
}
