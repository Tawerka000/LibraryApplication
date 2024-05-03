using LibraryApplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryApplication.Controllers
{
    public class TransactionController : Controller
    {
        private TransactionWorker TransactionWorker = new TransactionWorker();
        private ClientWorker ClientWorker = new ClientWorker();
        private BookWorker BookWorker = new BookWorker();
        private StateWorker StateWorker = new StateWorker();
        public ViewResult List()
        {
            var transactions = TransactionWorker.transactions;
            ViewBag.Clients = ClientWorker.clients;
            ViewBag.Books = BookWorker.books;
            ViewBag.State = StateWorker.states;
            return View(transactions);
        }
        [HttpPost]
        public void AddNewTransaction(int ClientID, int BookID)
        {
            TransactionWorker.AddNewTransaction(ClientID, BookID);
        }
        [HttpPost]
        public void UpdateTransactionState(int TransactionID)
        {
            TransactionWorker.ChangeTransactionState(TransactionID);
        }
    }
}