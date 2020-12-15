using IgsClound.Model;
using IgsClound.Model.Request;
using IgsClound.Validator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgsClound.Validator
{
    public class DatabaseRequestValidator : IValidator<DatabaseRequest>
    {
        public static ValidationResult Validate(DatabaseRequest input)
        {

            var result = new ValidationResult();

            if (string.IsNullOrWhiteSpace(input.ResourceID))
            {
                result.ErrorResults.Add(new ErrorItem("Database Resource ID is required"));
            }

            return result;
        }
    }
}
