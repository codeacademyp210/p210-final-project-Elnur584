using PatoFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatoFinalProject.Areas.ViewModel
{
    public class MenuDrinkStarersVM
    {
        public List<MenuDrinkStarers> menuDrinkStarersList { get; set; }
        public MenuDrinkStarers menuDrinkStarersSingle { get; set; }
        public string Action { get; set; }
    }
}