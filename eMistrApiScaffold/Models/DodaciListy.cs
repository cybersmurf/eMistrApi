using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class DodaciListy
    {
        public int Id { get; set; }
        public string BarId { get; set; }
        public int CustomerId { get; set; }
        public string User { get; set; }
        public DateTime Vystaveno { get; set; }
        public string Code { get; set; }
        public string Note { get; set; }
        public string ExterniId { get; set; }
        public string UserCode { get; set; }
        public string ZpusobDopravy { get; set; }
        public decimal HmotnostCelkem { get; set; }
        public int BalikyPocet { get; set; }
        public decimal BalikyObjem { get; set; }
        public decimal KurzHodnota { get; set; }
        public DateTime KurzDatum { get; set; }
        public int Dodaciadresa { get; set; }
        public string CisloFaktury { get; set; }
        public int StavDl { get; set; }
        public DateTime TsLastChange { get; set; }
        public DateTime TsCreated { get; set; }
    }
}
