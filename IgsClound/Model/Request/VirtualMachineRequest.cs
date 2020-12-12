using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgsClound.Model.Request
{
    public class VirtualMachineRequest : DeploymentResponseBase
    {
        public Enums.VirtualMachineType Type;
        string StorageID;
        
    }
}
