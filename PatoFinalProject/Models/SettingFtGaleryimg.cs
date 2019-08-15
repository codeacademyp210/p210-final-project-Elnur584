using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PatoFinalProject.Models
{
    public class SettingFtGaleryimg
    {
        public int Id { get; set; }
        public string ImageNm { get; set; }
        public string ImageNm2 { get; set; }
        public string ImageNm3 { get; set; }
        public string ImageNm4 { get; set; }
        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        [Display(Name = "")]
        public HttpPostedFileBase ImgFile { get; set; }
    }
}