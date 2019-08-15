namespace PatoFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class galleryPhotos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GalleryAllPhoto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GalleryEventPhoto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GalleryFoodPhoto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GalleryInteriorPhoto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GalleryVipPhoto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GalleryVipPhoto");
            DropTable("dbo.GalleryInteriorPhoto");
            DropTable("dbo.GalleryFoodPhoto");
            DropTable("dbo.GalleryEventPhoto");
            DropTable("dbo.GalleryAllPhoto");
        }
    }
}
