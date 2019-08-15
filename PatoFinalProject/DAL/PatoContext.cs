using PatoFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace PatoFinalProject.DAL
{
    public class PatoContext : DbContext
    {

        public PatoContext() : base("PatoConnection")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public DbSet<Settings> settings { get; set; }
        public DbSet<SettingFtGaleryimg> settingFtGaleryimgs { get; set; }
        public DbSet<ItalianResturant> ItalianResturants { get; set; }
        public DbSet<RomanticDeliciousRed> RomanticDeliciousReds { get; set; }
        public DbSet<ReservationBT> reservationBTs { get; set; }
        public DbSet<Video> videos { get; set; }
        public DbSet<LatestBlog> LatestBlogs { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<MenuDrinkStarers> menuDrinkStarers { get; set; }
        public DbSet<MenuMainDesert> MenuMainDeserts { get; set; }
        public DbSet<MenuImgAreaFirst> menuImgAreaFirsts { get; set; }
        public DbSet<MenuImgAreaSecond> menuImgAreaSeconds { get; set; }
        public DbSet<MenuBottomImgAreaFirst> menuBottomImgAreaFirsts { get; set; }
        public DbSet<MenuBottomImgAreaSecond> menuBottomImgAreaSeconds { get; set; }
        public DbSet<GalleryAllPhoto> galleryAllPhotos{ get; set; }
        public DbSet<GalleryInteriorPhoto> galleryInteriorPhotos { get; set; }
        public DbSet<GalleryFoodPhoto> galleryFoodPhotos { get; set; }
        public DbSet<GalleryEventPhoto> galleryEventPhotos { get; set; }
        public DbSet<GalleryVipPhoto> galleryVipPhotos { get; set; }
        public DbSet<DeliciousReceipes> DeliciousReceipes { get; set; }
        public DbSet<AboutRomanticRestaurant> aboutRomantics { get; set; }
        public DbSet<AboutOurChef> aboutOurChefs { get; set; }
        public DbSet<BlogPhotoArea> blogPhotoAreas { get; set; }
        public DbSet<BlogMostPopular> blogMostPopulars { get; set; }
        public DbSet<SpecialSignUp> specialSignUps{ get; set; }
        public DbSet<ReservationForm> ReservationForm { get; set; }
        public DbSet<ContactForm> contactForms { get; set; }
        public DbSet<User> Users { get; set; }
    }
}