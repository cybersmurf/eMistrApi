using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class TechPostup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public int CasJednotky { get; set; }
    }
}
