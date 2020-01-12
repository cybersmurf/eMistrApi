using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class NabidkaPolozky
    {
        public ulong Id { get; set; }
        public string Nazev { get; set; }
        public decimal Cena { get; set; }
        public decimal Mnoz { get; set; }
        public int Dph { get; set; }
        public int Sleva { get; set; }
        public int MaterialId { get; set; }
        public string OrderId { get; set; }
        public int Unit { get; set; }
        public string Note { get; set; }
        public decimal CenaCelkem { get; set; }
        public int Cislo { get; set; }
        public decimal? CenaNakup { get; set; }
    }
}
