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
    public class MenuLunchRightConController : Controller
    {
        // GET: Admin/MenuLunchRightCon
        PatoContext db = new PatoContext();
        public ActionResult Index()
        {
            MenuLunchRightVM model = new MenuLunchRightVM()
            {
                menuImgAreaSecondsList = db.menuImgAreaSeconds.ToList(),
                MenuImgAreaSecondSingle = null,
                Action = "Create"
            };
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(MenuImgAreaSecond MenuImgAreaSecondSingle)
        {
            if (MenuImgAreaSecondSingle.ImgFile.ContentLength > 0)
            {
                var fileNm = Path.GetFileName(MenuImgAreaSecondSingle.ImgFile.FileName);
                var saveArea = Path.Combine(Server.MapPath("~/Public/images"), fileNm);
                MenuImgAreaSecondSingle.ImgFile.SaveAs(saveArea);
                MenuImgAreaSecondSingle.Image = fileNm;
                db.menuImgAreaSeconds.Add(MenuImgAreaSecondSingle);
                db.SaveChanges();
            }
           
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            MenuLunchRightVM model = new MenuLunchRightVM()
            {
                menuImgAreaSecondsList = db.menuImgAreaSeconds.ToList(),
                MenuImgAreaSecondSingle = db.menuImgAreaSeconds.FirstOrDefault(m=>m.Id == id),
                Action = "Edit"
            };
            return View("Index", model);
        }
        [HttpPost]
        public ActionResult Edit(MenuImgAreaSecond MenuImgAreaSecondSingle)
        {
            db.Entry(MenuImgAreaSecondSingle).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var model = db.menuImgAreaSeconds.FirstOrDefault(m => m.Id == id);
            db.menuImgAreaSeconds.Remove(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}