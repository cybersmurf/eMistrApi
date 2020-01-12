using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class PlanStandardniSmena
    {
        public int IdStandardniSmena { get; set; }
        public int IdPlanSmenaSkupina { get; set; }
        public int IdPlanSmena { get; set; }
        public int IdMistoPrace { get; set; }
        public int IdTypSmeny { get; set; }
        public int IdPracovniSkupina { get; set; }
        public int DenVTydnu { get; set; }
        public decimal FondHodin { get; set; }
    }
}
