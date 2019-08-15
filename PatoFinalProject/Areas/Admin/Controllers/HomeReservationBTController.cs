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
    public class HomeReservationBTController : Controller
    {
        // GET: Admin/HomeReservationBT
        PatoContext db = new PatoContext();

        public ActionResult Index()
        {
            var reservationBT = db.reservationBTs.FirstOrDefault() ?? new Models.ReservationBT();
            return View(reservationBT);
        }
     

        [HttpPost]
        public ActionResult Edit(ReservationBT reservation)
        {
            if (reservation.ImgFile.ContentLength > 0)
            {
                var fileNm = Path.GetFileName(reservation.ImgFile.FileName);
                var saveArea = Path.Combine(Server.MapPath("~/Public/images"), fileNm);
                reservation.ImgFile.SaveAs(saveArea);
                reservation.Image = fileNm;
                db.Entry(reservation).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            
            return RedirectToAction("Index");
        }
      

    }
}