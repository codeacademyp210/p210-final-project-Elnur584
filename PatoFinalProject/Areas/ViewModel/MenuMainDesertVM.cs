using PatoFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatoFinalProject.Areas.ViewModel
{
    public class MenuMainDesertVM
    {
        public List<MenuMainDesert> menuMainDesertsList { get; set; }
        public MenuMainDesert menuMainDesertSingle { get; set; }
        public string Action { get; set; }
    }
}