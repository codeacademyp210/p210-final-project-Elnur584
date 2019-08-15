using PatoFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatoFinalProject.Areas.ViewModel
{
    public class AboutChefVM
    {
        public List<AboutOurChef> aboutOurChefsList { get; set; }
        public AboutOurChef aboutOurChefSingle { get; set; }
        public string Action { get; set; }
    }
}