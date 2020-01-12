using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class ServisTyp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AgendaId { get; set; }
    }
}
