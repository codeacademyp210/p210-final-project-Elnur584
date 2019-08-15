using PatoFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatoFinalProject.ViewModel
{
    public class GalleryViewModel
    {
        public List<GalleryAllPhoto>  galleryAllPhotos{ get; set; }
        public List<GalleryInteriorPhoto> galleryInteriorPhotos { get; set; }
        public List<GalleryFoodPhoto> galleryFoodPhotos { get; set; }
        public List<GalleryEventPhoto> galleryEventPhotos { get; set; }
        public List<GalleryVipPhoto> galleryVipPhotos { get; set; }
        public SpecialSignUp specialSignUpSingle { get; set; }
        public Settings Settings { get; set; }
        public List<SettingFtGaleryimg> settingFtGaleryimgs { get; set; }
    }
}