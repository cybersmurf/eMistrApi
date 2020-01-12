﻿using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class SkladMaterial
    {
        public ulong Id { get; set; }
        public string BarId { get; set; }
        public string Name { get; set; }
        public decimal Count { get; set; }
        public int Unit { get; set; }
        public decimal Price { get; set; }
        public string Note { get; set; }
        public string User { get; set; }
        public int LimitCount { get; set; }
        public string IdPohoda { get; set; }
        public decimal SellPrice { get; set; }
        public decimal CountInit { get; set; }
        public decimal Koeficient { get; set; }
        public int TypMat { get; set; }
        public int SkladId { get; set; }
        public decimal Blokovano { get; set; }
        public decimal Planovano { get; set; }
        public decimal Objednano { get; set; }
        public decimal CoefUnit1 { get; set; }
        public decimal CoefUnit2 { get; set; }
        public decimal CoefUnit3 { get; set; }
        public decimal CoefUnit4 { get; set; }
        public decimal CoefUnit5 { get; set; }
        public decimal CoefUnit6 { get; set; }
        public decimal CoefUnit7 { get; set; }
        public decimal CoefUnit8 { get; set; }
        public decimal CoefUnit9 { get; set; }
        public decimal CoefUnit10 { get; set; }
        public decimal CoefUser1 { get; set; }
        public decimal CoefUser2 { get; set; }
        public string CoefUser1Name { get; set; }
        public string CoefUser2Name { get; set; }
        public int MaterialFromId { get; set; }
        public decimal AvgPrice { get; set; }
        public decimal CoefUnit11 { get; set; }
        public int SecondUnit { get; set; }
        public decimal Marze { get; set; }
        public string Ean { get; set; }
        public decimal CoefUnit12 { get; set; }
        public string Path { get; set; }
        public string Vykres { get; set; }
        public string Umisteni1 { get; set; }
        public string Text1 { get; set; }
        public string Text2 { get; set; }
        public string DilNa { get; set; }
        public decimal CoefUnit13 { get; set; }
        public decimal CoefUnit14 { get; set; }
        public decimal CoefUnit15 { get; set; }
        public decimal CoefUnit16 { get; set; }
        public decimal CoefUnit17 { get; set; }
        public decimal? CountSklad2 { get; set; }
        public decimal? CountSklad3 { get; set; }
        public decimal? CountSklad4 { get; set; }
        public decimal? CountSklad5 { get; set; }
        public decimal? CountSklad6 { get; set; }
        public decimal? CountSklad7 { get; set; }
        public decimal? CountSklad8 { get; set; }
        public string Tvar { get; set; }
        public decimal? Rozmer1 { get; set; }
        public decimal? Rozmer2 { get; set; }
        public decimal? Delka { get; set; }
        public decimal? CountSklad9 { get; set; }
        public decimal? CountSklad10 { get; set; }
        public decimal? CountSklad11 { get; set; }
        public decimal? CountSklad12 { get; set; }
        public decimal? CountSklad13 { get; set; }
        public decimal? CountSklad14 { get; set; }
        public decimal? CountSklad15 { get; set; }
        public decimal? CountSklad16 { get; set; }
        public decimal? CountSklad17 { get; set; }
        public decimal? CountSklad18 { get; set; }
        public decimal? CountSklad19 { get; set; }
        public decimal? CountSklad20 { get; set; }
        public string SablonaId { get; set; }
        public string Unirec { get; set; }
        public decimal CoefUnit18 { get; set; }
        public decimal CoefUnit19 { get; set; }
        public decimal CoefUnit20 { get; set; }
        public decimal VazenaCena { get; set; }
        public decimal HodnotaVazenaCena { get; set; }
        public string ExterniId { get; set; }
        public decimal CoefUnit21 { get; set; }
        public ulong DodavatelId { get; set; }
        public decimal? Rozmer3 { get; set; }
        public int TvarId { get; set; }
        public int IdMoneyAgenda { get; set; }
        public int ZbytkyMaterialId { get; set; }
        public decimal? ZbytkyKoeficient { get; set; }
        public decimal? Hmotnost { get; set; }
        public int Skryta { get; set; }
        public decimal CoefUnit22 { get; set; }
        public DateTime TsLastChange { get; set; }
        public DateTime TsCreated { get; set; }
    }
}