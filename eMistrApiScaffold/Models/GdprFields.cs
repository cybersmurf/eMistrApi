using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class GdprFields
    {
        public int Id { get; set; }
        public string TableName { get; set; }
        public string FieldName { get; set; }
        public string Description { get; set; }
        public int? Selected { get; set; }
    }
}
