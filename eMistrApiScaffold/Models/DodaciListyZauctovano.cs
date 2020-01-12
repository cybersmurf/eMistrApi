using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class DodaciListyZauctovano
    {
        public ulong Id { get; set; }
        public int DodaciListId { get; set; }
        public string Doklad { get; set; }
        public DateTime TsLastChange { get; set; }
        public DateTime TsCreated { get; set; }
    }
}
