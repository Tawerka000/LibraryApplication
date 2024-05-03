using LibraryApplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryApplication.Controllers
{
    public class ClientController : Controller
    {
        private ClientWorker ClientWorker = new ClientWorker();

        public ViewResult List()
        {
            var clients = ClientWorker.clients;
            return View(clients);
        }
        [HttpPost]
        public void AddNewClient(string secondName, string name)
        {
            ClientWorker.AddNewClient(secondName, name);
        }
    }
}