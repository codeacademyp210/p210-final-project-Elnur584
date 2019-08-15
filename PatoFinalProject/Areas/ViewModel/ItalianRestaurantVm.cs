using PatoFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatoFinalProject.Areas.ViewModel
{
    public class ItalianRestaurantVm
    {
        public List<ItalianResturant> ital { get; set; }
        public ItalianResturant ıtalianResturantSingle { get; set; }
        public string Action { get; set; }
    }
}