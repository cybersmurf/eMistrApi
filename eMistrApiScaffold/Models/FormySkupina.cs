using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class FormySkupina
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }
    }
}
