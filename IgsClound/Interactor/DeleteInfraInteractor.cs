using IgsClound.Interactor.Files;
using IgsClound.Interactor.Interfaces;
using IgsClound.Interactor.Storage;
using IgsClound.Interactor.VirtualMachine;
using IgsClound.Model.Request;
using IgsClound.Model.Response;
using IgsClound.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgsClound.Interactor
{
    public class DeleteInfraInteractor : IInteractor<DeleteInfraRequest, DeleteInfraResponse>
    {
        public DeleteInfraResponse Execute(DeleteInfraRequest request)
        {
            var error = DeleteInfraRequestValidator.Validate(request);
            if (error.ErrorResults.Count > 0)
            {
                return new DeleteInfraResponse()
                {
                    IsSuccess = false,
                    ErrorItems = error.ErrorResults,
                };
            };

            (new DeleteVirtualMachineInteractor()).Execute(request.ResourceID);
            (new DeleteStorageInteractor()).Execute(request.ResourceID);

            EnvironmentUtils.removeAllFileAndFolder(EnvironmentUtils.GetEnvironmentPath(request.ResourceID));

            return new DeleteInfraResponse() { IsSuccess = true };
        }
    }
}
