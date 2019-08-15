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
    public class ContactFormConController : Controller
    {
        // GET: Admin/ContactFormCon
        PatoContext db = new PatoContext();
        public ActionResult Index()
        {
            ContactFormVM model = new ContactFormVM()
            {
                contactFormsList = db.contactForms.ToList(),
                contactFormSingle = null,
                Action = null
            };
            return View(model);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            ContactFormVM model = new ContactFormVM()
            {
                contactFormsList = db.contactForms.ToList(),
                contactFormSingle = db.contactForms.FirstOrDefault(m => m.Id == id),
                Action = "Edit"
            };
            return View("Index", model);
        }
        [HttpPost]
        public ActionResult Edit(ContactForm contactFormSingle)
        {
            db.Entry(contactFormSingle).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var model = db.contactForms.FirstOrDefault(m => m.Id == id);
            db.contactForms.Remove(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}