using PatoFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatoFinalProject.Areas.ViewModel
{
    public class MenuDinnerImgRightVM
    {
        public List<MenuBottomImgAreaSecond> menuBottomImgAreaRightList { get; set; }
        public MenuBottomImgAreaSecond menuBottomImgAreaRightSingle { get; set; }
        public string Action { get; set; }
    }
}