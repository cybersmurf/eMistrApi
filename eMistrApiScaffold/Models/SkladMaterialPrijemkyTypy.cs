using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class SkladMaterialPrijemkyTypy
    {
        public int Id { get; set; }
        public string Zkratka { get; set; }
        public string Popis { get; set; }
        public string ZkratkaExport { get; set; }
        public int IdSkladPohyb { get; set; }
    }
}
