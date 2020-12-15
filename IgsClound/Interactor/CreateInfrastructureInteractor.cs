using IgsClound.Interactor.Files;
using IgsClound.Interactor.Interfaces;
using IgsClound.Interactor.Storage;
using IgsClound.Interactor.VirtualMachine;
using IgsClound.Model.Request;
using IgsClound.Model.Response;
using IgsClound.Validator;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace IgsClound.Interactor
{
    public class CreateInfrastructureInteractor : IInteractor<DeploymentRequest, DeploymentResponse>
    {
        public DeploymentResponse Execute(DeploymentRequest request)
        {
            var error = DeploymentRequestValidator.Validate(request);
            error.ErrorResults.AddRange(VirtualMachineRequestValidator.Validate(request.VirtualMachines)?.ErrorResults);

            if (error.ErrorResults.Count > 0)
            {
                return new DeploymentResponse()
                {
                    IsSuccess = false,
                    ErrorItems = error.ErrorResults,
                };
            };

            request?.VirtualMachines?.ForEach(vm =>
            {
                vm.Storages.ForEach(storage =>
                {
                    var createRequest = new CreateStorageInteractor.Request()
                    {
                        ResourceID = storage.ResourceID,
                        Description = storage.Description,
                        InfraID = request.ResourceID,
                    };
                    (new CreateStorageInteractor()).Execute(createRequest);
                });

               if (vm.Type == Enums.VirtualMachineType.Windows)
                {
                    var createRequest = new CreateLinuxInteractor.Request()
                    {
                        ResourceID = vm.ResourceID,
                        InfraID = request.ResourceID,
                        Description = vm.Description,
                    };
                    (new CreateLinuxInteractor()).Execute(createRequest);
                } else if (vm.Type == Enums.VirtualMachineType.Linux)
                {
                    var createRequest = new CreateLinuxInteractor.Request()
                    {
                        ResourceID = vm.ResourceID,
                        InfraID = request.ResourceID,
                        Description = vm.Description,
                    };
                    (new CreateLinuxInteractor()).Execute(createRequest);
                }
            });

            return new DeploymentResponse() { IsSuccess = true };
        }
    }
}
