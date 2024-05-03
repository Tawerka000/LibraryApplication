using LibraryApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication.Interfaces
{
    public interface IBookWorker
    {
        IEnumerable<Book> books { get;}
        void AddNewBook(string newTitle, string newDescription);
        void ChangeBookDescription(int bookID, string newDescription);
    }
}
