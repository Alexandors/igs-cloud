using IgsClound.Interactor;
using IgsClound.Model.Request;
using IgsClound.Model.Response;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgsClound.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IGSCloundServiceController : ControllerBase
    {
        [HttpPost]
        public DeploymentResponse Create(DeploymentRequest request)
        {
            return (new CreateInfrastructureInteractor()).Execute(request);
        }

        [HttpDelete]
        public DeleteInfraResponse Delete(DeleteInfraRequest request)
        {
            return (new DeleteInfraInteractor()).Execute(request);
        }
    }
}
