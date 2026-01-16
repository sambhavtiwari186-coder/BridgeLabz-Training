using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_2.Address_Book_System
{
       class AddressBook
    {
        public Contact[] Contacts;
        public int count;
        public AddressBook()
        {
            Contacts = new Contact[10];
            count = 0;
        }
    }
}
