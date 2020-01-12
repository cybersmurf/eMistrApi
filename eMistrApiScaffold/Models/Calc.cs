using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class Calc
    {
        public ulong Id { get; set; }
        public int MaterialId { get; set; }
        public string Nazev { get; set; }
        public decimal Koeficient { get; set; }
        public int MaterialId2 { get; set; }
        public decimal Koeficient2 { get; set; }
    }
}
