using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Constructor
{
    internal class BookLibrarySystem
    {
        // Base Class
        public class Book { 
            // Access Modifiers
            public string ISBN;           // Accessible everywhere
            protected string title;       // Accessible in derived class
            private string author;        // Accessible only within Book class

            // Constructor
            public Book(string isbn, string title, string author)
            {
                this.ISBN = isbn;
                this.title = title;
                this.author = author;
            }

            // Setter for author
            public void SetAuthor(string author)
            {
                this.author = author;
            }

            // Getter for author
            public string GetAuthor()
            {
                return author;
            }

            // Display book details
            public void DisplayBook()
            {
                Console.WriteLine("ISBN   : " + ISBN);
                Console.WriteLine("Title  : " + title);
                Console.WriteLine("Author : " + author);
            }
        }

        // Derived Class
        internal class EBook : Book
        {
            private double fileSize; // in MB

            public EBook(string isbn, string title, string author, double fileSize)
                : base(isbn, title, author)
            {
                this.fileSize = fileSize;
            }

            // Accessing public and protected members
            public void DisplayEBook()
            {
                Console.WriteLine("E-Book Details");
                Console.WriteLine("ISBN      : " + ISBN);   // public access
                Console.WriteLine("Title     : " + title);  // protected access
                Console.WriteLine("File Size : " + fileSize + " MB");
                Console.WriteLine("Author    : " + GetAuthor());
            }
        }

        // Display Class
      
            static void Display()
            {
                Book book1 = new Book("978-0132350884", "Clean Code", "Robert C. Martin");
                book1.DisplayBook();

                Console.WriteLine();

                // Modify author using setter
                book1.SetAuthor("Uncle Bob");
                Console.WriteLine("Updated Author: " + book1.GetAuthor());

                Console.WriteLine();

                EBook ebook = new EBook("978-0201616224", "The Pragmatic Programmer", "Andrew Hunt", 5.6);
                ebook.DisplayEBook();
            }
        }
    }


