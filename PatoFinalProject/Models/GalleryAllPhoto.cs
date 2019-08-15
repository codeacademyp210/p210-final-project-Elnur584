using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PatoFinalProject.Models
{
    public class GalleryAllPhoto
    {
        public int Id { get; set; }
        [DisplayName("Image Name")]
        public string Image { get; set; }
        [DisplayName("File Upload")]
        public string ImgPath { get; set; }
        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        [Display(Name = "")]
        public HttpPostedFileBase ImgFile { get; set; }
    }
}