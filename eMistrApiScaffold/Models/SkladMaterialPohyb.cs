using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class SkladMaterialPohyb
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DoSkladuId { get; set; }
        public int ZeSkladuId { get; set; }
        public string BarId { get; set; }
        public int Aktivni { get; set; }
    }
}
