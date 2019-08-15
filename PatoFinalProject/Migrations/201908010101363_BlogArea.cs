namespace PatoFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BlogArea : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BlogMostPopular",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Image = c.String(),
                        Title = c.String(),
                        BlogTime = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BlogPhotoArea",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Image = c.String(),
                        Title = c.String(),
                        Information = c.String(),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BlogPhotoArea");
            DropTable("dbo.BlogMostPopular");
        }
    }
}
