using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class Log
    {
        public int Id { get; set; }
        public string Ip { get; set; }
        public DateTime Date { get; set; }
        public string Note { get; set; }
        public string User { get; set; }
        public string Typ { get; set; }
        public string Keyword1 { get; set; }
        public string Keyword2 { get; set; }
        public string Udalost { get; set; }
        public string Verzevyron { get; set; }
    }
}
