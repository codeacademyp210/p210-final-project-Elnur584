namespace PatoFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alltable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItalianResturant",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title1 = c.String(),
                        Title2 = c.String(),
                        Content = c.String(),
                        ItalianRestaurantimg = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LatestBlog",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Image = c.String(),
                        Title = c.String(),
                        Content = c.String(),
                        MyProperty = c.String(),
                        ContinueAtag = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MenuImgAreaFirst",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Image = c.String(),
                        Title = c.String(),
                        Content = c.String(),
                        Price = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MenuImgAreaSecond",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Image = c.String(),
                        Title = c.String(),
                        Content = c.String(),
                        Price = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ReservationBT",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RomanticDeliciousRed",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Image = c.String(),
                        Content = c.String(),
                        Learnmore = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SettingFtGaleryimg",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ImageNm = c.String(),
                        ImageNm2 = c.String(),
                        ImageNm3 = c.String(),
                        ImageNm4 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Settings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Menu1 = c.String(),
                        Menu2 = c.String(),
                        Menu3 = c.String(),
                        Menu4 = c.String(),
                        Menu5 = c.String(),
                        Menu6 = c.String(),
                        Menu7 = c.String(),
                        FtAdress = c.String(),
                        FtEmail = c.String(),
                        FtTime = c.String(),
                        FtTwitLink1 = c.String(),
                        FtTwitLink2 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Slider",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Video",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VideoNm = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Video");
            DropTable("dbo.Slider");
            DropTable("dbo.Settings");
            DropTable("dbo.SettingFtGaleryimg");
            DropTable("dbo.RomanticDeliciousRed");
            DropTable("dbo.ReservationBT");
            DropTable("dbo.MenuImgAreaSecond");
            DropTable("dbo.MenuImgAreaFirst");
            DropTable("dbo.LatestBlog");
            DropTable("dbo.ItalianResturant");
        }
    }
}
