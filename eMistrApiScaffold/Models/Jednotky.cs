using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class Jednotky
    {
        public int Id { get; set; }
        public string Nazev { get; set; }
        public int Poradi { get; set; }
        public int Visible { get; set; }
    }
}
