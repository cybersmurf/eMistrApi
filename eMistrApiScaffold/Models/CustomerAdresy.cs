using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class CustomerAdresy
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int CustomerIdAddressId { get; set; }
        public string DodOsoba { get; set; }
        public string DodUlice { get; set; }
        public string DodMesto { get; set; }
        public string DodPsc { get; set; }
        public string DodEmail { get; set; }
        public string DodTelefon { get; set; }
        public string DodMobil { get; set; }
        public string DodFax { get; set; }
        public string DodNote { get; set; }
    }
}
