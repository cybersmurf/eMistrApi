using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class TiskFormulare
    {
        public int Id { get; set; }
        public int Idhlavicka { get; set; }
        public string Nazev { get; set; }
        public string Cesta { get; set; }
        public int Kmen { get; set; }
        public string Typ { get; set; }
        public int Stav { get; set; }
    }
}
