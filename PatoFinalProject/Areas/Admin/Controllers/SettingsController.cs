using PatoFinalProject.DAL;
using PatoFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PatoFinalProject.Areas.Admin.Controllers
{
    public class SettingsController : Controller
    {
        // GET: Admin/Settings
        PatoContext db = new PatoContext();

        public ActionResult Index()
        {
            var AdminSetting = db.settings.FirstOrDefault() ?? new Models.Settings();
            return View(AdminSetting);
        }

        [HttpPost]
        public ActionResult Edit(Settings seting)
        {
            
            db.Entry(seting).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}