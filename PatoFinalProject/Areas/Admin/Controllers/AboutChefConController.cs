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
    public class AboutChefConController : Controller
    {
        // GET: Admin/AboutChefCon
        PatoContext db = new PatoContext();
        
        public ActionResult Index()
        {
            AboutChefVM model = new AboutChefVM()
            {
                aboutOurChefsList = db.aboutOurChefs.ToList(),
                aboutOurChefSingle = null,
                Action = "Create"
            };


            return View(model);
        }
        [HttpPost]
        public ActionResult Create(AboutOurChef aboutOurChefSingle)
        {
            if (aboutOurChefSingle.ImgFile.ContentLength > 0)
            {
                var fileNm = Path.GetFileName(aboutOurChefSingle.ImgFile.FileName);
                var saveArea = Path.Combine(Server.MapPath("~/Public/images"), fileNm);
                aboutOurChefSingle.ImgFile.SaveAs(saveArea);
                aboutOurChefSingle.Image = fileNm;
                db.aboutOurChefs.Add(aboutOurChefSingle);
                db.SaveChanges();
            }
           
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            AboutChefVM model = new AboutChefVM()
            {
                aboutOurChefsList = db.aboutOurChefs.ToList(),
                aboutOurChefSingle = db.aboutOurChefs.FirstOrDefault(m => m.Id == id),
                Action = "Edit"
            };

            return View("Index", model);
        }

        [HttpPost]
        public ActionResult Edit(AboutOurChef aboutOurChefSingle)
        {

            db.Entry(aboutOurChefSingle).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var model = db.aboutOurChefs.FirstOrDefault(m => m.Id == id);
            db.aboutOurChefs.Remove(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}