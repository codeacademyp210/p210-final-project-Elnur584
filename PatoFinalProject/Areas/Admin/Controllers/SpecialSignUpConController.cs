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
    public class SpecialSignUpConController : Controller
    {
        // GET: Admin/SpecialSignUpCon
        PatoContext db = new PatoContext();
        public ActionResult Index()
        {
            SpecialSignUpVM model = new SpecialSignUpVM();
            model.specialSignUpsList = db.specialSignUps.ToList();
        


            return View(model);
        }
       
        public ActionResult Delete(int id)
        {
            var model = db.specialSignUps.FirstOrDefault(m => m.Id == id);
            db.specialSignUps.Remove(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}