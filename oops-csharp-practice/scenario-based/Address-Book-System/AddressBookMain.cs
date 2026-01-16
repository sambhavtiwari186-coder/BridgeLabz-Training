using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_2.Address_Book_System
{
    public class AddressBookMain
    {
        public static void Main()
        {

            Console.WriteLine("Welcome to Address Book Program");

            // Only responsibility of Main
            AddressBookMenu menu = new AddressBookMenu();
            menu.ShowMenu();
        }
    }
}

       