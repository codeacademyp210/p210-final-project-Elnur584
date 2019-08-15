using PatoFinalProject.Areas.ViewModel;
using PatoFinalProject.DAL;
using PatoFinalProject.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PatoFinalProject.Areas.Admin.Controllers
{
    public class ItalianRestaurantConController : Controller
    {
        // GET: Admin/ItalianRestaurantCon
        PatoContext db = new PatoContext();

        public ActionResult Index()
        {          
          var  ıtalianResturantSingle = db.ItalianResturants.FirstOrDefault() ?? new ItalianResturant();
           return View(ıtalianResturantSingle);          
        }
    
        [HttpPost]
        public ActionResult Edit(ItalianResturant ıtalianResturant)
        {
            if (ıtalianResturant.ImgFile.ContentLength > 0)
            {
                var fileNm = Path.GetFileName(ıtalianResturant.ImgFile.FileName);
                var saveArea = Path.Combine(Server.MapPath("~/Public/images"), fileNm);
                ıtalianResturant.ImgFile.SaveAs(saveArea);
                ıtalianResturant.ItalianRestaurantimg = fileNm;
                db.Entry(ıtalianResturant).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            
                return RedirectToAction("Index");
            
        }

      
    }
}