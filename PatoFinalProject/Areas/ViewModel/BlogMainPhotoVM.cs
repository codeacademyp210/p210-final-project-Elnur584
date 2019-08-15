using PatoFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatoFinalProject.Areas.ViewModel
{
    public class BlogMainPhotoVM
    {
        public List<BlogPhotoArea> blogPhotoAreasList { get; set; }
        public BlogPhotoArea blogPhotoAreaSingle { get; set; }
        public string Action { get; set; }
    }
}