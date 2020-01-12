using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class CiselneRady
    {
        public int Id { get; set; }
        public string Prefix { get; set; }
        public string Cislo { get; set; }
        public string Agenda { get; set; }
        public string Note { get; set; }
        public int Defaultni { get; set; }
        public string Nazev { get; set; }
        public string Oddelovac { get; set; }
        public string Sufix { get; set; }
        public int Aktivni { get; set; }
    }
}
