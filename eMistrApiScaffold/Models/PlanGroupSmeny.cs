using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class PlanGroupSmeny
    {
        public int IdStandardniSmena { get; set; }
        public int IdSmena { get; set; }
        public int IdDen { get; set; }
        public int MistoPrace { get; set; }
        public int TypSmeny { get; set; }
        public int IdPlanSmenaSkupina { get; set; }
        public int IdPlanSmena { get; set; }
        public int IdMistoPrace { get; set; }
        public int IdTypSmeny { get; set; }
        public int IdPracovniSkupina { get; set; }
    }
}
