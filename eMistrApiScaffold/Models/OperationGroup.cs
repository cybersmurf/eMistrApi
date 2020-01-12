using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class OperationGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string User { get; set; }
        public string Cislo { get; set; }
        public string Zkratka { get; set; }
    }
}
