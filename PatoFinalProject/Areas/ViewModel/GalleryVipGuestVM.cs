using PatoFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatoFinalProject.Areas.ViewModel
{
    public class GalleryVipGuestVM
    {
        public List<GalleryVipPhoto> galleryVipPhotosList { get; set; }
        public GalleryVipPhoto galleryVipPhotoSingle { get; set; }
        public string Action { get; set; }
    }
}