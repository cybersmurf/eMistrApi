using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class NaradiSkupina
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }
        public int NaradiType { get; set; }
    }
}
