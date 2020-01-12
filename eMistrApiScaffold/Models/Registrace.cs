using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class Registrace
    {
        public int Id { get; set; }
        public byte[] Cnt { get; set; }
        public byte[] Data { get; set; }
        public string Hwnumber { get; set; }
    }
}
