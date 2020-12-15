using IgsClound.Interactor.Files;
using IgsClound.Interactor.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace IgsClound.Interactor.Storage
{
    public class CreateStorageInteractor : IInteractor<CreateStorageInteractor.Request, bool>
    {
        public bool Execute(Request request)
        {
            string path = (new EnsureStorageDirInteractor()).Execute(request.InfraID);
            var content = new Storage()
            {
                ResourceID = request.ResourceID,
                Description = request.Description
            };
            var json = JsonConvert.SerializeObject(content);
            path = Path.Combine(path, string.Format("{0}.json", request.ResourceID));
            File.WriteAllText(path, json);

            return true;
        }


        private struct Storage
        {
            public string ResourceID { get; set; }
            public string Description { get; set; }
        }

        public struct Request
        {
            public string ResourceID { get; set; }
            public string InfraID { get; set; }
            public string Description { get; set; }
        }
    }
}
