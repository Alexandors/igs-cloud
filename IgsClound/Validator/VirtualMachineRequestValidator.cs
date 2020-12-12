using IgsClound.Model;
using IgsClound.Model.Request;
using IgsClound.Validator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgsClound.Validator
{
    public class VirtualMachineRequestValidator : IValidator<VirtualMachineRequest>
    {
        public static ValidationResult Validate(VirtualMachineRequest input)
        {
            var result = new ValidationResult();

            if (string.IsNullOrWhiteSpace(input.ResourceID))
            {
                result.ErrorResults.Add(new ErrorItem("Virtual Machine Resource ID is required"));
            }

            return result;
        }
    }
}
