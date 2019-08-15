using PatoFinalProject.Models;
using PatoFinalProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PatoFinalProject.Controllers
{
    [AllowAnonymous]
    public class HomeController : MainController
    {
        [HttpGet]
        public ActionResult Index()
        {
            HomeViewModel model = new HomeViewModel();
            model.Settings = db.settings.FirstOrDefault() ?? new Models.Settings();
            model.ıtalianResturant = db.ItalianResturants.FirstOrDefault() ?? new Models.ItalianResturant();
            model.reservationBT = db.reservationBTs.FirstOrDefault() ?? new Models.ReservationBT();
            model.Video = db.videos.FirstOrDefault() ?? new Models.Video();
            model.RomanticDelicious = db.RomanticDeliciousReds.ToList();
            model.LatestBlogs = db.LatestBlogs.ToList();
            model.sliders = db.Sliders.ToList();
            model.settingFtGaleryimgs = db.settingFtGaleryimgs.ToList();
            model.specialSignUpSingle = null;
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(SpecialSignUp specialSignUpSingle)
        {
            db.specialSignUps.Add(specialSignUpSingle);           
            db.SaveChanges();
            ModelState.Clear();
            return RedirectToAction("Index");
        }
        public ActionResult Menu( string Email)
        {

            MenuViewModel menumodel = new MenuViewModel();
            menumodel.Settings = db.settings.FirstOrDefault() ?? new Models.Settings();
            
            menumodel.specialSignUpSingle = null;
            //db.specialSignUps.Add();
            menumodel.MenuImgAreaFirsts = db.menuImgAreaFirsts.ToList();
            menumodel.MenuImgAreaSeconds = db.menuImgAreaSeconds.ToList();
            menumodel.MenuBottomImgAreaFirsts = db.menuBottomImgAreaFirsts.ToList();
            menumodel.MenuBottomImgAreaSeconds = db.menuBottomImgAreaSeconds.ToList();
            menumodel.MenuDrinkStarers = db.menuDrinkStarers.ToList();
            menumodel.MenuMainDeserts = db.MenuMainDeserts.ToList();
            return View(menumodel);
        }
      
        [HttpGet]
        public ActionResult Reservation()
        {
            ReservationVM model = new ReservationVM();
            model.Settings = db.settings.FirstOrDefault() ?? new Models.Settings();
            
            return View(model);
        }
        [HttpPost]
        public ActionResult ReservCreate(ReservationForm reservationFormSingle)
        {
            db.ReservationForm.Add(reservationFormSingle);         
            db.SaveChanges();
            ModelState.Clear();
            return RedirectToAction("Reservation");
        }
        public ActionResult Gallery()
        {
            GalleryViewModel gallerymodel = new GalleryViewModel();
            gallerymodel.Settings = db.settings.FirstOrDefault() ?? new Models.Settings();
            
            gallerymodel.galleryAllPhotos = db.galleryAllPhotos.ToList();
            gallerymodel.galleryInteriorPhotos = db.galleryInteriorPhotos.ToList();
            gallerymodel.galleryFoodPhotos = db.galleryFoodPhotos.ToList();
            gallerymodel.galleryEventPhotos = db.galleryEventPhotos.ToList();
            gallerymodel.galleryVipPhotos = db.galleryVipPhotos.ToList();
            gallerymodel.specialSignUpSingle = null;
            return View(gallerymodel);
        }
        public ActionResult AboutUs()
        {
            AboutViewModel aboutmodel = new AboutViewModel();
            aboutmodel.Settings = db.settings.FirstOrDefault() ?? new Models.Settings();
           
            aboutmodel.DeliciousReceipes = db.DeliciousReceipes.FirstOrDefault() ?? new Models.DeliciousReceipes();
            aboutmodel.AboutRomanticRestaurants = db.aboutRomantics.FirstOrDefault() ?? new Models.AboutRomanticRestaurant();
            aboutmodel.AboutOurChefs = db.aboutOurChefs.ToList();
            aboutmodel.specialSignUpSingle = null;
            return View(aboutmodel);
        }
        public ActionResult Blog()
        {
            BlogViewModel blogmodel = new BlogViewModel();
            blogmodel.Settings = db.settings.FirstOrDefault() ?? new Models.Settings();
            
            blogmodel.BlogPhotoAreas = db.blogPhotoAreas.ToList();
            blogmodel.BlogMostPopulars = db.blogMostPopulars.ToList();
            return View(blogmodel);
        }
        [HttpGet]
        public ActionResult Contact()
        {
            ContactViewModel model = new ContactViewModel();
            model.Settings = db.settings.FirstOrDefault() ?? new Models.Settings();
            
            return View(model);
        }
        [HttpPost]
        public ActionResult ContactCreate(ContactForm contactFormSingle)
        {
            db.contactForms.Add(contactFormSingle);
            db.SaveChanges();
            ModelState.Clear();
            return RedirectToAction("Contact");
        }
        public ActionResult ChangeLanguage(string lang)
        {
            new LanguageMang().SetLanguage(lang);
            return RedirectToAction("Index");
        }

    }
}