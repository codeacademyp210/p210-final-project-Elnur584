
using PatoFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatoFinalProject.Areas.ViewModel
{
    public class LatestBlogVM
    {
        public List<LatestBlog> latestBlogsListVm { get; set; }
        public LatestBlog LatestBlogsingle { get; set; }
        public string Action { get; set; }
    }
}