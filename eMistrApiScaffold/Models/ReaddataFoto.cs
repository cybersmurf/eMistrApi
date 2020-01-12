using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class ReaddataFoto
    {
        public int Id { get; set; }
        public ulong ReaddataId { get; set; }
        public string FotoPath { get; set; }
    }
}
