using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_2.Address_Book_System
{
    public  class Contact
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Contact(string firstName, string lastName, string address,
                       string city, string state, string zip,
                       string phoneNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            Zip = zip;
            PhoneNumber = phoneNumber;
            Email = email;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Name    : " + FirstName + " " + LastName);
            Console.WriteLine("Address : " + Address);
            Console.WriteLine("City    : " + City);
            Console.WriteLine("State   : " + State);
            Console.WriteLine("Zip     : " + Zip);
            Console.WriteLine("Phone   : " + PhoneNumber);
            Console.WriteLine("Email   : " + Email);
            Console.WriteLine("--------------------------------");
        }
    }
}
