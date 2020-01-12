using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class CidlaReaddata
    {
        public int Id { get; set; }
        public DateTime Cas { get; set; }
        public int WorkerId { get; set; }
        public int CidloId { get; set; }
        public string Note { get; set; }
        public DateTime TsLastChange { get; set; }
        public DateTime TsCreated { get; set; }
    }
}
