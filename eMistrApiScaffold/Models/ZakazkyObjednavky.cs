using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class ZakazkyObjednavky
    {
        public ulong Id { get; set; }
        public ulong PolozkaPrijateObjednavkyId { get; set; }
        public string OrderId { get; set; }
    }
}
