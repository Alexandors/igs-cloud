using IgsClound.Model.Request;
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
        public string Create(DeploymentRequest request)
        {
            return "Success";
        }
    }
}
