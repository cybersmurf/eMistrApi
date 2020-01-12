using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class ZpusobDopravy
    {
        public int Id { get; set; }
        public string Nazev { get; set; }
        public int? Typ { get; set; }
        public string Formular { get; set; }
        public string Platby { get; set; }
        public string Poznamka { get; set; }
        public decimal Castka { get; set; }
        public int MaxHmotnost { get; set; }
    }
}
