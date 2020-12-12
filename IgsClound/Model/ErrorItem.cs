using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgsClound.Model
{
    public class ErrorItem
    {
        int? ErrorCode;
        string Message;

        public ErrorItem(string message, int? errorCode = null)
        {
            this.ErrorCode = errorCode;
            this.Message = message;
        }
    }
}
