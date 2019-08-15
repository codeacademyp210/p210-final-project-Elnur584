using PatoFinalProject.Areas.ViewModel;
using PatoFinalProject.DAL;
using PatoFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PatoFinalProject.Areas.Admin.Controllers
{
    public class MenuMainDesertConController : Controller
    {
        // GET: Admin/MenuMainDesertCon
        PatoContext db = new PatoContext();
        public ActionResult Index()
        {
            MenuMainDesertVM model = new MenuMainDesertVM()
            {
                menuMainDesertsList = db.MenuMainDeserts.ToList(),
                menuMainDesertSingle = null,
                Action = "Create"
            };
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(MenuMainDesert menuMainDesertSingle)
        {
            db.MenuMainDeserts.Add(menuMainDesertSingle);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            MenuMainDesertVM model = new MenuMainDesertVM()
            {
                menuMainDesertsList = db.MenuMainDeserts.ToList(),
                menuMainDesertSingle = db.MenuMainDeserts.FirstOrDefault(m => m.Id == id),
                Action = "Edit"
            };
            return View("Index", model);
        }
        [HttpPost]
        public ActionResult Edit(MenuMainDesert menuMainDesertSingle)
        {
            db.Entry(menuMainDesertSingle).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var model = db.MenuMainDeserts.FirstOrDefault(m => m.Id == id);
            db.MenuMainDeserts.Remove(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}