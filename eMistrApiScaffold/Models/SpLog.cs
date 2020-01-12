using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class SpLog
    {
        public int Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Level { get; set; }
        public string SpName { get; set; }
        public string Message { get; set; }
    }
}
