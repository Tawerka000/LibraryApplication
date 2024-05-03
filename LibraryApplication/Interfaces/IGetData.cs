using LibraryApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication.Interfaces
{
    public interface IGetData
    {
        IEnumerable<Client> GetClients();
        IEnumerable<Book> GetBooks();
        IEnumerable<State> GetStates();
        IEnumerable<Transaction> GetTransactions();
    }
}
