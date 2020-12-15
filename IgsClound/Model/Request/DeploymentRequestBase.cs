using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgsClound.Model.Request
{
    public abstract class DeploymentResponseBase
    {
        public string ResourceID { get; set; }
        public string Description { get; set; }
    }
}
