using PatoFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatoFinalProject.Areas.ViewModel
{
    public class GalleryInteriorVM
    {
        public List<GalleryInteriorPhoto> galleryInteriorPhotosList { get; set; }
        public GalleryInteriorPhoto galleryInteriorPhotosingle { get; set; }
        public string Action { get; set; }
    }
}