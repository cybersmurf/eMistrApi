using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class CustomerUdalosti
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int Typ { get; set; }
        public DateTime? Datum { get; set; }
        public string Predmet { get; set; }
        public string Popis { get; set; }
        public string OrderId { get; set; }
    }
}
