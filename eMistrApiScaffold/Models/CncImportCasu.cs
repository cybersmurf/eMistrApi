using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class CncImportCasu
    {
        public int Id { get; set; }
        public int CncId { get; set; }
        public string CncName { get; set; }
        public string OrderId { get; set; }
        public int OperationId { get; set; }
        public int WorkerId { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public decimal Mnozstvi { get; set; }
        public string Note { get; set; }
        public int Processed { get; set; }
        public int Imported { get; set; }
        public DateTime? ImportedDatetime { get; set; }
    }
}
