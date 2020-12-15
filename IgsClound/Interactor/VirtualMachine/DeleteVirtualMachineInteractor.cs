using IgsClound.Interactor.Files;
using IgsClound.Interactor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgsClound.Interactor.VirtualMachine
{
    public class DeleteVirtualMachineInteractor : IInteractor<string, bool>
    {
        public bool Execute(string infraId)
        {
            var vmPath = EnsureVmDirInteractor.GetVmPath(infraId);
            EnvironmentUtils.removeAllFileAndFolder(vmPath);
            return true;
        }
    }
}
