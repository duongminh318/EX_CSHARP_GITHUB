using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lirary_Manager
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int PublishedYear { get; set; }

        public Book(string title, string author, string isbn, int publicationYear)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            PublishedYear = publicationYear;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}, ISBN: {ISBN}, Publication Year: {PublishedYear}";
        }
    }
    
    
}
