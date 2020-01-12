using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class Kurz
    {
        public int Id { get; set; }
        public decimal Kurz1 { get; set; }
        public DateTime Start { get; set; }
        public string User { get; set; }
        public string Zkratka { get; set; }
    }
}
