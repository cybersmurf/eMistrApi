using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class OrderWork
    {
        public string OrderId { get; set; }
        public ulong OperationId { get; set; }
        public int UserTime { get; set; }
        public decimal UserPrice { get; set; }
        public decimal Units { get; set; }
        public decimal UkolovaMzda { get; set; }
        public int TypVypoctu { get; set; }
        public int Poradi { get; set; }
        public string Comment { get; set; }
        public int UserTimeKsSecond { get; set; }
        public int KoeficientVyroby { get; set; }
        public int Odpracovano { get; set; }
        public int RealTime { get; set; }
        public decimal RealPrice { get; set; }
        public decimal Vyrobenocelkem { get; set; }
        public decimal ZmetkuCelkem { get; set; }
        public int PlanKalendar { get; set; }
        public int? OperacePredchazejiciId { get; set; }
        public int? OperacePredchazejiciCas { get; set; }
        public int? OperacePredchazejiciFix { get; set; }
        public int Id { get; set; }
        public string ExterniId { get; set; }
        public int? Priznaky { get; set; }
        public int OperacePredchazejiciAdded { get; set; }
        public int Priprava { get; set; }
        public int PripravaCas { get; set; }
        public int PripravaKoeficient { get; set; }
        public int PripravaInterval { get; set; }
        public DateTime StartReq { get; set; }
        public DateTime FinishReq { get; set; }
        public int Forma1Id { get; set; }
        public int Priorita { get; set; }
        public int PoradiTechpostup { get; set; }
        public decimal Forma1MnozstviCyklus { get; set; }
        public decimal Forma1MaterialCyklus { get; set; }
        public int VyplnenoUkolovaMzda { get; set; }
        public int Unit { get; set; }
        public decimal OpUnitPrice { get; set; }
        public decimal OpUkolovaMzda { get; set; }
        public decimal OpCenaFaktura { get; set; }
        public decimal OpCenaRezie { get; set; }
        public decimal OpCenaMjOdmeny { get; set; }
        public int OpStrojId { get; set; }
        public decimal OpStrojCena { get; set; }
        public decimal OpCenaMj { get; set; }
        public int TsCalculated { get; set; }
        public DateTime TsLastChange { get; set; }
        public DateTime TsLastCalculated { get; set; }
        public DateTime TsCreated { get; set; }
    }
}
