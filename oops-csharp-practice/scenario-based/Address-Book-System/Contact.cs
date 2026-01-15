using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_2.Address_Book_System
{
    public  class Contact
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Address { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string PhoneNumber { get; private set;  }
        public string Zip {  get; private set; }
        public string Email {  get; private set; }
        public Contact(string firstName, string lastName, string address, string city, string state, string phoneNumber, string zip, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            PhoneNumber = phoneNumber;
            Zip = zip;
            Email = email;
        }
    }
}
