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
    public class MenuDrinkStarersConController : Controller
    {
        // GET: Admin/MenuDrinkStarersCon
        PatoContext db = new PatoContext();
        public ActionResult Index()
        {
            MenuDrinkStarersVM model = new MenuDrinkStarersVM()
            {
                menuDrinkStarersList = db.menuDrinkStarers.ToList(),
                menuDrinkStarersSingle = null,
                Action = "Create"
            };
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(MenuDrinkStarers menuDrinkStarersSingle)
        {
            db.menuDrinkStarers.Add(menuDrinkStarersSingle);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            MenuDrinkStarersVM model = new MenuDrinkStarersVM()
            {
                menuDrinkStarersList = db.menuDrinkStarers.ToList(),
                menuDrinkStarersSingle = db.menuDrinkStarers.FirstOrDefault(m => m.Id == id),
                Action = "Edit"
            };
            return View("Index", model);
        }
        [HttpPost]
        public ActionResult Edit(MenuDrinkStarers menuDrinkStarersSingle)
        {
            db.Entry(menuDrinkStarersSingle).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var model = db.menuDrinkStarers.FirstOrDefault(m => m.Id == id);
            db.menuDrinkStarers.Remove(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}