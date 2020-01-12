using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class PlanSmenaSkupina
    {
        public int IdPlanSmenaSkupina { get; set; }
        public int IdPlanSmena { get; set; }
        public int IdMistoPrace { get; set; }
        public int IdTypSmeny { get; set; }
        public int IdPracovniSkupina { get; set; }
    }
}
