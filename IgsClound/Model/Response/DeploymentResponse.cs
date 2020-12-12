using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgsClound.Model.Response
{
    public class DeploymentResponse
    {
        public bool IsSuccess;
        public List<ErrorItem> ErrorItems;

        public DeploymentResponse()
        {
            this.ErrorItems = new List<ErrorItem>();
        }
    }
}
