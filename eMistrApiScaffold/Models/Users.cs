using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int Acess { get; set; }
        public ulong Prv01 { get; set; }
        public ulong Set01 { get; set; }
        public ulong Prv02 { get; set; }
        public ulong Set02 { get; set; }
        public ulong Prv03 { get; set; }
        public ulong Set03 { get; set; }
        public ulong Prv04 { get; set; }
        public ulong Set04 { get; set; }
        public ulong Prv05 { get; set; }
        public ulong Set05 { get; set; }
        public ulong Prv06 { get; set; }
        public ulong Set06 { get; set; }
        public ulong Prv07 { get; set; }
        public ulong Set07 { get; set; }
        public ulong Prv08 { get; set; }
        public ulong Set08 { get; set; }
        public ulong Prv09 { get; set; }
        public ulong Set09 { get; set; }
        public ulong Prv10 { get; set; }
        public ulong Set10 { get; set; }
        public ulong Prv11 { get; set; }
        public ulong Set11 { get; set; }
        public int UseWorkerId { get; set; }
        public string VedouciSkupiny { get; set; }
        public string Mistr { get; set; }
        public string Stavy { get; set; }
        public ulong Prv12 { get; set; }
        public ulong Set12 { get; set; }
        public ulong Prv13 { get; set; }
        public ulong Set13 { get; set; }
        public ulong Prv14 { get; set; }
        public ulong Set14 { get; set; }
        public ulong Prv15 { get; set; }
        public ulong Set15 { get; set; }
        public ulong Prv16 { get; set; }
        public ulong Set16 { get; set; }
        public int GdprGroup { get; set; }
        public string Password2 { get; set; }
        public DateTime Password2change { get; set; }
        public int LoginCounter { get; set; }
        public int PristupSmReaddata { get; set; }
        public int PristupZakazky { get; set; }
        public DateTime TsLastChange { get; set; }
        public DateTime TsCreated { get; set; }
    }
}
