using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class SpSettings
    {
        public int Id { get; set; }
        public string SpName { get; set; }
        public int? Enabled { get; set; }
        public string LogLevel { get; set; }
        public int? Locked { get; set; }
        public DateTime LockedTimestamp { get; set; }
        public string SpAlias { get; set; }
        public int Visible { get; set; }
    }
}
