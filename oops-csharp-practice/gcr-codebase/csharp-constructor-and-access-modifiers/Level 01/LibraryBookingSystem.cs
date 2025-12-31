using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Constructor
{
    internal class LibraryBookingSystem
    {
        // Creating a Book Class To Create an Entry
        public class Book
        {
            string title;
            string author;
            double price;
            int availability;
           // Creating a Constructor of The Class
            public Book(string title, string author, double price, int availability)
            {
                this.title = title;
                this.author = author;
                this.price = price;
                this.availability = availability;
            }
            // Method to Borrow Books if Available
            public void BorrowBook()
            {
                if (availability == 0) {
                    Console.WriteLine("Books Out of Stock ");
                }
                else
                {
                    availability = availability - 1;
                    Console.WriteLine(" Book Borrowed");
                }
                Console.WriteLine( " No of Books Still left "+ availability);
            }
        }
        // Method to make the Object of Book Class ans Run it's Method
        public void LibraryMangemnet()
        {
            Book book = new Book("Iron Man", "Stan-Lee", 2365, 5);
            book.BorrowBook();
        }
    }
}
