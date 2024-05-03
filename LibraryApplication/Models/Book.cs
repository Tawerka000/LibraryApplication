using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryApplication.Models
{
    public class Book
    {
            public int bookID { get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public Book(int ID, string Title, string Description)
            {
                bookID = ID;
                title = Title;
                description = Description;
            }
    }
}