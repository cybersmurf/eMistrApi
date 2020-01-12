using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class ObjednavkyPrijate
    {
        public int Id { get; set; }
        public string BarId { get; set; }
        public string Note { get; set; }
        public DateTime Vystaveno { get; set; }
        public string User { get; set; }
        public string Name { get; set; }
        public int CustomerId { get; set; }
        public DateTime Dodat { get; set; }
        public int StavDokladu { get; set; }
    }
}
