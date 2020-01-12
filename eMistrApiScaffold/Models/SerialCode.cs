using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class SerialCode
    {
        public ulong Id { get; set; }
        public string BarId { get; set; }
        public string OrderId { get; set; }
        public string Note { get; set; }
        public string Oznaceni { get; set; }
        public int Radek { get; set; }
    }
}
