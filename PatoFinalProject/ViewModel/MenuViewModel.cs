using PatoFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatoFinalProject.ViewModel
{
    public class MenuViewModel
    {
        public List<MenuDrinkStarers> MenuDrinkStarers { get; set; }
        public List<MenuMainDesert> MenuMainDeserts { get; set; }
        public List<MenuImgAreaFirst> MenuImgAreaFirsts { get; set; }
        public List<MenuImgAreaSecond> MenuImgAreaSeconds { get; set; }
        public List<MenuBottomImgAreaFirst> MenuBottomImgAreaFirsts { get; set; }
        public List<MenuBottomImgAreaSecond> MenuBottomImgAreaSeconds { get; set; }
        public SpecialSignUp specialSignUpSingle { get; set; }
        public Settings Settings { get; set; }
        public List<SettingFtGaleryimg> settingFtGaleryimgs { get; set; }
        public string Action { get; set; }
    }
}