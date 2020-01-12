using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class RefWorkerCnc
    {
        public int Id { get; set; }
        public int WorkerId { get; set; }
        public int CncId { get; set; }
    }
}
