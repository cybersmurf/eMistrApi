using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class ReaddataCeny
    {
        public ulong Id { get; set; }
        public ulong IdReaddata { get; set; }
        public decimal CenaWorker { get; set; }
        public decimal CenaWorkerNaklad { get; set; }
        public decimal CenaWorkerFaktura { get; set; }
        public decimal CenaWorker2 { get; set; }
        public decimal CenaWorker2Naklad { get; set; }
        public decimal CenaWorker2Faktura { get; set; }
        public decimal CenaOperation { get; set; }
        public decimal CenaOperationMj { get; set; }
        public decimal CenaOwOperation { get; set; }
        public decimal CenaOwOperationMj { get; set; }
        public decimal CenaStroj { get; set; }
        public decimal CenaCnc { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Verze { get; set; }
        public decimal WorkerKoefSkutNakl { get; set; }
        public decimal Worker2KoefSkutNakl { get; set; }
        public int TypVypoctu { get; set; }
        public int Added { get; set; }
        public int Calculated { get; set; }
        public decimal WorkerPriceSat { get; set; }
        public decimal Worker2PriceSat { get; set; }
        public decimal WorkerPriceSun { get; set; }
        public decimal Worker2PriceSun { get; set; }
        public decimal Mzda { get; set; }
        public decimal Naklad { get; set; }
        public decimal OpCenaRezie { get; set; }
        public decimal OwUkolovaMzda { get; set; }
        public decimal Mnoz { get; set; }
        public string OrderId { get; set; }
        public ulong OperationId { get; set; }
        public int WorkerId { get; set; }
        public int WorkerId2 { get; set; }
        public decimal MzdaHod { get; set; }
        public decimal MzdaUkol { get; set; }
        public decimal Odvody { get; set; }
        public DateTime TsCreated { get; set; }
        public DateTime TsChanged { get; set; }
        public DateTime TsCalculated { get; set; }
        public decimal OpUkolMzda { get; set; }
        public decimal OpCenaMjOdmena { get; set; }
        public decimal Rezie { get; set; }
        public decimal OwCenaRezie { get; set; }
        public decimal OwUnitPrice { get; set; }
        public decimal OpCenaMj { get; set; }
    }
}
