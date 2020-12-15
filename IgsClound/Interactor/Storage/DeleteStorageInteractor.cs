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
    public class DeleteStorageInteractor : IInteractor<string, bool>
    {
        public bool Execute(string infraId)
        {
            var storagePath = EnsureStorageDirInteractor.GetStoragePath(infraId);
            EnvironmentUtils.removeAllFileAndFolder(storagePath);
            return true;
        }
    }
}
