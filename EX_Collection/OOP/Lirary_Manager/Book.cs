using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lirary_Manager
{
    public class Book
    {
        public string Title { get; set; }  // Tiêu đề sách
        public Author Author { get; set; }  // Tác giả của sách
        public string ISBN { get; set; }  // Mã ISBN của sách
        public int PublishedYear { get; set; }  // Năm xuất bản

        // Constructor để khởi tạo một đối tượng Book
        public Book(string title, Author author, string isbn, int publishedYear)
        {
            Title = title;
            Title = title;
            Author = author;
            ISBN = isbn;
            PublishedYear = publishedYear;

            // Thêm cuốn sách này vào danh sách sách của tác giả
            author.AddBook(this);
        }

        // Phương thức để hiển thị thông tin sách
        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author.Name}, ISBN: {ISBN}, Published Year: {PublishedYear}";
        }
    }


}
