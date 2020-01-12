using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class PlanSmena
    {
        public int IdPlanSmena { get; set; }
        public int IdMistoPrace { get; set; }
        public int IdTypSmeny { get; set; }
        public int IdTypProvoz { get; set; }
    }
}
