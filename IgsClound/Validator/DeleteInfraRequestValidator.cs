using IgsClound.Interactor.Files;
using IgsClound.Model;
using IgsClound.Model.Request;
using IgsClound.Validator.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace IgsClound.Validator
{
    public class DeleteInfraRequestValidator : IValidator<DeleteInfraRequest>
    {
        public static ValidationResult Validate(DeleteInfraRequest input)
        {
            var result = new ValidationResult();

            if (string.IsNullOrWhiteSpace(input.ResourceID))
            {
                result.ErrorResults.Add(new ErrorItem("Resource ID is required"));
            }

            var path = EnvironmentUtils.GetEnvironmentPath(input.ResourceID);
            if (!Directory.Exists(path))
            {
                result.ErrorResults.Add(new ErrorItem(string.Format("Infrastructure {0} does not exist.", input.ResourceID)));
            }

            return result;
        }
    }
}
