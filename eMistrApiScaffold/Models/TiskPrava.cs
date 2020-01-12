using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class TiskPrava
    {
        public int Id { get; set; }
        public int TiskId { get; set; }
        public int UserId { get; set; }
        public int WorkerId { get; set; }
        public int GroupId { get; set; }
        public int ProfeseId { get; set; }
        public string Obecne { get; set; }
        public int Stav { get; set; }
    }
}
