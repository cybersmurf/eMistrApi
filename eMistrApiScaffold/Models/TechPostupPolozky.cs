using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class TechPostupPolozky
    {
        public int Id { get; set; }
        public ulong PostupId { get; set; }
        public ulong OperationId { get; set; }
        public decimal Mnozstvi { get; set; }
    }
}
