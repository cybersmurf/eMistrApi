using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class Calendar
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public string Days { get; set; }
    }
}
