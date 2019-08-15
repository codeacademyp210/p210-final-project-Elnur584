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
    public class ReservationFormConController : Controller
    {
        // GET: Admin/ReservationFormCon
        PatoContext db = new PatoContext();
        public ActionResult Index()
        {
            ReservationFormVM model = new ReservationFormVM()
            {
                ReservationFormsList = db.ReservationForm.ToList(),
                reservationFormSingle = null,
                Action = null
            };
            return View(model);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            ReservationFormVM model = new ReservationFormVM()
            {
                ReservationFormsList = db.ReservationForm.ToList(),
                reservationFormSingle = db.ReservationForm.FirstOrDefault(m => m.Id == id),
                Action = "Edit"
            };
            return View("Index", model);
        }
        [HttpPost]
        public ActionResult Edit(ReservationForm reservationFormSingle)
        {
            db.Entry(reservationFormSingle).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var model = db.ReservationForm.FirstOrDefault(m => m.Id == id);
            db.ReservationForm.Remove(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}