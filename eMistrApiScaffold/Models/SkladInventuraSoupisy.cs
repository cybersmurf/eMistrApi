using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class SkladInventuraSoupisy
    {
        public int Id { get; set; }
        public int IdInventura { get; set; }
        public int MaterialId { get; set; }
        public decimal Mnozstvi { get; set; }
        public decimal CenaMj { get; set; }
    }
}
