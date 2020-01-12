using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class ObjednavkyPrijatePolozky
    {
        public int Id { get; set; }
        public int ObjednavkaId { get; set; }
        public int MaterialId { get; set; }
        public decimal Kusu { get; set; }
        public decimal Price { get; set; }
        public decimal Unitprice { get; set; }
        public string Note { get; set; }
        public string Pozice { get; set; }
        public DateTime PozadoveneDatum { get; set; }
        public DateTime PotvrzeneDatum { get; set; }
        public decimal PotvrzenaCenaJednotka { get; set; }
        public decimal PotvrzenaCena { get; set; }
    }
}
