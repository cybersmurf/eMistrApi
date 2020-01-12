using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class SkladFormyReaddata
    {
        public int Id { get; set; }
        public int FormaId { get; set; }
        public int PohybId { get; set; }
        public int WorkerId { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public string Note { get; set; }
        public int Calculated { get; set; }
        public string User { get; set; }
        public int Count { get; set; }
        public int StavSkladu { get; set; }
        public int IsActual { get; set; }
        public int PolozkaObjednavkyId { get; set; }
        public decimal Castka { get; set; }
        public DateTime TsLastChange { get; set; }
        public DateTime TsCreated { get; set; }
    }
}
