using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication.Interfaces
{
    interface IPushData
    {
        void PushNewClient();
        void PushNewBook();
        void PushChangedDesc();
        void PushNewTransaction();
        void PushChangedTransaction();
    }
}
