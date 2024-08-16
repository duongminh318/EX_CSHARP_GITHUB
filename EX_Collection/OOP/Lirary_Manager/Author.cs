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
    }
}
