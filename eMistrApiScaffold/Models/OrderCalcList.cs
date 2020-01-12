using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class OrderCalcList
    {
        public string OrderId { get; set; }
        public DateTime? Date { get; set; }
        public string Zdroj { get; set; }
    }
}
