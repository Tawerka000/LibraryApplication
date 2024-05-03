using LibraryApplication.Interfaces;
using LibraryApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace LibraryApplication.Services
{
    public class TransactionWorker : ITransactionWorker
    {
        public IEnumerable<Transaction> transactions
        {
            get
            {
                return GetData.GetTransactions();
            }
        }
        public void AddNewTransaction(int BookUserID, int BookID)
        {
            var sql = "INSERT INTO Transactions (BookUserID, BookID, State) VALUES (@BookUserID, @BookID, @State)";
            using (OleDbConnection connection = ConnectToBase.OpenConnectionToDB())
            {
                using (OleDbCommand command = new OleDbCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@BookUserID", BookUserID);
                    command.Parameters.AddWithValue("@BookID", BookID);
                    command.Parameters.AddWithValue("@State", 1);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void ChangeTransactionState(int TransactionID)
        {
            var sql = $"UPDATE Transactions SET State = @State WHERE TransactionID = {TransactionID}";
            using (OleDbConnection connection = ConnectToBase.OpenConnectionToDB())
            {
                using (OleDbCommand command = new OleDbCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@State", 2);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}