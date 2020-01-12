using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class CustomerOsoby
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Poznamka { get; set; }
        public int? Vychozi { get; set; }
        public int? Hierarchie { get; set; }
        public string ExterniId { get; set; }
    }
}
