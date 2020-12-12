using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgsClound.Interactor.Interfaces
{
    interface IInteractor<TRequest, TResponse>
    {
        public TResponse Execute(TRequest request);
    }
}
