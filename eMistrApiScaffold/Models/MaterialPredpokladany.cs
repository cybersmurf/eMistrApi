using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class MaterialPredpokladany
    {
        public ulong Id { get; set; }
        public string OrderId { get; set; }
        public ulong MaterialId { get; set; }
        public decimal Mnozstvi { get; set; }
        public int Jednotka { get; set; }
        public decimal CenaJednotka { get; set; }
        public decimal CenaCelkem { get; set; }
        public string User { get; set; }
        public decimal Par1 { get; set; }
        public decimal Par2 { get; set; }
        public decimal Par3 { get; set; }
        public decimal Par4 { get; set; }
        public decimal Par5 { get; set; }
        public decimal Par6 { get; set; }
        public ulong ParTyp { get; set; }
        public decimal Vyteznost { get; set; }
        public string Note { get; set; }
        public string ExterniId { get; set; }
        public int ObjednavkaId { get; set; }
        public string Objednavka { get; set; }
        public int? Poradi { get; set; }
        public DateTime DatePriprava { get; set; }
        public DateTime DateFinish { get; set; }
        public DateTime TsLastChange { get; set; }
        public DateTime TsCreated { get; set; }
    }
}
