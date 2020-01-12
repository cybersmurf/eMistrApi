using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class PlanWorker
    {
        public int IdWorker { get; set; }
        public int Dovolena { get; set; }
        public int Prescas { get; set; }
        public int IdMistoPrace { get; set; }
    }
}
