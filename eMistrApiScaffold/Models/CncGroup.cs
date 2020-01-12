using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class CncGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string User { get; set; }
        public string Creator { get; set; }
    }
}
