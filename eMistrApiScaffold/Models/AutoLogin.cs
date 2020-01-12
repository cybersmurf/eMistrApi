using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class AutoLogin
    {
        public int Id { get; set; }
        public string Pc { get; set; }
        public string Login { get; set; }
        public string Pass { get; set; }
    }
}
