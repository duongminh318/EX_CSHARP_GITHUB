using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lirary_Manager
{
    public class LibraryService
    {
        private Library _library;

        public LibraryService(Library library)
        {
            _library = library;
        }

        // Thêm sách vào thư viện
        public void AddBook(Book book)
        {
            _library.Books.Add(book);
        }

        // Xóa sách khỏi thư viện theo ISBN
        public void RemoveBook(string isbn)
        {
            var book = _library.Books.FirstOrDefault(b => b.ISBN == isbn);
            if (book != null)
            {
                _library.Books.Remove(book);
                Console.WriteLine($"Book with ISBN {isbn} removed.");
            }
            else
            {
                Console.WriteLine($"Book with ISBN {isbn} not found.");
            }
        }

        // Tìm sách theo tiêu đề
        public Book FindBookByTitle(string title)
        {
            return _library.Books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }

        // Tìm sách theo tên tác giả
        public List<Book> FindBooksByAuthor(string authorName)
        {
            return _library.Books.Where(b => b.Author.Name.Equals(authorName, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        // In danh sách sách theo thứ tự năm xuất bản
        public void PrintBooksSortedByYear()
        {
            var sortedBooks = _library.Books.OrderBy(b => b.PublishedYear).ToList();
            Console.WriteLine("Books sorted by Published Year:");
            foreach (var book in sortedBooks)
            {
                Console.WriteLine(book);
            }
        }
    }
}
