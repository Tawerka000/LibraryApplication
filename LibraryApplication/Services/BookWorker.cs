using LibraryApplication.Interfaces;
using LibraryApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace LibraryApplication.Services
{
    public class BookWorker : IBookWorker
    {
        public IEnumerable<Book> books
        {
            get
            {
                return GetData.GetBooks();
            }
        }
        public void AddNewBook(string newTitle, string newDescription)
        {
            {
                var sql = "INSERT INTO Books (Title, Description) VALUES (@Title, @Description)";
                using (OleDbConnection connection = ConnectToBase.OpenConnectionToDB())
                {
                    using (OleDbCommand command = new OleDbCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Title", newTitle);
                        command.Parameters.AddWithValue("@Description", newDescription);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
        public void ChangeBookDescription(int bookID, string newDescription)
        {
            var sql = $"UPDATE Books SET Description = @Description WHERE BookID = {bookID}";
            using (OleDbConnection connection = ConnectToBase.OpenConnectionToDB())
            {
                using (OleDbCommand command = new OleDbCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Description", newDescription);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}