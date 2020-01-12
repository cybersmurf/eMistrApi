using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class SkladNaradi
    {
        public int Id { get; set; }
        public string BarId { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public DateTime Nakup { get; set; }
        public DateTime Servis { get; set; }
        public DateTime DelayServisDate { get; set; }
        public int DelayServisTime { get; set; }
        public int Stav { get; set; }
        public string User { get; set; }
        public int Odpracovano { get; set; }
        public decimal Cena { get; set; }
        public int Mnozstvi { get; set; }
        public int MnozstviInit { get; set; }
        public string Skupina { get; set; }
        public decimal Objednano { get; set; }
        public int Pocatecnistav { get; set; }
        public string VyrobniC { get; set; }
        public DateTime LastFinish { get; set; }
        public DateTime TerminZaruky { get; set; }
        public int GroupId { get; set; }
        public int DodavatelId { get; set; }
        public int TypNaradi { get; set; }
        public int UkonceniInterval { get; set; }
        public int StavKarty { get; set; }
        public decimal MnozstviLimit { get; set; }
        public int ZarukaDelka { get; set; }
    }
}
