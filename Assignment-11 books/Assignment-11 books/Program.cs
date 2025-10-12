using System;
using System.Collections.Generic;

namespace LibrarySystem
{
    // A simple class to represent a book in the library
    class Book
    {
        // Fields (Book details)
        public string Title;
        public string Author;
        public int Year;
        public string Genre;

        // Constructor – runs when a new book is created
        public Book(string title, string author, int year, string genre)
        {
            Title = title;
            Author = author;
            Year = year;
            Genre = genre;
        }

        // Method to show book details
        public void ShowInfo()
        {
            Console.WriteLine($"\"{Title}\" by {Author} ({Year}) - Genre: {Genre}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Library System ===");

            // Create book objects using the constructor
            Book b1 = new Book("To Kill a Mockingbird", "Harper Lee", 1960, "Classic Fiction");
            Book b2 = new Book("The Hobbit", "J.R.R. Tolkien", 1937, "Fantasy");
            Book b3 = new Book("Atomic Habits", "James Clear", 2018, "Self-Help");

            // Add books to a list (like a small library)
            List<Book> library = new List<Book> { b1, b2, b3 };

            Console.WriteLine("\nBooks in Library:\n");

            // Display all books
            foreach (Book book in library)
            {
                book.ShowInfo();
            }

            Console.WriteLine("\nLibrary system demo finished.");
        }
    }
}