using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class PlanNaDen
    {
        public int IdPlanDen { get; set; }
        public int IdWorker { get; set; }
        public int IdMistoPrace { get; set; }
        public int IdTypSmeny { get; set; }
        public DateTime DenVKalendari { get; set; }
        public decimal WorkerKapacitaDen { get; set; }
        public int WorkerStav { get; set; }
    }
}
