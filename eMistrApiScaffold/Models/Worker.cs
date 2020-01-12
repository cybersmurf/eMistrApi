using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace eMistrApiScaffold.Models
{
    public partial class Worker
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string BarId { get; set; }
        public string Comment { get; set; }
        public DateTime Start { get; set; }
        public string Active { get; set; }
        public DateTime Finish { get; set; }
        public string User { get; set; }
        public decimal Workerprice { get; set; }
        public decimal PriceSat { get; set; }
        public decimal PriceSun { get; set; }
        public int Type { get; set; }
        public int Cnc { get; set; }
        public string Card { get; set; }
        public string GroupName { get; set; }
        public string Profese { get; set; }
        public string MistoPrace { get; set; }
        public string Smena { get; set; }
        public string DostupneSmeny { get; set; }
        public int CncStartOperationId { get; set; }
        public int CncEndOperationId { get; set; }
        public int CncOperationPrihlaseni { get; set; }
        public int CncOperationKontrola { get; set; }
        public int CncOperationServis { get; set; }
        public int CncOperationOdevzdaniks { get; set; }
        public int CncOperationIdle { get; set; }
        public int CncOperationAlarm { get; set; }
        public int CncOperationSing { get; set; }
        public int CncOperationFeed { get; set; }
        public int CncOperationBusy { get; set; }
        public string CardDmr { get; set; }
        public int CncOperationUdrzba { get; set; }
        public string StavCnc { get; set; }
        public DateTime BusyStart { get; set; }
        public DateTime LastCycle { get; set; }
        public int CncOperationKonec { get; set; }
        public int CncOperationNedefinovano { get; set; }
        public int CncOperationWaitkontrola { get; set; }
        public string Alias { get; set; }
        public int Priorita { get; set; }
        public decimal CenaFakturace { get; set; }
        public int UseCenaFakturace { get; set; }
        public ulong UserPin { get; set; }
        public string Prihlaseni { get; set; }
        public int CncGroup { get; set; }
        public decimal PricePrescas { get; set; }
        public string Pozice { get; set; }
        public int IdNadrizeny { get; set; }
        public int IdPracovniSkupina { get; set; }
        public int IdRidiciStruktura { get; set; }
        public int IdProfese { get; set; }
        public int IdMistoPrace { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public decimal PriceMzda { get; set; }
        public DateTime CncServisDatum { get; set; }
        public decimal CncServisInterval { get; set; }
        public int CncServisIntervalUnit { get; set; }
        public decimal KoefSkutNakl { get; set; }
        public int GdprZbyva { get; set; }
        public int GdprAnonymizovano { get; set; }
        public int PouzeDochazka { get; set; }
        public int BezCasu { get; set; }
        public decimal PriceSatKoef { get; set; }
        public decimal PriceSunKoef { get; set; }
        public decimal KoefUkolMzdy { get; set; }
        public int KoefUkolMzdyType { get; set; }
        public decimal KoefUkolMzdy2 { get; set; }
        public int KoefUkolMzdy2Type { get; set; }
        public DateTime TsLastChange { get; set; }
        public DateTime TsCreated { get; set; }

        public virtual ICollection<Readdata> IdNavigation { get; set; }
    }
}
