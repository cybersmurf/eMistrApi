using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class VyrobniCalcMaterial
    {
        public ulong Id { get; set; }
        public int CalcId { get; set; }
        public int MaterialId { get; set; }
        public decimal Mnoz { get; set; }
    }
}
