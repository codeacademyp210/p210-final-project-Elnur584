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
    public class GalleryInteriorConController : Controller
    {
        // GET: Admin/GalleryInteriorCon
        PatoContext db = new PatoContext();

        public ActionResult Index()
        {
            GalleryInteriorVM model = new GalleryInteriorVM()
            {
                galleryInteriorPhotosList = db.galleryInteriorPhotos.ToList(),
                galleryInteriorPhotosingle = null,
                Action = "Create"
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(GalleryInteriorPhoto galleryInteriorPhotosingle)
        {
            if (galleryInteriorPhotosingle.ImgFile.ContentLength > 0)
            {
                var fileNm = Path.GetFileName(galleryInteriorPhotosingle.ImgFile.FileName);
                var saveArea = Path.Combine(Server.MapPath("~/Public/images"), fileNm);
                galleryInteriorPhotosingle.ImgFile.SaveAs(saveArea);
                galleryInteriorPhotosingle.Image = fileNm;
                db.galleryInteriorPhotos.Add(galleryInteriorPhotosingle);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            GalleryInteriorVM model = new GalleryInteriorVM()
            {
                galleryInteriorPhotosList = db.galleryInteriorPhotos.ToList(),
                galleryInteriorPhotosingle = db.galleryInteriorPhotos.FirstOrDefault(m => m.Id == id),
                Action = "Edit"
            };
            return View("Index", model);
        }
        [HttpPost]
        public ActionResult Edit(GalleryInteriorPhoto galleryInteriorPhotosingle)
        {
            db.Entry(galleryInteriorPhotosingle).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var model = db.galleryInteriorPhotos.FirstOrDefault(m => m.Id == id);
            db.galleryInteriorPhotos.Remove(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}