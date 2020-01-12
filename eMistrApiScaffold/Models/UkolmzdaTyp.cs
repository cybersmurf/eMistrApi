using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class UkolmzdaTyp
    {
        public int Id { get; set; }
        public int TypVypoctu { get; set; }
        public int Poradi { get; set; }
        public string Nazev { get; set; }
        public string Popis { get; set; }
        public string Vzorec { get; set; }
        public int WP { get; set; }
        public int WkP { get; set; }
        public int PhP { get; set; }
        public int PjP { get; set; }
        public int OhP { get; set; }
        public int OjP { get; set; }
        public int StP { get; set; }
        public int Visible { get; set; }
        public int Readonly { get; set; }
        public int CallExternal { get; set; }
    }
}
