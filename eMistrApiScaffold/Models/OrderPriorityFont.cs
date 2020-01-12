using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class OrderPriorityFont
    {
        public int Id { get; set; }
        public int PrioritaId { get; set; }
        public int Size { get; set; }
        public string Pismo { get; set; }
        public int Underline { get; set; }
        public int Bold { get; set; }
        public int Italic { get; set; }
        public int Crossline { get; set; }
        public int ColorPen { get; set; }
        public int ColorBrush { get; set; }
    }
}
