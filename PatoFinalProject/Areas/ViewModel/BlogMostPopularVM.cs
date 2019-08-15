using PatoFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatoFinalProject.Areas.ViewModel
{
    public class BlogMostPopularVM
    {
        public List<BlogMostPopular> blogMostPopularsList { get; set; }
        public BlogMostPopular blogMostPopularSingle { get; set; }
        public string Action { get; set; }
    }
}