using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class PlanMistoPrace
    {
        public int IdMistoPrace { get; set; }
        public string Popis { get; set; }
        public int MaMitPlan { get; set; }
    }
}
