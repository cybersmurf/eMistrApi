using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class UzavreniZakazek
    {
        public ulong Id { get; set; }
        public string OrderIdFrom { get; set; }
        public string OrderIdTo { get; set; }
        public ulong OperationId { get; set; }
        public decimal Kusu { get; set; }
        public DateTime Prevedeno { get; set; }
        public DateTime KeDni { get; set; }
        public string User { get; set; }
    }
}
