using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryApplication.Models
{
    public class State
    {
        public int stateID { get; set; }
        public string stateName { get; set; }
        public State(int ID, string Name)
        {
            stateID = ID;
            stateName = Name;
        }
    }
}