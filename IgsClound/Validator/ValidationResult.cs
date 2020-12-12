using IgsClound.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgsClound.Validator
{
    public class ValidationResult
    {
        public bool IsValid
        {
            get
            {
                return ErrorResults?.Count == 0;
            }
        }

        public List<ErrorItem> ErrorResults;

        public ValidationResult()
        {
            ErrorResults = new List<ErrorItem>();
        }
    }
}
