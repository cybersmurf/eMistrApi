using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class SkladMaterialDodavatele
    {
        public int Id { get; set; }
        public int DodavatelId { get; set; }
        public int MaterialId { get; set; }
        public decimal Cena { get; set; }
        public string KodObjednaci { get; set; }
        public string TextObjednaci { get; set; }
        public string Poznamka { get; set; }
        public decimal Cena1 { get; set; }
        public decimal LimitMnozstvi1 { get; set; }
        public decimal Cena2 { get; set; }
        public decimal LimitMnozstvi2 { get; set; }
    }
}
