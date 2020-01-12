using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class Pausal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BarId { get; set; }
        public ulong OperationId { get; set; }
        public TimeSpan Time { get; set; }
        public string User { get; set; }
    }
}
