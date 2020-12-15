using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace IgsClound.Interactor.Files
{
    public class EnvironmentUtils
    {
        public static string GetEnvironmentPath(string infraId)
        {
            return Path.Combine(Enums.OutputFolder, infraId);
        }

        public void removeAllFileAndFolder(string infraId)
        {
            DirectoryInfo root = new DirectoryInfo(GetEnvironmentPath(infraId));

            foreach (FileInfo file in root.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in root.GetDirectories())
            {
                dir.Delete(true);
            }
        }
    }
}
