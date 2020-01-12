using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class Datum
    {
        public int Id { get; set; }
        public DateTime Datum1 { get; set; }
        public string Pc { get; set; }
        public int WorkerId { get; set; }
    }
}
