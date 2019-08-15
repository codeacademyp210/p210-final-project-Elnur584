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
    public class MenuDinnerImgRightConController : Controller
    {
        // GET: Admin/MenuDinnerImgRightCon
        PatoContext db = new PatoContext();
        public ActionResult Index()
        {
            MenuDinnerImgRightVM model = new MenuDinnerImgRightVM()
            {
                menuBottomImgAreaRightList = db.menuBottomImgAreaSeconds.ToList(),
                menuBottomImgAreaRightSingle = null,
                Action = "Create"
            };
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(MenuBottomImgAreaSecond menuBottomImgAreaRightSingle)
        {
            if (menuBottomImgAreaRightSingle.ImgFile.ContentLength > 0)
            {
                var fileNm = Path.GetFileName(menuBottomImgAreaRightSingle.ImgFile.FileName);
                var saveArea = Path.Combine(Server.MapPath("~/Public/images"), fileNm);
                menuBottomImgAreaRightSingle.ImgFile.SaveAs(saveArea);
                menuBottomImgAreaRightSingle.Image = fileNm;
                db.menuBottomImgAreaSeconds.Add(menuBottomImgAreaRightSingle);
                db.SaveChanges();
            }
           
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            MenuDinnerImgRightVM model = new MenuDinnerImgRightVM()
            {
                menuBottomImgAreaRightList = db.menuBottomImgAreaSeconds.ToList(),
                menuBottomImgAreaRightSingle = db.menuBottomImgAreaSeconds.FirstOrDefault(m => m.Id == id),
                Action = "Edit"
            };
            return View("Index", model);
        }
        [HttpPost]
        public ActionResult Edit(MenuBottomImgAreaSecond menuBottomImgAreaRightSingle)
        {
            db.Entry(menuBottomImgAreaRightSingle).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var model = db.menuBottomImgAreaSeconds.FirstOrDefault(m => m.Id == id);
            db.menuBottomImgAreaSeconds.Remove(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}