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
    public class MenuLunchConController : Controller
    {
        // GET: Admin/MenuLunchCon
        PatoContext db = new PatoContext();
        public ActionResult Index()
        {
            MenuLunchVM model = new MenuLunchVM()
            {
                menuImgAreaFirstsList = db.menuImgAreaFirsts.ToList(),
                menuImgAreaFirstSingle = null,
                Action = "Create"
            };
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(MenuImgAreaFirst menuImgAreaFirstSingle)
        {
            if (menuImgAreaFirstSingle.ImgFile.ContentLength > 0)
            {
                var fileNm = Path.GetFileName(menuImgAreaFirstSingle.ImgFile.FileName);
                var saveArea = Path.Combine(Server.MapPath("~/Public/images"), fileNm);
                menuImgAreaFirstSingle.ImgFile.SaveAs(saveArea);
                menuImgAreaFirstSingle.Image = fileNm;
                db.menuImgAreaFirsts.Add(menuImgAreaFirstSingle);
                db.SaveChanges();
            }
            
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            MenuLunchVM model = new MenuLunchVM()
            {
                menuImgAreaFirstsList = db.menuImgAreaFirsts.ToList(),
                menuImgAreaFirstSingle = db.menuImgAreaFirsts.FirstOrDefault(m => m.Id == id),
                Action = "Edit"
            };
            return View("Index",model);
        }
        [HttpPost]
        public ActionResult Edit(MenuImgAreaFirst menuImgAreaFirstSingle)
        {
            db.Entry(menuImgAreaFirstSingle).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var model = db.menuImgAreaFirsts.FirstOrDefault(m => m.Id == id);
            db.menuImgAreaFirsts.Remove(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }

}