using IgsClound.Interactor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgsClound.Interactor.Database
{
    public class CreateMySqlInteractor : IInteractor<Object, bool>
    {
        public bool Execute(Object request)
        {
            return true;
        }
    }
}
