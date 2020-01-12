using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class ZpusobPlatby
    {
        public int Id { get; set; }
        public string Nazev { get; set; }
        public int? Typ { get; set; }
        public decimal Castka { get; set; }
        public string Poznamka { get; set; }
    }
}
