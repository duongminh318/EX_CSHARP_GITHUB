using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lirary_Manager
{
    public class Author
    {
        public string Name { get; set; } 
        public DateTime DateOfBirth { get; set; }
        public List<Book> Books { get; set; }  // Danh sách các sách mà tác giả đã viết

        // Constructor để khởi tạo một đối tượng Author
        public Author(string name, DateTime dateOfBirth)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            Books = new List<Book>();  // Khởi tạo danh sách sách rỗng
        }

        // Phương thức để thêm sách vào danh sách sách của tác giả
        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        // Phương thức để hiển thị thông tin tác giả
        public override string ToString()
        {
            return $"{Name} (Born: {DateOfBirth.ToShortDateString()})";
        }
    }
}
