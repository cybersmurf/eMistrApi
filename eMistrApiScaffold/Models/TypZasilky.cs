using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class TypZasilky
    {
        public int IdTypdopravy { get; set; }
        public int? IdDoprava { get; set; }
        public string Popis { get; set; }
        public int Vychozi { get; set; }
    }
}
