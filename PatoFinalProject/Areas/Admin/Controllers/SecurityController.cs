using PatoFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace PatoFinalProject.Areas.Admin.Controllers
{
    [AllowAnonymous]
    public class SecurityController : BaseController
    {
        // GET: Admin/Security
        [HttpGet]

        public ActionResult Index()
        {
            return View();

        }
        [HttpPost]

        public ActionResult Index(User user)
        {
            var usr = db.Users.FirstOrDefault(m => m.Username == user.Username && m.Password == user.Password);
            if (usr != null)
            {
                FormsAuthentication.SetAuthCookie(usr.Username, false);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Message = "Username Veya Sifre Sehvdir";
                return View();
            }


        }

        /// <returns></returns>
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return View("Index");

        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
            ModelState.Clear();
            return RedirectToAction("Index");
        }
        public ActionResult Error404()
        {
            return View();
        }
    }
}