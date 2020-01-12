using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class Readdata
    {
        public ulong Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public string OrderId { get; set; }
        public ulong OperationId { get; set; }
        public int WorkerId { get; set; }
        public int RepairType { get; set; }
        public string Note { get; set; }
        public string User { get; set; }
        public int Calculated { get; set; }
        public int OrderGroupId { get; set; }
        public int CalculatedMachine { get; set; }
        public decimal Mnoz { get; set; }
        public decimal UkonovaMzda { get; set; }
        public int AddedPrice { get; set; }
        public decimal Naklady { get; set; }
        public ulong SerialId { get; set; }
        public int Exportovano { get; set; }
        public decimal UkonMzda { get; set; }
        public int TypUkonMzdy { get; set; }
        public decimal Zmetku { get; set; }
        public int WorkerId2 { get; set; }
        public int Volitelna1 { get; set; }
        public int KusyZapocteno { get; set; }
        public int CalculatedOrderwork { get; set; }
        public int CalculatedKalendar { get; set; }
        public int PhotoCount { get; set; }
        public int Priorita { get; set; }
        public int DodaciListPolozkaId { get; set; }
        public decimal Volitelna2 { get; set; }
        public string SerialIdStr { get; set; }
        public int? Hnizdo { get; set; }
        public int? PoradiOperace { get; set; }
        public int? OrderworkId { get; set; }
        public int Zamceno { get; set; }
        public DateTime ZamcenoCas { get; set; }
        public int ZamcenoIdUser { get; set; }
        public string Sarze { get; set; }
        public decimal NakladyVstup { get; set; }
        public int Locked { get; set; }
        public decimal CenaWorker { get; set; }
        public decimal CenaWorker2 { get; set; }
        public decimal CenaOperation { get; set; }
        public decimal CenaCnc { get; set; }
        public decimal CenaStroj { get; set; }
        public int? FakturaId { get; set; }
        public string FakturaDoklad { get; set; }
        public decimal CenaMj { get; set; }
        public int TypVypoctu { get; set; }
        public int Prepocitano { get; set; }
        public decimal NakladyWorker { get; set; }
        public decimal NakladyOrder { get; set; }
        public decimal NakladyOperation { get; set; }
        public int? UmUznano { get; set; }
        public int? UmFondOdpis { get; set; }
        public int? UmFondZbyva { get; set; }
        public DateTime? UmUznanoDatum { get; set; }
        public string UmUznanoUser { get; set; }
        public string ExterniId { get; set; }
        public int CenyAdded { get; set; }
        public string TerminalIp { get; set; }
        public DateTime TsLastChange { get; set; }
        public DateTime TsCreated { get; set; }

        public virtual Worker Worker { get; set; }
    }
}
