using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class Schedulerresource
    {
        public ulong ResourceId { get; set; }
        public int ResourceColor { get; set; }
        public string ResourceName { get; set; }
        public decimal Fond { get; set; }
        public TimeSpan PoStart { get; set; }
        public TimeSpan PoFinish { get; set; }
        public TimeSpan UtStart { get; set; }
        public TimeSpan UtFinish { get; set; }
        public TimeSpan StStart { get; set; }
        public TimeSpan StFinish { get; set; }
        public TimeSpan CtStart { get; set; }
        public TimeSpan CtFinish { get; set; }
        public TimeSpan PaStart { get; set; }
        public TimeSpan PaFinish { get; set; }
        public TimeSpan SoStart { get; set; }
        public TimeSpan SoFinish { get; set; }
        public TimeSpan NeStart { get; set; }
        public TimeSpan NeFinish { get; set; }
    }
}
