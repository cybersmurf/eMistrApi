using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class DochazkaNote
    {
        public int Id { get; set; }
        public int WorkerId { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public string Note { get; set; }
    }
}
