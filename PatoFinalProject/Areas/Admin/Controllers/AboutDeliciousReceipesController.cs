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
    public class AboutDeliciousReceipesController : Controller
    {
        // GET: Admin/AboutDeliciousReceipes
        PatoContext db = new PatoContext();
        [HttpGet]
        public ActionResult Index()
        {
            var aboutreceipe = db.DeliciousReceipes.FirstOrDefault() ?? new Models.DeliciousReceipes();
            return View(aboutreceipe);
        }
        [HttpPost]
        public ActionResult Edit(DeliciousReceipes receipes)
        {
            if (receipes.ImgFile.ContentLength > 0)
            {
                var fileNm = Path.GetFileName(receipes.ImgFile.FileName);
                var saveArea = Path.Combine(Server.MapPath("~/Public/images"), fileNm);
                receipes.ImgFile.SaveAs(saveArea);
                receipes.Image = fileNm;
                db.Entry(receipes).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
           
            return RedirectToAction("Index");
        }
    }
}