using LibraryApplication.Interfaces;
using LibraryApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LibraryApplication.Services
{
    public static class GetData
    {
        public static IEnumerable<Client> GetClients()
        {
            List<Client> result = new List<Client>();
            var sql = "SELECT Clients.* FROM Clients";
            using (OleDbConnection connection = ConnectToBase.OpenConnectionToDB())
            {
                using (OleDbCommand command = new OleDbCommand(sql, connection))
                {
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Client client = new Client(
                                Convert.ToInt32(reader["ClientId"]),
                                reader["SecondName"].ToString(),
                                reader["Name"].ToString()
                            );
                            result.Add(client);
                        }
                    }
                }
            }
            return result;
        }
        public static IEnumerable<Book> GetBooks()
        {
            List<Book> result = new List<Book>();
            var sql = "SELECT Books.* FROM Books";
            using (OleDbConnection connection = ConnectToBase.OpenConnectionToDB())
            {
                using (OleDbCommand command = new OleDbCommand(sql, connection)) 
                {
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Book book = new Book(
                                Convert.ToInt32(reader["BookID"]),
                                reader["Title"].ToString(),
                                reader["Description"].ToString()
                            );
                            result.Add(book);
                        }
                    }
                }
            }
            return result;
        }
        public static IEnumerable<State> GetStates()
        {
            List<State> result = new List<State>();
            var sql = "SELECT States.* FROM States";
            using (OleDbConnection connection = ConnectToBase.OpenConnectionToDB())
            {
                using (OleDbCommand command = new OleDbCommand(sql, connection))
                {
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            State state = new State(
                                Convert.ToInt32(reader["StateID"]),
                                reader["StateName"].ToString()
                            );
                            result.Add(state);
                        }
                    }
                }
            }
            return result;
        }
        public static IEnumerable<Transaction> GetTransactions()
        {
            List<Transaction> result = new List<Transaction>();
            var sql = @"SELECT        
                                Transactions.TransactionID, Clients.ClientID, Clients.SecondName, Clients.Name, 
                                Books.BookID, Books.Title, Books.Description, States.StateID, States.StateName
                        FROM
                                (((Transactions INNER JOIN
                                Books ON Transactions.BookID = Books.BookID) INNER JOIN
                                Clients ON Transactions.BookUserID = Clients.ClientID) INNER JOIN
                                States ON Transactions.State = States.StateID)";
            using (OleDbConnection connection = ConnectToBase.OpenConnectionToDB())
            {
                using (OleDbCommand command = new OleDbCommand(sql, connection))
                {
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Transaction transaction = new Transaction(
                            Convert.ToInt32(reader["TransactionID"]),
                            new Client(
                                Convert.ToInt32(reader["ClientID"]),
                                reader["SecondName"].ToString(),
                                reader["Name"].ToString()
                            ),
                            new Book
                            (
                                Convert.ToInt32(reader["BookID"]),
                                reader["Title"].ToString(),
                                reader["Description"].ToString()
                            ),
                            new State
                            (
                                Convert.ToInt32(reader["StateID"]),
                                reader["StateName"].ToString()
                            )
                            );
                            result.Add(transaction);
                        }
                    }
                }
            }
            return result;
        }
    }
}