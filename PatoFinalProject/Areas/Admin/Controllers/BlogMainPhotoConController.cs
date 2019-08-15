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
    public class BlogMainPhotoConController : Controller
    {
        // GET: Admin/BlogMainPhotoCon
        PatoContext db = new PatoContext();

        public ActionResult Index()
        {
            BlogMainPhotoVM model = new BlogMainPhotoVM()
            {
                blogPhotoAreasList = db.blogPhotoAreas.ToList(),
                blogPhotoAreaSingle = null,
                Action = "Create"
            };


            return View(model);
        }
        [HttpPost]
        public ActionResult Create(BlogPhotoArea blogPhotoAreaSingle)
        {
            if (blogPhotoAreaSingle.ImgFile.ContentLength > 0)
            {
                var fileNm = Path.GetFileName(blogPhotoAreaSingle.ImgFile.FileName);
                var saveArea = Path.Combine(Server.MapPath("~/Public/images"), fileNm);
                blogPhotoAreaSingle.ImgFile.SaveAs(saveArea);
                blogPhotoAreaSingle.Image = fileNm;
                db.blogPhotoAreas.Add(blogPhotoAreaSingle);
                db.SaveChanges();
            }
            
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            BlogMainPhotoVM model = new BlogMainPhotoVM()
            {
                blogPhotoAreasList = db.blogPhotoAreas.ToList(),
                blogPhotoAreaSingle = db.blogPhotoAreas.FirstOrDefault(m => m.Id == id),
                Action = "Edit"
            };

            return View("Index", model);
        }

        [HttpPost]
        public ActionResult Edit(BlogPhotoArea blogPhotoAreaSingle)
        {

            db.Entry(blogPhotoAreaSingle).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var model = db.blogPhotoAreas.FirstOrDefault(m => m.Id == id);
            db.blogPhotoAreas.Remove(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}