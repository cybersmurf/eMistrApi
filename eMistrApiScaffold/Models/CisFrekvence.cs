using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class CisFrekvence
    {
        public int Id { get; set; }
        public int Kod { get; set; }
        public string Popis { get; set; }
        public string Zkratka { get; set; }
    }
}
