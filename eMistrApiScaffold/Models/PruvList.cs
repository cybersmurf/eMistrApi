using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class PruvList
    {
        public ulong Id { get; set; }
        public ulong WorkerId { get; set; }
        public ulong OperationId { get; set; }
        public string OrderId { get; set; }
        public DateTime Date { get; set; }
        public decimal Mnoz { get; set; }
        public decimal Zmetku { get; set; }
        public int Rucnizmena { get; set; }
        public string Note { get; set; }
        public DateTime Datum { get; set; }
    }
}
