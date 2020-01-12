using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class SwtermRozdel
    {
        public int Id { get; set; }
        public ulong UserId { get; set; }
        public string OrderId { get; set; }
        public ulong OperationId { get; set; }
        public TimeSpan Cas { get; set; }
        public decimal Procent { get; set; }
        public DateTime Start { get; set; }
        public decimal Mnoz { get; set; }
        public decimal UkonMzda { get; set; }
    }
}
