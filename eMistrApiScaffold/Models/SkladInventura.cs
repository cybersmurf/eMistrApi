using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class SkladInventura
    {
        public int Id { get; set; }
        public DateTime DatumInventura { get; set; }
        public DateTime DatumEvidenciStav { get; set; }
        public DateTime DatumUzavreni { get; set; }
        public string Poznamka { get; set; }
        public int Stav { get; set; }
        public int TypSkladFilter { get; set; }
        public string SkladFilterList { get; set; }
        public int IdTypInventura { get; set; }
        public int IdPrijemka { get; set; }
        public int IdTypPrijemka { get; set; }
        public int IdVydejka { get; set; }
        public int IdTypVydejka { get; set; }
        public string Nazev { get; set; }
        public string SkupinaFilterList { get; set; }
        public string InventuraDoklad { get; set; }
        public string InventuraNazev { get; set; }
    }
}
