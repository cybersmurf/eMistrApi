using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class FormCaptionHook
    {
        public int Id { get; set; }
        public string FormName { get; set; }
        public string ComponentType { get; set; }
        public string ComponentName { get; set; }
        public string ComponentProperty { get; set; }
        public string Value { get; set; }
        public string Language { get; set; }
    }
}
