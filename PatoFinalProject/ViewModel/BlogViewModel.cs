using PatoFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatoFinalProject.ViewModel
{
    public class BlogViewModel
    {
        public List<BlogPhotoArea> BlogPhotoAreas { get; set; }
        public List<BlogMostPopular> BlogMostPopulars { get; set; }
        public Settings Settings { get; set; }
        public List<SettingFtGaleryimg> settingFtGaleryimgs { get; set; }
    }
}