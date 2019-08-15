using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PatoFinalProject.Models
{
    public class Video
    {
        public int Id { get; set; }
        public string VideoNm { get; set; }
        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        [Display(Name = "")]
        public HttpPostedFileBase ImgFile { get; set; }
    }
}