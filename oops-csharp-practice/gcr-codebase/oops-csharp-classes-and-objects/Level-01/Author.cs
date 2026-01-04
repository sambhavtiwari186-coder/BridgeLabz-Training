using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Classes_And_Objects
{
    internal class Author
    {
        class Books
        {
            string title;
            string author;
            double price;

            public Books(string title, string author, double price)
            {
                this.title = title;
                this.author = author;
                this.price = price;
            }
            public void display()
            {
                Console.WriteLine("The Title of The Book is " + this.title);
                Console.WriteLine("The Author of The Book is " + this.author);
                Console.WriteLine("The Price of The Book is " + this.price);
            }
        }
        public void DisplayDetails()
        {
            Books obj = new Books("Alchemist","Robert Frost",3000);
            obj.display();
        }
    }
}
