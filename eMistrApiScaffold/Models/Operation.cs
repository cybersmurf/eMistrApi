using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace eMistrApiScaffold.Models
{
    public partial class Operation
    {

        public ulong Id { get; set; }
        public string BarId { get; set; }
        public string Name { get; set; }
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public string Note { get; set; }
        public string MachineName { get; set; }
        public int IdEmployee { get; set; }
        public int Unit { get; set; }
        public decimal Unitcount { get; set; }
        public decimal UnitPrice { get; set; }
        public string User { get; set; }
        public int OpenDoor { get; set; }
        public int OrderstavId { get; set; }
        public decimal UkolovaMzda { get; set; }
        public int AutoWritte { get; set; }
        public int CncId { get; set; }
        public decimal CenaMzdovePolozky { get; set; }
        public int MaxminZaDen { get; set; }
        public int PlanovanoMin { get; set; }
        public int ResourceId { get; set; }
        public int TakePhoto { get; set; }
        public int? OperacePredchazejiciId { get; set; }
        public int? OperacePredchazejiciCas { get; set; }
        public int? OperacePredchazejiciFix { get; set; }
        public string ExterniId { get; set; }
        public int Priprava { get; set; }
        public int PripravaCas { get; set; }
        public int PripravaInterval { get; set; }
        public decimal CenaFaktura { get; set; }
        public decimal CenaRezie { get; set; }
        public decimal KoeficientMzdy { get; set; }
        public int SkladSkupinaId { get; set; }
        public decimal CenaMjOdmeny { get; set; }
        public decimal CenaMjOperace { get; set; }
        public int IsCnc { get; set; }
        public int IsDochazka { get; set; }
        public string UserCode { get; set; }
        public DateTime TsLastChange { get; set; }
        public DateTime TsCreated { get; set; }
    }
}
