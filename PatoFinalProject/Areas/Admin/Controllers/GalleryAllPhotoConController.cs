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
    public class GalleryAllPhotoConController : Controller
    {
        // GET: Admin/MenuDinnerImgCon
        PatoContext db = new PatoContext();

        public ActionResult Index()
        {
            GalleryAllPhotoVM model = new GalleryAllPhotoVM()
            {
                galleryAllPhotosList = db.galleryAllPhotos.ToList(),
                galleryAllPhotoSingle = null,
                Action = "Create"
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(GalleryAllPhoto galleryAllPhotoSingle)
        {
            if (galleryAllPhotoSingle.ImgFile.ContentLength > 0)
            {
                var fileNm = Path.GetFileName(galleryAllPhotoSingle.ImgFile.FileName);
                var saveArea = Path.Combine(Server.MapPath("~/Public/images"), fileNm);
                galleryAllPhotoSingle.ImgFile.SaveAs(saveArea);
                galleryAllPhotoSingle.Image = fileNm;
                db.galleryAllPhotos.Add(galleryAllPhotoSingle);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            GalleryAllPhotoVM model = new GalleryAllPhotoVM()
            {
                galleryAllPhotosList = db.galleryAllPhotos.ToList(),
                galleryAllPhotoSingle = db.galleryAllPhotos.FirstOrDefault(m => m.Id == id),
                Action = "Edit"
            };
            return View("Index", model);
        }
        [HttpPost]
        public ActionResult Edit(GalleryAllPhoto galleryAllPhotoSingle)
        {
            db.Entry(galleryAllPhotoSingle).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var model = db.galleryAllPhotos.FirstOrDefault(m => m.Id == id);
            db.galleryAllPhotos.Remove(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}