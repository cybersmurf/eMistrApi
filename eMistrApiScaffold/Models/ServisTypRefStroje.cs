using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class ServisTypRefStroje
    {
        public int Id { get; set; }
        public int StrojId { get; set; }
        public int StrojTyp { get; set; }
        public int TypId { get; set; }
        public int OperationId { get; set; }
        public int ServisIntervalCas { get; set; }
        public int ServisIntervalMj { get; set; }
        public int ServisIntervalTyp { get; set; }
        public int ServisIntervalObdobi { get; set; }
        public int ServisIntervalObdobiTyp { get; set; }
        public int ServisOperationId { get; set; }
    }
}
