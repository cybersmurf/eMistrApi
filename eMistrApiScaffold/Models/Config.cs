using System;
using System.Collections.Generic;

namespace eMistrApiScaffold.Models
{
    public partial class Config
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string DochazkaFormat { get; set; }
        public string DochazkaAutobreak { get; set; }
        public string DochazkaAutobreakPodmina { get; set; }
        public string PriceCalculate { get; set; }
    }
}
