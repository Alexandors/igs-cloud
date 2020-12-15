using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgsClound
{
    public static class Enums
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VirtualMachineType
        {
            Windows = 1,
            Linux = 2
        }

        [JsonConverter(typeof(StringEnumConverter))]
        public enum DatabaseType
        {
            MsSqlServer = 1,
            MySql = 2
        }

        public const string OutputFolder = "Output/IGS";
        public const string VirtualMachineFolder = "VirtualMachine";
        public const string StorageFolder = "Storage";
    }
}
