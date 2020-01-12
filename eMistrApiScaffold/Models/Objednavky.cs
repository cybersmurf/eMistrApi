using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class Objednavky
    {
        public int Id { get; set; }
        public string BarId { get; set; }
        public string Note { get; set; }
        public DateTime Vystaveno { get; set; }
        public string User { get; set; }
        public string Name { get; set; }
        public int CustomerId { get; set; }
        public string OrderId { get; set; }
        public DateTime Dodani { get; set; }
        public int DopravaId { get; set; }
        public string Doklad { get; set; }
        public string Doklad2 { get; set; }
        public DateTime Splatno { get; set; }
        public int Vykryto { get; set; }
        public DateTime? VykrytoDate { get; set; }
        public string ExterniId { get; set; }
        public int StavDokladu { get; set; }
        public DateTime TsLastChange { get; set; }
        public DateTime TsCreated { get; set; }
    }
}
