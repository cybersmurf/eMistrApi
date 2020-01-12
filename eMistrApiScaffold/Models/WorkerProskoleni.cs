using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class WorkerProskoleni
    {
        public int Id { get; set; }
        public int IdTypProskoleni { get; set; }
        public DateTime? ProbehloDne { get; set; }
        public DateTime? PlatiDo { get; set; }
        public string DokumentyCesta { get; set; }
        public string Poznamka { get; set; }
        public int Uroven { get; set; }
    }
}
