using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class Packages
    {
        public ulong Id { get; set; }
        public string BarId { get; set; }
        public ulong? SpeditionId { get; set; }
        public DateTime? Vytvoren { get; set; }
        public DateTime? Zabalen { get; set; }
        public ulong? ReaddataId { get; set; }
        public string OrderId { get; set; }
        public int Hnizdo { get; set; }
        public int? CustomerId { get; set; }
        public int Stav { get; set; }
        public int Poradi { get; set; }
        public DateTime? VytistenoDne { get; set; }
        public DateTime? Expedice { get; set; }
        public int Tisk { get; set; }
        public string SouborExp { get; set; }
        public DateTime? Odeslan { get; set; }
        public string ExpediceBar { get; set; }
        public string Poznamka { get; set; }
        public int Hmotnost { get; set; }
    }
}
