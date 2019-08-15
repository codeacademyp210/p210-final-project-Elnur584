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
    public class RomanticDelicousCardController : Controller
    {
        // GET: Admin/RomanticDelicousCard
        PatoContext db = new PatoContext();
        public ActionResult Index()
        {
            RomanticDelicious model = new RomanticDelicious()
            {
                romanticDeliciousReds = db.RomanticDeliciousReds.ToList(),
                romantic = null,
                Action = "Create"
            };


            return View(model);
        }
        [HttpPost]
        public ActionResult Create( RomanticDeliciousRed romantic)
        {
            if (romantic.ImgFile.ContentLength > 0)
            {
                var fileNm = Path.GetFileName(romantic.ImgFile.FileName);
                var saveArea = Path.Combine(Server.MapPath("~/Public/images"), fileNm);
                romantic.ImgFile.SaveAs(saveArea);
                romantic.Image = fileNm;
                db.RomanticDeliciousReds.Add(romantic);
                db.SaveChanges();
            }
            
         return  RedirectToAction  ("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            RomanticDelicious model = new RomanticDelicious()
            {
                romanticDeliciousReds = db.RomanticDeliciousReds.ToList(),
                romantic = db.RomanticDeliciousReds.FirstOrDefault(m => m.Id == id),
                Action = "Edit"
            };

            return View("Index",model);
        }

        [HttpPost]
        public ActionResult Edit(RomanticDeliciousRed romantic)
        {

            db.Entry(romantic).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

 
        public ActionResult Delete(int id)
        {
          var  model = db.RomanticDeliciousReds.FirstOrDefault(m=>m.Id==id);
            db.RomanticDeliciousReds.Remove(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}