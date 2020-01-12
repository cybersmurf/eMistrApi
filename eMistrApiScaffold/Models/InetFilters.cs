using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class InetFilters
    {
        public int Id { get; set; }
        public int IdOperationGroup { get; set; }
        public int IdCategory { get; set; }
        public string Values { get; set; }
    }
}
