using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace IgsClound.Model.Request
{
    public class VirtualMachineRequest : DeploymentResponseBase
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public Enums.VirtualMachineType Type { get; set; }
        public List<StorageRequest> Storages { get; set; }

    }
}
