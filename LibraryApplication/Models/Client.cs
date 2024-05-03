using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryApplication.Models
{
    public class Client
    {
        public int clientID { get; set; }
        public string secondName {get;set;}
        public string name { get; set; }
        public Client(int ID, string SecondName, string Name)
        {
            clientID = ID;
            secondName = SecondName;
            name = Name;
        }
    }
}