using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class Stroje
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DatumNakup { get; set; }
        public int Odpracovano { get; set; }
        public decimal CenaHodina { get; set; }
        public int ServisDelay { get; set; }
        public DateTime Servis { get; set; }
        public string User { get; set; }
        public string Note { get; set; }
        public int GroupId { get; set; }
        public DateTime TerminZaruky { get; set; }
    }
}
