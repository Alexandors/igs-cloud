using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgsClound.Model.Request
{
    public class DatabaseRequest : DeploymentResponseBase
    {
        Enums.DatabaseType Type;
        string StorageID;
    }
}
