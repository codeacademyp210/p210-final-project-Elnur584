using PatoFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatoFinalProject.Areas.ViewModel
{
    public class GalleryFoodVM
    {
        public List<GalleryFoodPhoto> galleryFoodPhotosList { get; set; }
        public GalleryFoodPhoto galleryFoodPhotoSingle { get; set; }
        public string Action { get; set; }
    }
}