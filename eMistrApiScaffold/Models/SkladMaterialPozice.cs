using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class SkladMaterialPozice
    {
        public int Id { get; set; }
        public string PoziceBarId { get; set; }
        public int Full { get; set; }
        public int SkladId { get; set; }
        public int ParentId { get; set; }
        public string Note { get; set; }
        public DateTime DatumPrijem { get; set; }
        public DateTime DatumVydej { get; set; }
        public int PoziceN1 { get; set; }
        public int PoziceN2 { get; set; }
        public int PoziceN3 { get; set; }
        public int PoziceN4 { get; set; }
    }
}
