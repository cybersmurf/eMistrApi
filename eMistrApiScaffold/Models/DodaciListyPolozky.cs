using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class DodaciListyPolozky
    {
        public int Id { get; set; }
        public string BarId { get; set; }
        public string Name { get; set; }
        public decimal Kusu { get; set; }
        public string OrderId { get; set; }
        public decimal UnitPrice { get; set; }
        public int PrevodMatId { get; set; }
        public string MaterialId { get; set; }
        public int PolozkaPrijateObjednavkyId { get; set; }
        public int DodaciListId { get; set; }
        public string Note { get; set; }
        public int VydejId { get; set; }
        public string ExterniId { get; set; }
        public int? SerialId { get; set; }
        public int Zpracovano { get; set; }
        public string Intrastatcode { get; set; }
        public int PripravaVyrobyCheck { get; set; }
        public decimal PripravaVyroby { get; set; }
        public int PripravaPredlohyCheck { get; set; }
        public decimal PripravaPredlohy { get; set; }
        public int IneCheck { get; set; }
        public decimal Ine { get; set; }
        public decimal HmotnostPolozky { get; set; }
        public int DodaciAdresa { get; set; }
        public DateTime TsLastChange { get; set; }
        public DateTime TsCreated { get; set; }
    }
}
