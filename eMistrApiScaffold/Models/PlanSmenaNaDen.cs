using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class PlanSmenaNaDen
    {
        public int IdPlanSmenaNaDen { get; set; }
        public int IdPlanSmena { get; set; }
        public int IdTypProvoz { get; set; }
        public int IdTypSmeny { get; set; }
        public int IdMistoPrace { get; set; }
        public DateTime DenVKalendari { get; set; }
        public decimal KapacitaNaDen { get; set; }
        public decimal KapacitaNaplnena { get; set; }
        public int Stav { get; set; }
    }
}
