using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class GdprSettings
    {
        public int Id { get; set; }
        public int Aktivni { get; set; }
        public int DnyKeepZakaznik { get; set; }
        public int DnyKeepZamestnanec { get; set; }
        public int DnyKeepAuditlog { get; set; }
        public int DnyKeepSystemlog { get; set; }
        public int DnyKeepPrintlog { get; set; }
        public int DnyKeepOtherlogs { get; set; }
        public int ZablokPrihlas { get; set; }
        public int ZablokPrihlasPocet { get; set; }
        public int ZablokPrihlasMail { get; set; }
        public string ZablokPrihlasServer { get; set; }
        public string ZablokPrihlasUser { get; set; }
        public string ZablokPrihlasPassword { get; set; }
        public int HesloVyzadovatMinDelku { get; set; }
        public int HesloMinDelka { get; set; }
        public int HesloJineNezUser { get; set; }
    }
}
