using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class ObjednavkyPolozky
    {
        public int Id { get; set; }
        public int ObjednavkaId { get; set; }
        public int MaterialId { get; set; }
        public decimal Kusu { get; set; }
        public int Unit { get; set; }
        public decimal Price { get; set; }
        public int NaradiId { get; set; }
        public decimal Unitprice { get; set; }
        public string Note { get; set; }
        public DateTime DodatDo { get; set; }
        public string OrderId { get; set; }
        public string Name { get; set; }
        public int BezVazby { get; set; }
        public decimal VykrytoBezVazby { get; set; }
        public int Vykryto { get; set; }
        public DateTime? VykrytoDate { get; set; }
        public int SubdodavkaId { get; set; }
        public int FormaId { get; set; }
        public string ExterniId { get; set; }
        public DateTime TsLastChange { get; set; }
        public DateTime TsCreated { get; set; }
    }
}
