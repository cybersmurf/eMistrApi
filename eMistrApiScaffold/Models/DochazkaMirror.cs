using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class DochazkaMirror
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public int Dovolena { get; set; }
        public int Nemoc { get; set; }
        public int Ostatni { get; set; }
        public int Svatek { get; set; }
        public int Propustka { get; set; }
        public int Odpracovano { get; set; }
        public int Fond { get; set; }
        public int Placeno { get; set; }
        public int Neodpracovano { get; set; }
        public int Prescas { get; set; }
        public int WorkerId { get; set; }
        public int RealOdprac { get; set; }
        public string Smena { get; set; }
        public int TypVypoctu { get; set; }
        public int OstatniKorekce { get; set; }
        public string Note { get; set; }
        public int Nahrvolno { get; set; }
        public int Ocr { get; set; }
        public int Prestavka { get; set; }
        public int Vikend { get; set; }
        public int Placvolno { get; set; }
        public int Absence { get; set; }
        public int SvatekNahr { get; set; }
        public int Prostoj { get; set; }
        public int NeplacVolno { get; set; }
        public int OstatniNahr { get; set; }
        public int Nocni { get; set; }
        public int SaldoPrescas { get; set; }
        public string Verze { get; set; }
        public DateTime? CasVypoctu { get; set; }
        public string User { get; set; }
    }
}
