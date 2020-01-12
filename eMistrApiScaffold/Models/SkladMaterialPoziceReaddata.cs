using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class SkladMaterialPoziceReaddata
    {
        public int Id { get; set; }
        public int Active { get; set; }
        public int PoziceId { get; set; }
        public int PoziceIdSub { get; set; }
        public int MaterialId { get; set; }
        public decimal Mnozstvi { get; set; }
        public decimal Vaha { get; set; }
        public ulong SkladReaddataId { get; set; }
        public DateTime PohybDatetime { get; set; }
        public DateTime PohybDatetimeOut { get; set; }
        public decimal? Pohyb { get; set; }
        public string PohybTyp { get; set; }
        public string Note { get; set; }
        public int UserIdIn { get; set; }
        public int UserIdOut { get; set; }
        public int PaletaId { get; set; }
        public string OrderId { get; set; }
        public int RequestId { get; set; }
        public string Sarze { get; set; }
        public int PohybGroupId { get; set; }
    }
}
