using LibraryApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication.Interfaces
{
    public interface IClientWorker
    {
        IEnumerable<Client> clients { get;}
        void AddNewClient(string newSecondName, string newName);
    }
}
