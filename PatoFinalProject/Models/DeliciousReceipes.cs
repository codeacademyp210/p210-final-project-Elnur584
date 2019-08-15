﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PatoFinalProject.Models
{
    public class DeliciousReceipes
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Title2 { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        [Display(Name = "")]
        public HttpPostedFileBase ImgFile { get; set; }
    }
}