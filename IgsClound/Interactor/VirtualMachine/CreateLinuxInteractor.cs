﻿using IgsClound.Interactor.Files;
using IgsClound.Interactor.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace IgsClound.Interactor.VirtualMachine
{
    public class CreateLinuxInteractor : IInteractor<CreateLinuxInteractor.Request, bool>
    {
        public bool Execute(Request request)
        {
            string path = (new EnsureVmDirInteractor()).Execute(request.InfraID);

            var content = new Linux()
            {
                ResourceID = request.ResourceID,
                Description = request.Description,
                Type = Enums.VirtualMachineType.Linux.ToString()
            };

            var json = JsonConvert.SerializeObject(content);
            path = Path.Combine(path, string.Format("{0}.json", request.ResourceID));
            File.WriteAllText(path, json);

            return true;
        }


        public struct Request
        {
            public string ResourceID { get; set; }
            public string InfraID { get; set; }
            public string Description { get; set; }
        }

        private struct Linux
        {
            public string ResourceID { get; set; }
            public string Description { get; set; }
            public string Type { get; set; }
        }
    }

    
}
