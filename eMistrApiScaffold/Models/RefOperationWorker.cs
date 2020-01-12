using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class RefOperationWorker
    {
        public int Id { get; set; }
        public int WorkerId { get; set; }
        public int OperationId { get; set; }
        public float WorkerCena { get; set; }
        public float OperationCena { get; set; }
    }
}
