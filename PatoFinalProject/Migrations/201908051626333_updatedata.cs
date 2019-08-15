namespace PatoFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedata : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GalleryAllPhoto", "ImgPath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.GalleryAllPhoto", "ImgPath");
        }
    }
}
