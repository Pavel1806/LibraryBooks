using LibraryBooks.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryBooks.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public int YearOfPublication { get; set; }
        public int NumberOfPages { get; set; }
        public string Genre { get; set; }

        public Book(string author, string title, int yearOfPublication, int numberOfPages, string genre)
        {
            Author = author;
            Title = title;
            YearOfPublication = yearOfPublication;
            NumberOfPages = numberOfPages;
            Genre = genre;
        }

        public Book()
        {
            
        }

    }
}
