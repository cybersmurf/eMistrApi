using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class ColumnsLog
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string QryName { get; set; }
        public DateTime DatumZmeny { get; set; }
        public string FieldName { get; set; }
        public string OriginalCaption { get; set; }
        public string ActualCaption { get; set; }
    }
}
