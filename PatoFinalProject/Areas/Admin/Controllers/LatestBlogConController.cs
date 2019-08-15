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
    public class LatestBlogConController : Controller
    {
        PatoContext db = new PatoContext();
        // GET: Admin/LatestBlogCon
        public ActionResult Index()
        {
            LatestBlogVM model = new LatestBlogVM()
            {
                latestBlogsListVm = db.LatestBlogs.ToList(),
                LatestBlogsingle = null,
                Action = "Create"
            };


            return View(model);
        }
        [HttpPost]
        public ActionResult Create(LatestBlog LatestBlogsingle)
        {
            if (LatestBlogsingle.ImgFile.ContentLength > 0)
            {
                var fileNm = Path.GetFileName(LatestBlogsingle.ImgFile.FileName);
                var saveArea = Path.Combine(Server.MapPath("~/Public/images"), fileNm);
                LatestBlogsingle.ImgFile.SaveAs(saveArea);
                LatestBlogsingle.Image = fileNm;
                db.LatestBlogs.Add(LatestBlogsingle);
                db.SaveChanges();
            }            
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            LatestBlogVM model = new LatestBlogVM()
            {
                latestBlogsListVm = db.LatestBlogs.ToList(),
                LatestBlogsingle = db.LatestBlogs.FirstOrDefault(m => m.Id == id),
                Action = "Edit"
            };

            return View("Index", model);
        }

        [HttpPost]
        public ActionResult Edit(LatestBlog LatestBlogsingle)
        {

            db.Entry(LatestBlogsingle).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var model = db.LatestBlogs.FirstOrDefault(m => m.Id == id);
            db.LatestBlogs.Remove(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}