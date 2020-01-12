using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class SkladMaterialReaddata
    {
        public ulong Id { get; set; }
        public DateTime Date { get; set; }
        public ulong MaterialId { get; set; }
        public decimal Count { get; set; }
        public int WorkerId { get; set; }
        public string OrderId { get; set; }
        public int Calculated { get; set; }
        public int Added { get; set; }
        public string User { get; set; }
        public int Exported { get; set; }
        public ulong PrijemId { get; set; }
        public decimal Castka { get; set; }
        public string Note { get; set; }
        public decimal StavSkladu { get; set; }
        public int PolozkaObjednavkyId { get; set; }
        public int PrevodNasklad { get; set; }
        public int PolozkaDodlistId { get; set; }
        public DateTime Ulozeno { get; set; }
        public int PohybId { get; set; }
        public string ExtObj { get; set; }
        public string ExtDl { get; set; }
        public string Unirec { get; set; }
        public decimal DelkaPrirezu { get; set; }
        public decimal Prorez { get; set; }
        public decimal Count2 { get; set; }
        public decimal ZbytkovyMaterial { get; set; }
        public string Cislo { get; set; }
        public decimal VazenaCena { get; set; }
        public decimal PohybVazenaCena { get; set; }
        public decimal LastNakupCena { get; set; }
        public string ExterniId { get; set; }
        public int? ExportvydejkaId { get; set; }
        public decimal RozpusteneNaklady { get; set; }
        public ulong VydejId { get; set; }
        public string ZdrojOrderId { get; set; }
        public string Sarze { get; set; }
        public DateTime TsLastChange { get; set; }
        public DateTime TsCreated { get; set; }
    }
}
