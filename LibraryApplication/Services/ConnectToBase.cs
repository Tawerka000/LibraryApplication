using LibraryApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace LibraryApplication.Services
{
    public static class ConnectToBase
    {
        static string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
        static string connectionString = $@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={baseDirectory}\DataBase\LibraryDataBase.mdb";
        public static OleDbConnection OpenConnectionToDB()
        {
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}