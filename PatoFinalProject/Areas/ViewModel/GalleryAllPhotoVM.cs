using PatoFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatoFinalProject.Areas.ViewModel
{
    public class GalleryAllPhotoVM
    {
        public List<GalleryAllPhoto> galleryAllPhotosList { get; set; }
        public GalleryAllPhoto galleryAllPhotoSingle { get; set; }
        public string Action { get; set; }
    }
}