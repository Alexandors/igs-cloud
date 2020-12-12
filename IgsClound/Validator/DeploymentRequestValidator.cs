using IgsClound.Model;
using IgsClound.Model.Request;
using IgsClound.Validator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgsClound.Validator
{
    public class DeploymentRequestValidator : IValidator<DeploymentResponseBase>
    {
        public static ValidationResult Validate(DeploymentResponseBase request)
        {
            var result = new ValidationResult();

            if (string.IsNullOrWhiteSpace(request.ResourceID))
            {
                result.ErrorResults.Add(new ErrorItem("DeploymentRequest ID is required"));
            }

            return result;
        }
    }
}
