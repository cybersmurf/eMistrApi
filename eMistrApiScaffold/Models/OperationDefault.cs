using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class OperationDefault
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? OperationId { get; set; }
        public int? PausalId { get; set; }
    }
}
