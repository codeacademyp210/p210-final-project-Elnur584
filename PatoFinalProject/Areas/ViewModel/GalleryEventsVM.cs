using PatoFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatoFinalProject.Areas.ViewModel
{
    public class GalleryEventsVM
    {
        public List<GalleryEventPhoto> galleryEventPhotosList { get; set; }
        public GalleryEventPhoto galleryEventSingle { get; set; }
        public string Action { get; set; }
    }
}