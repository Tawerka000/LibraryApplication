using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryApplication.Models
{
    public class Transaction
    {
        public int transactionID { get; set; }
        public Client client { get; set; }
        public Book book { get; set; }
        public State state { get; set; }
        public Transaction(int ID, Client Client, Book Book, State State)
        {
            transactionID = ID;
            client = Client;
            book = Book;
            state = State;
        }
    }
}