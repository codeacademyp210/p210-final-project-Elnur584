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
    public class GalleryFoodConController : Controller
    {
        // GET: Admin/GalleryFoodCon
        PatoContext db = new PatoContext();

        public ActionResult Index()
        {
            GalleryFoodVM model = new GalleryFoodVM()
            {
                galleryFoodPhotosList = db.galleryFoodPhotos.ToList(),
                galleryFoodPhotoSingle = null,
                Action = "Create"
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(GalleryFoodPhoto galleryFoodPhotoSingle)
        {
            if (galleryFoodPhotoSingle.ImgFile.ContentLength > 0)
            {
                var fileNm = Path.GetFileName(galleryFoodPhotoSingle.ImgFile.FileName);
                var saveArea = Path.Combine(Server.MapPath("~/Public/images"), fileNm);
                galleryFoodPhotoSingle.ImgFile.SaveAs(saveArea);
                galleryFoodPhotoSingle.Image = fileNm;
                db.galleryFoodPhotos.Add(galleryFoodPhotoSingle);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            GalleryFoodVM model = new GalleryFoodVM()
            {
                galleryFoodPhotosList = db.galleryFoodPhotos.ToList(),
                galleryFoodPhotoSingle = db.galleryFoodPhotos.FirstOrDefault(m => m.Id == id),
                Action = "Edit"
            };
            return View("Index", model);
        }
        [HttpPost]
        public ActionResult Edit(GalleryFoodPhoto galleryFoodPhotoSingle)
        {
            db.Entry(galleryFoodPhotoSingle).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var model = db.galleryFoodPhotos.FirstOrDefault(m => m.Id == id);
            db.galleryFoodPhotos.Remove(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}