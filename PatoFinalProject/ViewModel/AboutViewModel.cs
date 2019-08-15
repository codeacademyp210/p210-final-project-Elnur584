using PatoFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatoFinalProject.ViewModel
{
    public class AboutViewModel
    {
        public DeliciousReceipes DeliciousReceipes { get; set; }
        public AboutRomanticRestaurant AboutRomanticRestaurants { get; set; }
        public List<AboutOurChef> AboutOurChefs { get; set; }
        public SpecialSignUp specialSignUpSingle { get; set; }
        public Settings Settings { get; set; }
        public List<SettingFtGaleryimg> settingFtGaleryimgs { get; set; }

    }
}