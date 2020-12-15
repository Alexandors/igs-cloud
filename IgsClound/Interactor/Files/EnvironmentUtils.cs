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

        public static void removeAllFileAndFolder(string path)
        {
            if (!Directory.Exists(path))
            {
                return;
            }

            DirectoryInfo root = new DirectoryInfo(path);

            foreach (FileInfo file in root.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in root.GetDirectories())
            {
                dir.Delete(true);
            }

            root.Delete(true);
        }
    }
}
