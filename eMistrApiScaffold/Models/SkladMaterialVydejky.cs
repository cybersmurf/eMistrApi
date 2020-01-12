using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class SkladMaterialVydejky
    {
        public ulong Id { get; set; }
        public string Doklad { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public decimal Castka { get; set; }
        public string Note { get; set; }
        public decimal CenaCelkem { get; set; }
        public string User { get; set; }
        public string Oznaceni { get; set; }
        public string Path { get; set; }
        public string Path2 { get; set; }
        public string ExterniId { get; set; }
        public string PrijatyDoklad { get; set; }
        public string OrderId { get; set; }
        public ulong CustomerId { get; set; }
        public string DodaciListVydany { get; set; }
        public string FakturaVydana { get; set; }
        public DateTime FakturaVydanaDatum { get; set; }
        public string CustomerName { get; set; }
        public string CustomerIco { get; set; }
        public int ExportPoradi { get; set; }
        public int Typ { get; set; }
        public int PohybId { get; set; }
        public int StavDokladu { get; set; }
        public DateTime TsLastChange { get; set; }
        public DateTime TsCreated { get; set; }
    }
}
