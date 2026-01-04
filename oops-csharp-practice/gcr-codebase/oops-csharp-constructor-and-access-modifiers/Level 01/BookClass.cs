using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Constructor
{
    internal class BookClass
    {
        // Writing a Book Class
        class Book {
            string title;
            string author;
            double price;
            // Writing a Parameterized Constructor to assign the values to the attributes
            public Book(string title, string author, double price)
            {
                this.title = title;
                this.author = author;
                this.price = price;
            }
            // Writing a Default Constructor for the Class
            public Book() {
                this.title = "Games Of Thrones";
                this.author = "George R.R Martin";
                this.price = 3500;
            
            }
            // Writing a Method that will display the attributes of the class
            public void Display()
            {
                Console.WriteLine("The Title of the book " + this.title);
                Console.WriteLine("The Author of the book " + this.author);
                Console.WriteLine("The Price of the book " + this.price);
            }
        }
        // Writing a Method to make the object of the above class
        public void DisplayDetail()
        {
            Book book = new Book("The Story of Fire And Rice","George R.R Martin",45000);
            book.Display();
            Book book1 = new Book();
            book1.Display();
        }
    }
}
