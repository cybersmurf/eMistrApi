using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class System
    {
        public int Id { get; set; }
        public string Version { get; set; }
        public string TableVersion { get; set; }
        public string ProgramId { get; set; }
        public DateTime LastRepair { get; set; }
        public DateTime LastOptimize { get; set; }
        public int LimitSwTerm { get; set; }
        public DateTime LastBackup { get; set; }
        public int UpgradeLocktables { get; set; }
        public int LimitVmtTerm { get; set; }
        public int LimitSmtTerm { get; set; }
    }
}
