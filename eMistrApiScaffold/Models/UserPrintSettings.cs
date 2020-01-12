using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class UserPrintSettings
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string TsName { get; set; }
        public string PrinterName { get; set; }
    }
}
