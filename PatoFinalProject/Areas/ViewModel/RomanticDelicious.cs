using PatoFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatoFinalProject.Areas.ViewModel
{
    public class RomanticDelicious
    {
        public List<RomanticDeliciousRed> romanticDeliciousReds { get; set; }
        public RomanticDeliciousRed romantic { get; set; }
        public string Action { get; set; }

    }
}