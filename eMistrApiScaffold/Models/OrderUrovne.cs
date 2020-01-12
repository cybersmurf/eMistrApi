using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class OrderUrovne
    {
        public int Id { get; set; }
        public int GlyphId { get; set; }
        public string Nazev { get; set; }
        public string BarvaPozadi { get; set; }
        public string BarvaFontu { get; set; }
        public string StylFontu { get; set; }
    }
}
