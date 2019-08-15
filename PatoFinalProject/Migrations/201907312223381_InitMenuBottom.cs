namespace PatoFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitMenuBottom : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MenuBottomImgAreaFirst",
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
                "dbo.MenuBottomImgAreaSecond",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Image = c.String(),
                        Title = c.String(),
                        Content = c.String(),
                        Price = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MenuBottomImgAreaSecond");
            DropTable("dbo.MenuBottomImgAreaFirst");
        }
    }
}
