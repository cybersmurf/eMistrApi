using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class Kraticka
    {
        public int Id { get; set; }
        public int MaterialId { get; set; }
        public int PrurezMin { get; set; }
        public int PrurezMax { get; set; }
        public int DelkaMin { get; set; }
        public int DelkaMax { get; set; }
        public decimal Norma { get; set; }
    }
}
