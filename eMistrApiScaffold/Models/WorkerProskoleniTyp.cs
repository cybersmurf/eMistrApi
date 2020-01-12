using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class WorkerProskoleniTyp
    {
        public int Id { get; set; }
        public string Nazev { get; set; }
        public int PocetUrovni { get; set; }
        public int ProskoleniInterval { get; set; }
        public string Poznamka { get; set; }
        public int ProskoleniDruh { get; set; }
        public string DokumentyCesta { get; set; }
        public int Postupne { get; set; }
        public int IntervalJednotka { get; set; }
        public string SkolitelNazev { get; set; }
        public int SkolitelInfo { get; set; }
        public string SkolitelEmail { get; set; }
        public int WorkerId { get; set; }
        public int UserId { get; set; }
    }
}
