using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lirary_Manager
{
    public class LibraryManager
    {
        private LibraryService _libraryService;

        public LibraryManager(LibraryService libraryService)
        {
            _libraryService = libraryService;
        }

        public void Start()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nLibrary Management System");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Remove Book");
                Console.WriteLine("3. Find Book by Title");
                Console.WriteLine("4. Find Books by Author");
                Console.WriteLine("5. Print Books Sorted by Year");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddBook();
                        break;
                    case "2":
                        RemoveBook();
                        break;
                    case "3":
                        FindBookByTitle();
                        break;
                    case "4":
                        FindBooksByAuthor();
                        break;
                    case "5":
                        PrintBooksSortedByYear();
                        break;
                    case "6":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }

        private void AddBook()
        {
            Console.Write("Enter book title: ");
            string title = Console.ReadLine();

            Console.Write("Enter author name: ");
            string authorName = Console.ReadLine();

            Console.Write("Enter author date of birth (YYYY-MM-DD): ");
            DateTime dob = DateTime.Parse(Console.ReadLine());

            Author author = new Author(authorName, dob);

            Console.Write("Enter book ISBN: ");
            string isbn = Console.ReadLine();

            Console.Write("Enter published year: ");
            int publishedYear = int.Parse(Console.ReadLine());

            Book book = new Book(title, author, isbn, publishedYear);
            _libraryService.AddBook(book);

            Console.WriteLine("Book added successfully.");
        }

        private void RemoveBook()
        {
            Console.Write("Enter book ISBN to remove: ");
            string isbn = Console.ReadLine();

            _libraryService.RemoveBook(isbn);
        }

        private void FindBookByTitle()
        {
            Console.Write("Enter book title to find: ");
            string title = Console.ReadLine();

            var book = _libraryService.FindBookByTitle(title);
            if (book != null)
            {
                Console.WriteLine($"Found Book: {book}");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        private void FindBooksByAuthor()
        {
            Console.Write("Enter author name to find books: ");
            string authorName = Console.ReadLine();

            var books = _libraryService.FindBooksByAuthor(authorName);
            if (books.Count > 0)
            {
                Console.WriteLine($"Books by {authorName}:");
                foreach (var book in books)
                {
                    Console.WriteLine(book);
                }
            }
            else
            {
                Console.WriteLine("No books found for this author.");
            }
        }

        private void PrintBooksSortedByYear()
        {
            _libraryService.PrintBooksSortedByYear();
        }
    }
}
