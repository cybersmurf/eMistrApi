using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class TypBaleni
    {
        public int IdTypbaleni { get; set; }
        public int? TypDopravy { get; set; }
        public string Kod { get; set; }
        public string Popis { get; set; }
        public int Vychozi { get; set; }
    }
}
