using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class OrderStav
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string User { get; set; }
        public string GroupName { get; set; }
        public int Poradi { get; set; }
        public ulong ChangeOperationId { get; set; }
        public string Cislo { get; set; }
        public int PocitatPlan { get; set; }
        public int InPrint { get; set; }
        public int Prepocitavat { get; set; }
        public int BlokaceMat { get; set; }
        public int BarevneOznaceni { get; set; }
        public int Barva { get; set; }
        public int StavVyroba { get; set; }
        public int FinalStatus { get; set; }
    }
}
