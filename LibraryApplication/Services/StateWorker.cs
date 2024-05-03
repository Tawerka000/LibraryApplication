using LibraryApplication.Interfaces;
using LibraryApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryApplication.Services
{
    public class StateWorker : IStateWorker
    {
        public IEnumerable<State> states 
        {
            get
            {
               return GetData.GetStates();
            }
        }
    }
}