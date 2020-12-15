using IgsClound.Model;
using IgsClound.Model.Request;
using IgsClound.Validator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgsClound.Validator
{
    public class VirtualMachineRequestValidator : IValidator<List<VirtualMachineRequest>>
    {
        public static ValidationResult Validate(List<VirtualMachineRequest> requests)
        {
            var result = new ValidationResult();
            var ids = requests.Select(x => x.ResourceID);
            if (ids.Distinct().Count() != requests.Count)
            {
                var duplicatedList = ids.GroupBy(x => x).Where(g => g.Count() > 1).Select(x => x.Key);
                result.ErrorResults.Add(new ErrorItem(string.Format("Virtual Machine Resource ID is duplicated. {0}", string.Join(",", duplicatedList))));
            }

            if (requests.Select(x => x.ResourceID).Any(x => string.IsNullOrWhiteSpace(x)))
            {
                result.ErrorResults.Add(new ErrorItem("Virtual Machine Resource ID is required"));
            }

            var storageIds = requests.SelectMany(x => x.Storages.Select(y => y.ResourceID));
            if (storageIds.Count() != storageIds.Distinct().Count())
            {
                var duplicatedList = storageIds.GroupBy(x => x).Where(g => g.Count() > 1).Select(x => x.Key);
                result.ErrorResults.Add(new ErrorItem(string.Format("Duplicated Storage ID. {0}", string.Join(",", duplicatedList))));
            }

            return result;
        }
    }
}
