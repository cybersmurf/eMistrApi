using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class Terminal
    {
        public int Id { get; set; }
        public string Ip { get; set; }
        public int? TypTerminalu { get; set; }
        public int? WorkerId { get; set; }
        public ulong PovolitPrijemky { get; set; }
        public ulong PovolitVydejky { get; set; }
        public ulong VytvaretZakazku { get; set; }
        public string SerialNumber { get; set; }
        public string Apikey { get; set; }
        public string Hashcode { get; set; }
        public string Note { get; set; }
        public string TerminalName { get; set; }
        public string BasicConfiguration { get; set; }
        public byte[] FullConfiguration { get; set; }
    }
}
