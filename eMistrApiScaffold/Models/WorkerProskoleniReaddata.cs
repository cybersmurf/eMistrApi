using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class WorkerProskoleniReaddata
    {
        public int Id { get; set; }
        public int WorkerId { get; set; }
        public int ProskoleniTyp { get; set; }
        public int ProskoleniUroven { get; set; }
        public DateTime? ProskoleniDatum { get; set; }
        public DateTime? ProskoleniDatumNasledujici { get; set; }
        public DateTime? Vlozeno { get; set; }
        public DateTime? Editovano { get; set; }
        public string Uzivatel { get; set; }
        public string Poznamka { get; set; }
        public int ProskoleniId { get; set; }
    }
}
