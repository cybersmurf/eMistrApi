using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class GdprLogs
    {
        public int Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public string TableName { get; set; }
        public string FieldName { get; set; }
        public string Description { get; set; }
        public string Oldvalue { get; set; }
        public string Newvalue { get; set; }
        public string Username { get; set; }
    }
}
