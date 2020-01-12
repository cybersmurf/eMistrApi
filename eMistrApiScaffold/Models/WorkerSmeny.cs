using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class WorkerSmeny
    {
        public int Id { get; set; }
        public TimeSpan PoZacatek { get; set; }
        public TimeSpan PoKonec { get; set; }
        public decimal PoDoba { get; set; }
        public TimeSpan UtZacatek { get; set; }
        public TimeSpan UtKonec { get; set; }
        public decimal UtDoba { get; set; }
        public TimeSpan StZacatek { get; set; }
        public TimeSpan StKonec { get; set; }
        public decimal StDoba { get; set; }
        public TimeSpan CtZacatek { get; set; }
        public TimeSpan CtKonec { get; set; }
        public decimal CtDoba { get; set; }
        public TimeSpan PaZacatek { get; set; }
        public TimeSpan PaKonec { get; set; }
        public decimal PaDoba { get; set; }
        public TimeSpan SoZacatek { get; set; }
        public TimeSpan SoKonec { get; set; }
        public decimal SoDoba { get; set; }
        public TimeSpan NeZacatek { get; set; }
        public TimeSpan NeKonec { get; set; }
        public decimal NeDoba { get; set; }
        public int RoudWorkStart { get; set; }
        public int RoudWorkFinish { get; set; }
        public int AutoDelPrescasIfless { get; set; }
        public int AutoBreakDochazka { get; set; }
        public int AutoBreakIf { get; set; }
        public int PenalizaceIfMin { get; set; }
        public int PenalizaceMinut { get; set; }
        public int IgnoreBeforeWork { get; set; }
        public int UsePenalizace { get; set; }
        public string Nazev { get; set; }
        public TimeSpan Prestavka1od { get; set; }
        public TimeSpan Prestavka1do { get; set; }
        public TimeSpan Prestavka2od { get; set; }
        public TimeSpan Prestavka2do { get; set; }
        public TimeSpan Prestavka3od { get; set; }
        public TimeSpan Prestavka3do { get; set; }
        public int UpravitZacatek { get; set; }
        public int AutoBreakRepeat { get; set; }
    }
}
