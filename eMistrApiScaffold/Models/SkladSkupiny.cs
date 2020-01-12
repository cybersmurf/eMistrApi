using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class SkladSkupiny
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string User { get; set; }
        public int ParentId { get; set; }
        public string IdPohoda { get; set; }
        public string ExterniId { get; set; }
        public int OperationIdBatchout { get; set; }
    }
}
