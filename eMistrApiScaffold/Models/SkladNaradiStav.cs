using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class SkladNaradiStav
    {
        public int Id { get; set; }
        public int Poradi { get; set; }
        public string Name { get; set; }
        public string Tabulka { get; set; }
        public string Note { get; set; }
        public int Active { get; set; }
        public int GroupId { get; set; }
        public DateTime TimeStamp { get; set; }
        public DateTime Created { get; set; }
        public int ChangeItemCount { get; set; }
    }
}
