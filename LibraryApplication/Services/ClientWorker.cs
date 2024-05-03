using LibraryApplication.Interfaces;
using LibraryApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace LibraryApplication.Services
{
    public class ClientWorker : IClientWorker
    {
        public IEnumerable<Client> clients
        {
            get
            {
                return GetData.GetClients();
            }
        }
        public void AddNewClient(string newSecondName, string newName)
        {
                var sql = "INSERT INTO Clients (SecondName, Name) VALUES (@SecondName, @Name)";
                using (OleDbConnection connection = ConnectToBase.OpenConnectionToDB())
                {
                    using (OleDbCommand command = new OleDbCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@SecondName", newSecondName);
                        command.Parameters.AddWithValue("@Name", newName);
                        command.ExecuteNonQuery();
                    }
                }
        }
    }
}