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
    public class GalleryEventsConController : Controller
    {
        // GET: Admin/GalleryEventsCon
        PatoContext db = new PatoContext();

        public ActionResult Index()
        {
            GalleryEventsVM model = new GalleryEventsVM()
            {
                galleryEventPhotosList = db.galleryEventPhotos.ToList(),
                galleryEventSingle = null,
                Action = "Create"
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(GalleryEventPhoto galleryEventSingle)
        {
            if (galleryEventSingle.ImgFile.ContentLength > 0)
            {
                var fileNm = Path.GetFileName(galleryEventSingle.ImgFile.FileName);
                var saveArea = Path.Combine(Server.MapPath("~/Public/images"), fileNm);
                galleryEventSingle.ImgFile.SaveAs(saveArea);
                galleryEventSingle.Image = fileNm;
                db.galleryEventPhotos.Add(galleryEventSingle);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            GalleryEventsVM model = new GalleryEventsVM()
            {
                galleryEventPhotosList = db.galleryEventPhotos.ToList(),
                galleryEventSingle = db.galleryEventPhotos.FirstOrDefault(m => m.Id == id),
                Action = "Edit"
            };
            return View("Index", model);
        }
        [HttpPost]
        public ActionResult Edit(GalleryEventPhoto galleryEventSingle)
        {
            db.Entry(galleryEventSingle).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var model = db.galleryEventPhotos.FirstOrDefault(m => m.Id == id);
            db.galleryEventPhotos.Remove(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}