using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class SkladFormy
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
        public decimal MnozstviCyklus { get; set; }
        public decimal MaterialCyklus { get; set; }
        public int MaterialCyklusUnit { get; set; }
        public decimal ZbytkyCyklus { get; set; }
        public int ZbytkyCyklusUnit { get; set; }
        public int PocetCyklu { get; set; }
        public int PocetCykluUpozorneni { get; set; }
        public string Userindex { get; set; }
        public string Customer { get; set; }
        public int CustomerId { get; set; }
        public string ArticleNumber { get; set; }
        public decimal Hmotnost { get; set; }
        public string Rating { get; set; }
        public DateTime TsLastChange { get; set; }
        public DateTime TsCreated { get; set; }
    }
}
