using PatoFinalProject.DAL;
using PatoFinalProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PatoFinalProject.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
      
        public ActionResult Index()
        {
            using (PatoContext db = new PatoContext())
            {
                HomeViewModel model = new HomeViewModel();
                model.LatestBlogs = db.LatestBlogs.ToList();
                return View(model);
            }
                
        }
        public ActionResult Inbox()
        {
            return View();

        }
    }
}