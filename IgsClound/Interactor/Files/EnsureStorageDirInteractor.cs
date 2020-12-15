using IgsClound.Interactor.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace IgsClound.Interactor.Files
{
    public class EnsureStorageDirInteractor : IInteractor<string, string>
    {
        public string Execute(string infraId)
        {
            var path = Path.Combine(EnvironmentUtils.GetEnvironmentPath(infraId), Enums.StorageFolder);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            return path;
        }
    }
}
