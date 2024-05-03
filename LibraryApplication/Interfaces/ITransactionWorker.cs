using LibraryApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication.Interfaces
{
    public interface ITransactionWorker
    {
        IEnumerable<Transaction> transactions { get;}
        void AddNewTransaction(int BookUserID, int BookID);
        void ChangeTransactionState(int TransactionID);
    }
}
