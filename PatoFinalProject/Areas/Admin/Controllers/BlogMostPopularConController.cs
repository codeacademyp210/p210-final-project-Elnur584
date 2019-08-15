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
    public class BlogMostPopularConController : Controller
    {
        // GET: Admin/BlogMostPopularCon
        PatoContext db = new PatoContext();

        public ActionResult Index()
        {
            BlogMostPopularVM model = new BlogMostPopularVM()
            {
                blogMostPopularsList = db.blogMostPopulars.ToList(),
                blogMostPopularSingle = null,
                Action = "Create"
            };


            return View(model);
        }
        [HttpPost]
        public ActionResult Create(BlogMostPopular blogMostPopularSingle)
        {
            if (blogMostPopularSingle.ImgFile.ContentLength > 0)
            {
                var fileNm = Path.GetFileName(blogMostPopularSingle.ImgFile.FileName);
                var saveArea = Path.Combine(Server.MapPath("~/Public/images"), fileNm);
                blogMostPopularSingle.ImgFile.SaveAs(saveArea);
                blogMostPopularSingle.Image = fileNm;
                db.blogMostPopulars.Add(blogMostPopularSingle);
                db.SaveChanges();
            }
           
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            BlogMostPopularVM model = new BlogMostPopularVM()
            {
                blogMostPopularsList = db.blogMostPopulars.ToList(),
                blogMostPopularSingle = db.blogMostPopulars.FirstOrDefault(m => m.Id == id),
                Action = "Edit"
            };

            return View("Index", model);
        }

        [HttpPost]
        public ActionResult Edit(BlogMostPopular blogMostPopularSingle)
        {

            db.Entry(blogMostPopularSingle).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var model = db.blogMostPopulars.FirstOrDefault(m => m.Id == id);
            db.blogMostPopulars.Remove(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}