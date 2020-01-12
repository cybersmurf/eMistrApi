using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class Faktury
    {
        public ulong Id { get; set; }
        public string OrderId { get; set; }
        public string Cislo { get; set; }
        public string Popis { get; set; }
        public DateTime Datum { get; set; }
        public decimal Castka { get; set; }
        public string User { get; set; }
        public DateTime DatumPlatby { get; set; }
        public decimal CastkaDph { get; set; }
        public decimal SazbaDph { get; set; }
        public int UseZaklad { get; set; }
        public DateTime TsLastChange { get; set; }
        public DateTime TsCreated { get; set; }
    }
}
