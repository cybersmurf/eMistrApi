using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class Material
    {
        public ulong Id { get; set; }
        public string OrderId { get; set; }
        public string Name { get; set; }
        public decimal Mnozstvi { get; set; }
        public int Jednotka { get; set; }
        public decimal CenaJednotka { get; set; }
        public decimal CenaCelkem { get; set; }
        public string User { get; set; }
        public string Worker { get; set; }
        public ulong MaterialId { get; set; }
        public ulong WorkerId { get; set; }
        public string BarId { get; set; }
        public ulong ReaddataId { get; set; }
        public int ChangePrice { get; set; }
        public decimal CenaJednotkaNakup { get; set; }
        public decimal CenaCelkemNakup { get; set; }
        public DateTime Date { get; set; }
        public decimal VazenaCena { get; set; }
        public decimal PohybVazenaCena { get; set; }
        public decimal LastNakupCena { get; set; }
        public DateTime TsLastChange { get; set; }
        public DateTime TsCreated { get; set; }
    }
}
