using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class Reader
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Code { get; set; }
        public int Processed { get; set; }
    }
}
