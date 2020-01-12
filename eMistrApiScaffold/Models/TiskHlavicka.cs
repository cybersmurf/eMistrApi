using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class TiskHlavicka
    {
        public int Id { get; set; }
        public string Nadpis { get; set; }
        public string Slozka { get; set; }
        public int Stav { get; set; }
    }
}
