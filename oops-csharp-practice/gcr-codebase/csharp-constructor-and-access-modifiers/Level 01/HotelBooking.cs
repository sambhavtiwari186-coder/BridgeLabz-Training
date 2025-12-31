using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Constructor
{
    internal class HotelBooking
    {
        public class Booking
        {
            string guestName;
            string roomType;
            int nights;
            // Creating a Default Constructor for this Class
            public Booking() {
                guestName = "Raman";
                roomType = "3BHK";
                nights = 2;

            }
            // Creating a Parameterized Constructor of the Class 
            public Booking(string guestName,string roomType,int nights)
            {
                this.guestName = guestName;
                this.roomType = roomType;
                this.nights = nights;
            }
            // Creating a Copy Constructor of the Class
            public Booking(Booking book)
            {
                this.guestName = book.guestName;
                this.roomType = book.roomType;
                this.nights = book.nights;
            }
            public void display()
            {
                Console.WriteLine("The Name of Guest is " +  guestName);
                Console.WriteLine("Room Type of the Guest is " + roomType);
                Console.WriteLine("No of Nights Guest will stay is " + nights+ " nights");
            }
        }
        // The Method to Display The Entry of The Hotel
        public void DisplayEntry()
        {
            Booking book = new Booking();
            book.display();
            Booking book1 = new Booking("Aditey", "1BHK", 2);
            book1.display();
            Booking book2 = new Booking(book1);
            book2.display();
        }
    }
}
