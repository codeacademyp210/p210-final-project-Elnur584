using PatoFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatoFinalProject.ViewModel
{
    public class HomeViewModel
    {
        public Settings Settings { get; set; }
        public ItalianResturant ıtalianResturant   { get; set; }
        public ReservationBT reservationBT { get; set; } 
        public List<RomanticDeliciousRed> RomanticDelicious { get; set; }
        public Video Video { get; set; }
       
        public List<LatestBlog> LatestBlogs { get; set; }
        public List<SettingFtGaleryimg> settingFtGaleryimgs { get; set; }
        public List<Slider> sliders { get; set; }
        public SpecialSignUp specialSignUpSingle { get; set; }

    }
}