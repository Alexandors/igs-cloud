using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgsClound.Model
{
    public class ErrorItem
    {
        public int? ErrorCode { get; set; }
        public string Message { get; set; }

        public ErrorItem(string message, int? errorCode = null)
        {
            this.ErrorCode = errorCode;
            this.Message = message;
        }
    }
}
