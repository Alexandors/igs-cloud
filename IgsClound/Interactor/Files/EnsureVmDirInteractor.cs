using IgsClound.Interactor.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace IgsClound.Interactor.Files
{
    public class EnsureVmDirInteractor : IInteractor<string, string>
    {
        public string Execute(string infraId)
        {
            var path = GetVmPath(infraId);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            return path;
        }

        public static string GetVmPath(string infraId)
        {
            return Path.Combine(EnvironmentUtils.GetEnvironmentPath(infraId), Enums.VirtualMachineFolder);
        }
    }
}
