using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class WorkerProskoleniDruh
    {
        public int Id { get; set; }
        public string Nazev { get; set; }
        public string Zkratka { get; set; }
        public string Poznamka { get; set; }
        public int Druh { get; set; }
    }
}
