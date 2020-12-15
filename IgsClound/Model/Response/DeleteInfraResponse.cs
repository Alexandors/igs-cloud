using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgsClound.Model.Response
{
    public class DeleteInfraResponse
    {
        public bool IsSuccess { get; set; }
        public List<ErrorItem> ErrorItems { get; set; }

        public DeleteInfraResponse()
        {
            this.ErrorItems = new List<ErrorItem>();
        }
    }
}
