using PatoFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatoFinalProject.Areas.ViewModel
{
    public class MenuLunchRightVM
    {
        public List<MenuImgAreaSecond> menuImgAreaSecondsList { get; set; }
        public MenuImgAreaSecond MenuImgAreaSecondSingle { get; set; }
        public string Action { get; set; }
    }
}