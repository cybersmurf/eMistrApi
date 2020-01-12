using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class UzamceneObdobi
    {
        public int Id { get; set; }
        public DateTime DatumKonecObdobi { get; set; }
        public DateTime DatumUzamceni { get; set; }
        public string User { get; set; }
    }
}
