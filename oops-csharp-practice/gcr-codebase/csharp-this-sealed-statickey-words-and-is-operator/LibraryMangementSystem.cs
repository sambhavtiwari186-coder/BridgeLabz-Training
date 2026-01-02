using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.keywords_and_instances_in_oops
{
    internal class LibraryMangementSystem
    {
        // Creating a library class 
        class Library
        {
            public static string libraryName = "Education Hub";
           public  string author;
            public string title;
           public readonly int isbn;// Making isbn a readonly variable
            // Creating a Constructor to intialize the fields
            public Library(string author, string title,int isbn)
            {
                this.author = author;  
                this.title = title;
                this.isbn = isbn;
            }
            // Creating a static Method DisplayLibraryName 
            public static void DisplayLibraryName()
            {
                Console.WriteLine("The Name of the Library is " + Library.libraryName);
            }
            // Creating a Book Details Methods to show the content of the class 
            public  void BookDeatils()
            {
                Console.WriteLine("The author of the book is " + this.author);
                Console.WriteLine("The title of the book is " + this.title);
                Console.WriteLine("The ISBN Number is " + this.isbn);
            }
        }
        // Creating a Display Method to make the object  of the class
         public  void Display()
        {
            Library library = new Library("Robert Frost", "A DayDream", 3490);
            Library.DisplayLibraryName();
            if(library is Library)
            {
                library.BookDeatils();
            }
        }
    }
}
