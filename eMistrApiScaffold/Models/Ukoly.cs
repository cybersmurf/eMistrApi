using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class Ukoly
    {
        public int Id { get; set; }
        public string Nazev { get; set; }
        public DateTime Termin { get; set; }
        public int ResitelId { get; set; }
        public int ZadavatelId { get; set; }
        public string Popis { get; set; }
        public string Reakce { get; set; }
        public int StavId { get; set; }
        public int OpakovaniId { get; set; }
        public int OpakovaniInterval { get; set; }
        public string OpakovaniParam1 { get; set; }
        public int PodminkaId { get; set; }
        public string PodminkaParam1 { get; set; }
        public string PodminkaParam2 { get; set; }
        public string PodminkaParam3 { get; set; }
        public DateTime Zmena { get; set; }
    }
}
