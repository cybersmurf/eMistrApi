using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class OrderFilter
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Cislo { get; set; }
        public string Nazev { get; set; }
        public string TextovePolozky { get; set; }
        public string Stavy { get; set; }
        public string Typy { get; set; }
        public string UseZadano { get; set; }
        public DateTime ZadanoDo { get; set; }
        public DateTime ZadanoOd { get; set; }
        public string PosouvatZadano { get; set; }
        public string UseDokonceni { get; set; }
        public DateTime DokonceniOd { get; set; }
        public DateTime DokonceniDo { get; set; }
        public string PosouvatDokonceni { get; set; }
        public DateTime Ulozeno { get; set; }
        public string UseZmenastavu { get; set; }
        public string PosouvatZmenustavu { get; set; }
        public DateTime ZmenastavuOd { get; set; }
        public DateTime ZmenastavuDo { get; set; }
        public string Zmenastavu { get; set; }
    }
}
