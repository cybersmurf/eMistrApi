using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class Subdodavky
    {
        public ulong Id { get; set; }
        public string OrderId { get; set; }
        public string Name { get; set; }
        public decimal Mnozstvi { get; set; }
        public int Jednotka { get; set; }
        public decimal CenaJednotka { get; set; }
        public decimal CenaCelkem { get; set; }
        public string User { get; set; }
        public string Doklad { get; set; }
        public int Cislo { get; set; }
        public int Planovana { get; set; }
        public DateTime DatumRealizace { get; set; }
        public DateTime DatumVytvoreni { get; set; }
        public string DokladMoney { get; set; }
        public decimal UserPrice { get; set; }
        public string Note { get; set; }
        public DateTime CreateFak { get; set; }
        public string DodavatelName { get; set; }
        public int DodavatelId { get; set; }
        public string IdPohoda { get; set; }
        public DateTime PredpDatumDodani { get; set; }
        public DateTime DatumDodani { get; set; }
        public DateTime TsLastChange { get; set; }
        public DateTime TsCreated { get; set; }
    }
}
