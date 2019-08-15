using PatoFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatoFinalProject.Areas.ViewModel
{
    public class MenuLunchVM
    {
        public List<MenuImgAreaFirst> menuImgAreaFirstsList { get; set; }
        public MenuImgAreaFirst menuImgAreaFirstSingle { get; set; }
        public string Action { get; set; }
    }
}