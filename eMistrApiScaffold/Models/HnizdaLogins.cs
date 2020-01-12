using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class HnizdaLogins
    {
        public int Id { get; set; }
        public int IdHnizdo { get; set; }
        public int IdWorker { get; set; }
        public DateTime Prihlaseni { get; set; }
        public DateTime Odhlaseni { get; set; }
    }
}
