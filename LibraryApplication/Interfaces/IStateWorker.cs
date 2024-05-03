using LibraryApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryApplication.Interfaces
{
    public interface IStateWorker
    {
        IEnumerable<State> states { get;}
    }
}