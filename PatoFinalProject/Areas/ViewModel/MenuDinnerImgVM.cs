using PatoFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatoFinalProject.Areas.ViewModel
{
    public class MenuDinnerImgVM
    {
        public List<MenuBottomImgAreaFirst> menuBottomImgAreaFirstsList { get; set; }
        public MenuBottomImgAreaFirst MenuBottomImgAreaFirstSingle { get; set; }
        public string Action { get; set; }
    }
}