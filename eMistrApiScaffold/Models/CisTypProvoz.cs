using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class CisTypProvoz
    {
        public int IdTypProvoz { get; set; }
        public string Nazev { get; set; }
        public decimal FondHodin { get; set; }
        public decimal DenniFond { get; set; }
    }
}
