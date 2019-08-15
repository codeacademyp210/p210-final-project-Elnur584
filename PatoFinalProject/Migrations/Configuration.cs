namespace PatoFinalProject.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PatoFinalProject.DAL.PatoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PatoFinalProject.DAL.PatoContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.ItalianResturants.AddOrUpdate(
            new Models.ItalianResturant { Id = 1, Title1 = "Italian Restaurant", Title2 = "WELCOME", Content = "Donec quis lorem nulla. Nunc eu odio mi. Morbi nec lobortis est. Sed fringilla, nunc sed imperdiet lacinia, nisl ante egestas mi, ac facilisis ligula sem id neque.", ItalianRestaurantimg = "our-story-01.jpg" }
       );
            context.LatestBlogs.AddOrUpdate(
         new Models.LatestBlog { Id = 1, Title = "BEST PLACES FOR WINE", Image = "blog-01.jpg", Content = "Phasellus lorem enim, luctus ut velit eget, con-vallis egestas eros.", ContinueAtag = "Continue reading" },
         new Models.LatestBlog { Id = 2, Title = "EGGS AND CHEESE", Image = "blog-02.jpg", Content = "Phasellus lorem enim, luctus ut velit eget, con-vallis egestas eros.", ContinueAtag = "Continue reading" },
         new Models.LatestBlog { Id = 3, Title = "STYLE THE WEDDING PARTY", Image = "blog-03.jpg", Content = "Phasellus lorem enim, luctus ut velit eget, con-vallis egestas eros.", ContinueAtag = "Continue reading" }
         );
             context.RomanticDeliciousReds.AddOrUpdate(
         new Models.RomanticDeliciousRed { Id = 1, Title = "ROMANTIC RESTAURANT", Image = "intro-01.jpg", Content = "Phasellus lorem enim, luctus ut velit eget, con-vallis egestas eros.", Learnmore = "Learn more" },
         new Models.RomanticDeliciousRed { Id = 2, Title = "DELICIOUS FOOD", Image = "intro-02.jpg", Content = "Phasellus lorem enim, luctus ut velit eget, con-vallis egestas eros.", Learnmore = "Learn more" },
         new Models.RomanticDeliciousRed { Id = 3, Title = "RED WINES YOU LOVE", Image = "intro-04.jpg", Content = "Phasellus lorem enim, luctus ut velit eget, con-vallis egestas eros.", Learnmore = "Learn more" }
        );
            context.reservationBTs.AddOrUpdate(
         new Models.ReservationBT { Id = 1, Image = "booking-01.jpg" }

        );
            context.videos.AddOrUpdate(
         new Models.Video { Id = 1, VideoNm = "video.mp4" }

        );
            context.settings.AddOrUpdate(
         new Models.Settings { Id = 1, FtAdress = " 8th floor, 379 Hudson St, New York, NY 10018", FtEmail = "elnurfh@code.edu.az", FtTime = "09:30 AM – 11:00 PM", FtTwitLink1 = "@elnurfh@code.edu.az", FtTwitLink2 = "@elnurfh@code.edu.az",Phone= " (+1) 96 716 6879" }
        );

            context.settingFtGaleryimgs.AddOrUpdate(
         new Models.SettingFtGaleryimg { Id = 1, ImageNm = "photo-gallery-01.jpg", ImageNm2 = "photo-gallery-02.jpg", ImageNm3 = "photo-gallery-03.jpg", ImageNm4 = "photo-gallery-04.jpg" },
         new Models.SettingFtGaleryimg { Id = 2, ImageNm = "photo-gallery-05.jpg", ImageNm2 = "photo-gallery-06.jpg", ImageNm3 = "photo-gallery-07.jpg", ImageNm4 = "photo-gallery-08.jpg" },
         new Models.SettingFtGaleryimg { Id = 3, ImageNm = "photo-gallery-09.jpg", ImageNm2 = "photo-gallery-10.jpg", ImageNm3 = "photo-gallery-11.jpg", ImageNm4 = "photo-gallery-12.jpg" }
        );
            context.Sliders.AddOrUpdate(
        new Models.Slider { Id = 1, Image = "cabinet-1.jpg" },
        new Models.Slider { Id = 2, Image = "cabinet-2.jpg" },
        new Models.Slider { Id = 3, Image = "cabinet-3.jpg" },
        new Models.Slider { Id = 4, Image = "cabinet-4.jpg" },
        new Models.Slider { Id = 5, Image = "cabinet-5.jpg" },
        new Models.Slider { Id = 6, Image = "cabinet-6.jpg" },
        new Models.Slider { Id = 7, Image = "cabinet-7.jpg" },
        new Models.Slider { Id = 8, Image = "cabinet-8.jpg" },
        new Models.Slider { Id = 9, Image = "cabinet-5.jpg" },
        new Models.Slider { Id = 10, Image = "cabinet-9.jpg" },
        new Models.Slider { Id = 11, Image = "cabinet-10.jpg" }
        );
            context.menuDrinkStarers.AddOrUpdate(
        new Models.MenuDrinkStarers { Id = 1,FoodKind= "STARTERS", Food1Name= "PINE NUT SBRISALONA", Food1Price= "$29.79", Food1Description= "Sed fermentum eros vitae eros", Food2Name= "AENEAN EU DUISPENDIG", Food2Price= "$19.35", Food2Description= "Feugiat maximus neque pharetra", Food3Name= "SED FEUGIAT", Food3Price= "$12.19", Food3Description= "Proin lacinia nisl ut ultricies posuere nulla", Food4Name= "CONSECTETUR DEU", Food4Price= "$21.89", Food4Description= "Etiam cursus facilisis tortor" },
        new Models.MenuDrinkStarers { Id = 2, FoodKind = "DRINKS", Food1Name = "VIVAMUS PRETUTERIUM ", Food1Price = "$29.79", Food1Description = "Sed fermentum eros vitae eros", Food2Name = "DUIS PHARETRA LIGULA", Food2Price = "$19.35", Food2Description = "Sed fermentum eros vitae eros", Food3Name = "IN EUET DOLOR", Food3Price = "$53.34", Food3Description = "Sed fermentum eros vitae eros", Food4Name = "FEUGIAT MAXIMUS", Food4Price = "$62.45", Food4Description = "Sed fermentum eros vitae eros" }

        );
            context.MenuMainDeserts.AddOrUpdate(
        new Models.MenuMainDesert { Id = 1, FoodKind = "MAIN", Food1Name = "DUIS SED ALIQUET", Food1Price = "$31.18", Food1Description = "Proin lacinia nisl ut ultricies posuere nulla", Food2Name = "SUSPENDISSE", Food2Price = "$70.25", Food2Description = "Feugiat maximus neque pharetra", Food3Name = "SCELERISQUE SED", Food3Price = "$36.19", Food3Description = "Etiam cursus facilisis tortor", Food4Name = "MOLLIS NULEDLA", Food4Price = "$19.50", Food4Description = "Proin lacinia nisl ut ultricies posuere nulla", Food5Name = "CONVALLIS AUGUE", Food5Price = "$29.15", Food5Description = "Sed fermentum eros vitae eros" },
        new Models.MenuMainDesert { Id = 2, FoodKind = "DESSERT", Food1Name = "TEMPUS DEALIQUET", Food1Price = "$9.79", Food1Description = "Proin lacinia nisl ut ultricies posuere nulla", Food2Name = "SCELERISQUE", Food2Price = "$19.35", Food2Description = "Sed fermentum eros vitae eros", Food3Name = "CRAS MAXIMUSEDU ", Food3Price = "$5.79", Food3Description = "Duis pharetra ligula at urna dignissim", Food4Name = "DUIS TINCIDUNT", Food4Price = "$29.79", Food4Description = "Feugiat maximus neque pharetra", Food5Name = "MOLLIS DE NULLA ", Food5Price = "$19.35", Food5Description = "Proin lacinia nisl ut ultricies posuere nulla" }

        );
            context.menuImgAreaFirsts.AddOrUpdate(
         new Models.MenuImgAreaFirst { Id = 1, Image = "lunch-01.jpg", Title = "SED VARIUS", Content = "Aenean pharetra tortor dui in pellentesque", Price = "$29.79" },
         new Models.MenuImgAreaFirst { Id = 2, Image = "lunch-03.jpg", Title = "TEMPUS ALIQUET", Content = "Aenean condimentum ante erat", Price = "$45.09" },
         new Models.MenuImgAreaFirst { Id = 3, Image = "lunch-05.jpg", Title = "DUIS MASSA", Content = "Proin lacinia nisl ut ultricies posuere nulla", Price = "$12.75" }

        );
            context.menuImgAreaSeconds.AddOrUpdate(
        new Models.MenuImgAreaSecond { Id = 1, Image = "lunch-02.jpg", Title = "SBRISALONA", Content = "Proin lacinia nisl ut ultricies posuere nulla", Price = "$29.79" },
        new Models.MenuImgAreaSecond { Id = 2, Image = "lunch-04.jpg", Title = "CRAS EGET MAGNA", Content = "Sed fermentum eros vitae eros", Price = "$45.09" },
        new Models.MenuImgAreaSecond { Id = 3, Image = "lunch-06.jpg", Title = "NULLAM MAXIMUS", Content = "Duis massa nibh porttitor nec imperdiet eget", Price = "$12.75" }

                  );
            context.menuBottomImgAreaFirsts.AddOrUpdate(
        new Models.MenuBottomImgAreaFirst { Id = 1, Image = "dinner-01.jpg", Title = "MAECENAS TRISTIQUE", Content = "Aenean pharetra tortor dui in pellentesque", Price = "$29.79" },
        new Models.MenuBottomImgAreaFirst { Id = 2, Image = "dinner-03.jpg", Title = "PINE NUT SBRISALONA", Content = "Aenean condimentum ante erat", Price = "$45.09" },
        new Models.MenuBottomImgAreaFirst { Id = 3, Image = "dinner-05.jpg", Title = "SUSPENDISSE EU", Content = "Proin lacinia nisl ut ultricies posuere nulla", Price = "$12.75" }

   );
            context.menuBottomImgAreaSeconds.AddOrUpdate(
        new Models.MenuBottomImgAreaSecond { Id = 1, Image = "dinner-02.jpg", Title = "CRAS MAXIMUS", Content = "Proin lacinia nisl ut ultricies posuere nulla", Price = "$29.79" },
        new Models.MenuBottomImgAreaSecond { Id = 2, Image = "dinner-04.jpg", Title = "PINE NUT SBRISALONA", Content = "Sed fermentum eros vitae eros", Price = "$45.09" },
        new Models.MenuBottomImgAreaSecond { Id = 3, Image = "dinner-06.jpg", Title = "TEMPOR MALESUADA", Content = "Duis massa nibh porttitor nec imperdiet eget", Price = "$12.75" }

                  );
            context.galleryAllPhotos.AddOrUpdate(
        new Models.GalleryAllPhoto { Id = 1, Image = "photo-gallery-13.jpg" },
        new Models.GalleryAllPhoto { Id = 2, Image = "photo-gallery-14.jpg" },
        new Models.GalleryAllPhoto { Id = 3, Image = "photo-gallery-15.jpg" },
        new Models.GalleryAllPhoto { Id = 4, Image = "photo-gallery-16.jpg" },
        new Models.GalleryAllPhoto { Id = 5, Image = "photo-gallery-17.jpg" },
        new Models.GalleryAllPhoto { Id = 6, Image = "photo-gallery-18.jpg" },
        new Models.GalleryAllPhoto { Id = 7, Image = "photo-gallery-19.jpg" },
        new Models.GalleryAllPhoto { Id = 8, Image = "photo-gallery-20.jpg" },
        new Models.GalleryAllPhoto { Id = 9, Image = "photo-gallery-21.jpg" }


                );
            context.galleryInteriorPhotos.AddOrUpdate(
        new Models.GalleryInteriorPhoto { Id = 1, Image = "photo-gallery-18.jpg" },
        new Models.GalleryInteriorPhoto { Id = 2, Image = "photo-gallery-19.jpg" },
        new Models.GalleryInteriorPhoto { Id = 3, Image = "photo-gallery-20.jpg" }
        );
             context.galleryFoodPhotos.AddOrUpdate(
        new Models.GalleryFoodPhoto { Id = 1, Image = "photo-gallery-14.jpg" },
        new Models.GalleryFoodPhoto { Id = 2, Image = "photo-gallery-16.jpg" },
        new Models.GalleryFoodPhoto { Id = 3, Image = "photo-gallery-17.jpg" }
        );
             context.galleryEventPhotos.AddOrUpdate(
        new Models.GalleryEventPhoto { Id = 1, Image = "photo-gallery-13.jpg" },
        new Models.GalleryEventPhoto { Id = 2, Image = "photo-gallery-15.jpg" },
        new Models.GalleryEventPhoto { Id = 3, Image = "photo-gallery-21.jpg" }
        );
                context.galleryVipPhotos.AddOrUpdate(
        new Models.GalleryVipPhoto { Id = 1, Image = "photo-gallery-13.jpg" },    
        new Models.GalleryVipPhoto { Id = 2, Image = "photo-gallery-18.jpg" }
        );
            context.DeliciousReceipes.AddOrUpdate(
  new Models.DeliciousReceipes { Id = 1, Title = "Delicious", Title2 = "RECIPES", Content = "Donec quis lorem nulla. Nunc eu odio mi. Morbi nec lobortis est. Sed fringilla, nunc sed imperdiet lacinia, nisl ante egestas mi, ac facilisis ligula sem id neque.", Image = "our-story-01.jpg" }

  );
            context.aboutRomantics.AddOrUpdate(
        new Models.AboutRomanticRestaurant { Id = 1, Title = "Romantic", Title2 = "RESTAURANT", Content = "Fusce iaculis, quam quis volutpat cursus, tellus quam varius eros, in euismod lorem nisl in ante. Maecenas imperdiet vulputate dui sit amet vestibulum. Nulla quis suscipit nisl.", Image = "our-story-02.jpg" }    
        );
                    context.aboutOurChefs.AddOrUpdate(
        new Models.AboutOurChef { Id = 1, Title = "Peter Hart", Title2 = "CHEF", Content = "Donec porta eleifend mauris ut effici-tur. Quisque non velit vestibulum, lob-ortis mi eget, rhoncus nunc", Image = "avatar-02.jpg" },
        new Models.AboutOurChef { Id = 2, Title = "Joyce Bowman", Title2 = "CHEF", Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin ultricies felis a sem tempus tempus.", Image = "avatar-03.jpg" },
        new Models.AboutOurChef { Id = 3, Title = "John Norman", Title2 = "CHEF", Content = "CHEF Phasellus aliquam libero a nisi varius, vitae placerat sem aliquet. Ut at velit nec ipsum iaculis posuere quis in sapien", Image = "avatar-05.jpg" }
        );
              context.blogPhotoAreas.AddOrUpdate(
        new Models.BlogPhotoArea { Id = 1, Title = "COOKING RECIPE DELICIOUS", Information= "by Admin | 28 December, 2018 | Cooking, Food | 8 Comments", Content = "Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Fusce eget dictum tortor. Donec dictum vitae sapien eu varius", Image = "blog-05.jpg" },
        new Models.BlogPhotoArea { Id = 2, Title = "PIZZA IS PREPARED FRESH", Information = "by Admin | 28 December, 2018 | Cooking, Food | 8 Comments", Content = "Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Fusce eget dictum tortor. Donec dictum vitae sapien eu varius", Image = "blog-06.jpg" },
        new Models.BlogPhotoArea { Id = 3, Title = "STYLE THE WEDDING PARTY", Information = "by Admin | 28 December, 2018 | Cooking, Food | 8 Comments", Content = "Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Fusce eget dictum tortor. Donec dictum vitae sapien eu varius", Image = "blog-04.jpg" },
        new Models.BlogPhotoArea { Id = 4, Title = "BEST PLACES FOR WINE", Information = "by Admin | 28 December, 2018 | Cooking, Food | 8 Comments", Content = "Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Fusce eget dictum tortor. Donec dictum vitae sapien eu varius", Image = "blog-07.jpg" },
        new Models.BlogPhotoArea { Id = 5, Title = "BEST PLACES FOR WINE", Information = "by Admin | 28 December, 2018 | Cooking, Food | 8 Comments", Content = "Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Fusce eget dictum tortor. Donec dictum vitae sapien eu varius", Image = "blog-10.jpg" }

        );
              context.blogMostPopulars.AddOrUpdate(
        new Models.BlogMostPopular { Id = 1, Title = "BEST PLACES FOR WINE", Image=  "blog-11.jpg", BlogTime = "3 days ago" },
        new Models.BlogMostPopular { Id = 2, Title = "BEST PLACES FOR WINE", Image = "blog-12.jpg", BlogTime = "3 days ago" },
        new Models.BlogMostPopular { Id = 3, Title = "BEST PLACES FOR WINE", Image = "blog-13.jpg", BlogTime = "3 days ago" },
        new Models.BlogMostPopular { Id = 4, Title = "BEST PLACES FOR WINE", Image = "blog-14.jpg", BlogTime = "3 days ago" },
        new Models.BlogMostPopular { Id = 5, Title = "BEST PLACES FOR WINE", Image = "blog-15.jpg", BlogTime = "3 days ago" }

        );
        }
    }
}
