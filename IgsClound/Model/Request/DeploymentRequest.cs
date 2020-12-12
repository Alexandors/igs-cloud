using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgsClound.Model.Request
{
    public class DeploymentRequest : DeploymentResponseBase
    {
        public string Environment;
        public VirtualMachineRequest VirtualMachineRequest;
        public DatabaseRequest DatabaseRequest;
    }
}
