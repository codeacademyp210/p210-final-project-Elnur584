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
    public class GalleryVipGuestConController : Controller
    {
        // GET: Admin/GalleryVipGuestCon
        PatoContext db = new PatoContext();

        public ActionResult Index()
        {
            GalleryVipGuestVM model = new GalleryVipGuestVM()
            {
                galleryVipPhotosList = db.galleryVipPhotos.ToList(),
                galleryVipPhotoSingle = null,
                Action = "Create"
            };
            return View(model);
        }
        //[AcceptVerbs(HttpVerbs.Post)]
        //public ActionResult Index(GalleryVipPhoto galvippht)
        //{
        //    if (galvippht.ImgFile.ContentLength > 0)
        //    {
        //        var fileNm = Path.GetFileName(galvippht.ImgFile.FileName);
        //        var saveArea = Path.Combine(Server.MapPath("~/Images"), fileNm);
        //        galvippht.ImgFile.SaveAs(saveArea);
        //    }
        //    return RedirectToAction("Index");
        //}
        [HttpPost]
        public ActionResult Create(GalleryVipPhoto galleryVipPhotoSingle)
        {
            if (galleryVipPhotoSingle.ImgFile.ContentLength > 0)
            {
                var fileNm = Path.GetFileName(galleryVipPhotoSingle.ImgFile.FileName);
                var saveArea = Path.Combine(Server.MapPath("~/Public/images"), fileNm);
                galleryVipPhotoSingle.ImgFile.SaveAs(saveArea);
                galleryVipPhotoSingle.Image = fileNm;
                db.galleryVipPhotos.Add(galleryVipPhotoSingle);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            GalleryVipGuestVM model = new GalleryVipGuestVM()
            {
                galleryVipPhotosList = db.galleryVipPhotos.ToList(),
                galleryVipPhotoSingle = db.galleryVipPhotos.FirstOrDefault(m => m.Id == id),
                Action = "Edit"
            };
            return View("Index", model);
        }
        [HttpPost]
        public ActionResult Edit(GalleryVipPhoto galleryVipPhotoSingle)
        {
            db.Entry(galleryVipPhotoSingle).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var model = db.galleryVipPhotos.FirstOrDefault(m => m.Id == id);
            db.galleryVipPhotos.Remove(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}