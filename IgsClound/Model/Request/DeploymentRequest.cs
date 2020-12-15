using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgsClound.Model.Request
{
    public class DeploymentRequest : DeploymentResponseBase
    {
        public string Environment { get; set; }
        public List<VirtualMachineRequest> VirtualMachines { get; set; }
        public List<DatabaseRequest> Databases { get; set; }
    }
}
