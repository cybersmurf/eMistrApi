using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class SkladNaradiPohyb
    {
        public int Id { get; set; }
        public string BarId { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public int TypPohybu { get; set; }
        public string User { get; set; }
        public int StavId { get; set; }
        public int AutoWrite { get; set; }
        public int StavChange { get; set; }
        public int NaradiType { get; set; }
    }
}
