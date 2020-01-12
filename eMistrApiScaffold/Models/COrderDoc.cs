using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class COrderDoc
    {
        public ulong Id { get; set; }
        public string OrderId { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public int IsFile { get; set; }
        public int ZobrazitNahled { get; set; }
        public string ExternalListType { get; set; }
        public int ExternalListIdRecord { get; set; }
        public int DefaultDocument { get; set; }
    }
}
