using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class Schedulertable
    {
        public ulong Id { get; set; }
        public int? LabelColor { get; set; }
        public string Caption { get; set; }
        public int? EventType { get; set; }
        public DateTime Finish { get; set; }
        public string Location { get; set; }
        public int? Options { get; set; }
        public int? ResourceId { get; set; }
        public DateTime Start { get; set; }
        public int? State { get; set; }
        public string OrderId { get; set; }
        public string OperationId { get; set; }
        public string Message { get; set; }
        public int? CasNaKus { get; set; }
        public decimal? PlanKs { get; set; }
        public int? PlanCas { get; set; }
        public ulong ReaddataId { get; set; }
        public string WorkerId { get; set; }
        public int? LabelColor2 { get; set; }
        public int? OdpracCas { get; set; }
        public int Vyteznost { get; set; }
        public int? Zaplanovano { get; set; }
        public int? LabelColor3 { get; set; }
        public int? TypKolize { get; set; }
        public int? LabelColor4 { get; set; }
    }
}
