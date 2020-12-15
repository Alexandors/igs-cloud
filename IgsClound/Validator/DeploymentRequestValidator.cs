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
    public class DeploymentRequestValidator : IValidator<DeploymentRequest>
    {
        public static ValidationResult Validate(DeploymentRequest request)
        {
            var result = new ValidationResult();

            if (string.IsNullOrWhiteSpace(request.ResourceID))
            {
                result.ErrorResults.Add(new ErrorItem("DeploymentRequest ID is required"));
            }

            var path = EnvironmentUtils.GetEnvironmentPath(request.Environment);
            if (Directory.Exists(path))
            {
                result.ErrorResults.Add(new ErrorItem("Cannot create duplicate infrastructure, please change Environment"));
            }

            return result;
        }
    }
}
