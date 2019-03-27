using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Razer_Exercise.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearPublished { get; set; }


        public Book(int id, string title, string author, int year)
        {
            BookId = id;
            Title = title;
            Author = author;
            YearPublished = year;
        }
    }
}