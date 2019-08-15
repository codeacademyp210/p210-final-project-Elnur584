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
    public class MenuDinnerImgConController : Controller
    {
        // GET: Admin/MenuDinnerImgCon
        PatoContext db = new PatoContext();
        public ActionResult Index()
        {
            MenuDinnerImgVM model = new MenuDinnerImgVM()
            {
                menuBottomImgAreaFirstsList = db.menuBottomImgAreaFirsts.ToList(),
                MenuBottomImgAreaFirstSingle = null,
                Action = "Create"
            };
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(MenuBottomImgAreaFirst MenuBottomImgAreaFirstSingle)
        {
            if (MenuBottomImgAreaFirstSingle.ImgFile.ContentLength > 0)
            {
                var fileNm = Path.GetFileName(MenuBottomImgAreaFirstSingle.ImgFile.FileName);
                var saveArea = Path.Combine(Server.MapPath("~/Public/images"), fileNm);
                MenuBottomImgAreaFirstSingle.ImgFile.SaveAs(saveArea);
                MenuBottomImgAreaFirstSingle.Image = fileNm;
                db.menuBottomImgAreaFirsts.Add(MenuBottomImgAreaFirstSingle);
                db.SaveChanges();
            }
            
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            MenuDinnerImgVM model = new MenuDinnerImgVM()
            {
                menuBottomImgAreaFirstsList = db.menuBottomImgAreaFirsts.ToList(),
                MenuBottomImgAreaFirstSingle = db.menuBottomImgAreaFirsts.FirstOrDefault(m => m.Id == id),
                Action = "Edit"
            };
            return View("Index", model);
        }
        [HttpPost]
        public ActionResult Edit(MenuBottomImgAreaFirst MenuBottomImgAreaFirstSingle)
        {
            db.Entry(MenuBottomImgAreaFirstSingle).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var model = db.menuBottomImgAreaFirsts.FirstOrDefault(m => m.Id == id);
            db.menuBottomImgAreaFirsts.Remove(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}