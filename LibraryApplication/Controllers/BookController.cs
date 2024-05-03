using LibraryApplication.Interfaces;
using LibraryApplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryApplication.Controllers
{
    public class BookController : Controller
    {
        private BookWorker BookWorker = new BookWorker();

        public ViewResult List()
        {
            var books = BookWorker.books;
            return View(books);
        }
        [HttpPost]
        public void AddNewBook(string title, string description)
        {
            BookWorker.AddNewBook(title, description);
        }
        [HttpPost]
        public void UpdateDescription(int id, string description)
        {
            BookWorker.ChangeBookDescription(id, description);
        }
        
    }
}