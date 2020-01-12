using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class SkladFormyPohyb
    {
        public int Id { get; set; }
        public string BarId { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public int TypPohybu { get; set; }
        public string User { get; set; }
    }
}
