using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class ProhlidkyStroje
    {
        public int Id { get; set; }
        public int StrojId { get; set; }
        public DateTime Datum { get; set; }
        public int StavHodin { get; set; }
        public string Note { get; set; }
        public int TypId { get; set; }
        public int StrojTyp { get; set; }
    }
}
