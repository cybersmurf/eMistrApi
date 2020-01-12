using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class OrderWorkPlan
    {
        public int Id { get; set; }
        public string OrderId { get; set; }
        public ulong OperationId { get; set; }
        public int WorkerId { get; set; }
        public int PlanTime { get; set; }
        public string User { get; set; }
    }
}
