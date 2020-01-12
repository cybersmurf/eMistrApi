using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class Userlist
    {
        public string ComputerId { get; set; }
        public string User { get; set; }
        public string ComputerName { get; set; }
        public DateTime LoginTime { get; set; }
        public DateTime LastActivity { get; set; }
    }
}
