using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class Pozice
    {
        public ulong Id { get; set; }
        public ulong MaterialId { get; set; }
        public int SkladId { get; set; }
        public string Pozice1 { get; set; }
        public decimal Mnoz { get; set; }
    }
}
