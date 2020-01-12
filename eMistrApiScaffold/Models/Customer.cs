using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class Customer
    {
        public ulong Id { get; set; }
        public string Name { get; set; }
        public string BarId { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Mobile { get; set; }
        public string Note { get; set; }
        public string User { get; set; }
        public string FakAdress { get; set; }
        public string FakPsc { get; set; }
        public string FakMesto { get; set; }
        public string Ico { get; set; }
        public string Dic { get; set; }
        public string Osoba { get; set; }
        public string Ucet { get; set; }
        public string Banka { get; set; }
        public string Email { get; set; }
        public string Web { get; set; }
        public int Typ { get; set; }
        public string DodPsc { get; set; }
        public string DodMesto { get; set; }
        public string ExterniId { get; set; }
        public int? BarvaPlanu { get; set; }
        public string DodOsoba { get; set; }
        public string DodStat { get; set; }
        public string FakFirma { get; set; }
        public string FakOsoba { get; set; }
        public string DodFirma { get; set; }
        public string FakOddeleni { get; set; }
        public string DodOddeleni { get; set; }
        public string FakPhone { get; set; }
        public string FakEmail { get; set; }
        public string FakStat { get; set; }
        public int EmailOdesilat { get; set; }
        public int SplatnostDni { get; set; }
        public string Doprava { get; set; }
        public string Platba { get; set; }
        public string Dorucenifaktury { get; set; }
        public string Forma { get; set; }
        public int GdprZbyva { get; set; }
        public int GdprAnonymizovano { get; set; }
        public int PrimaDodaciAdresa { get; set; }
        public string Icdph { get; set; }
        public int Oblast { get; set; }
        public DateTime TsLastChange { get; set; }
        public DateTime TsCreated { get; set; }
    }
}
