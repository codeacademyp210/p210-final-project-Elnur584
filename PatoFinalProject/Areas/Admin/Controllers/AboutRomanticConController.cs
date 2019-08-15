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
    public class AboutRomanticConController : Controller
    {
        // GET: Admin/AboutRomanticCon
        PatoContext db = new PatoContext();
        [HttpGet]
        public ActionResult Index()
        {
            var AboutRomantic = db.aboutRomantics.FirstOrDefault() ?? new Models.AboutRomanticRestaurant();
            return View(AboutRomantic);
        }
        [HttpPost]
        public ActionResult Edit(AboutRomanticRestaurant aboutRomantic)
        {
            if (aboutRomantic.ImgFile.ContentLength > 0)
            {
                var fileNm = Path.GetFileName(aboutRomantic.ImgFile.FileName);
                var saveArea = Path.Combine(Server.MapPath("~/Public/images"), fileNm);
                aboutRomantic.ImgFile.SaveAs(saveArea);
                aboutRomantic.Image = fileNm;
                db.Entry(aboutRomantic).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            
            return RedirectToAction("Index");
        }
    }
}