namespace PatoFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MenuContent : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MenuDrinkStarers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FoodKind = c.String(),
                        Food1Name = c.String(),
                        Food1Price = c.String(),
                        Food1Description = c.String(),
                        Food2Name = c.String(),
                        Food2Price = c.String(),
                        Food2Description = c.String(),
                        Food3Name = c.String(),
                        Food3Price = c.String(),
                        Food3Description = c.String(),
                        Food4Name = c.String(),
                        Food4Price = c.String(),
                        Food4Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MenuMainDesert",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FoodKind = c.String(),
                        Food1Name = c.String(),
                        Food1Price = c.String(),
                        Food1Description = c.String(),
                        Food2Name = c.String(),
                        Food2Price = c.String(),
                        Food2Description = c.String(),
                        Food3Name = c.String(),
                        Food3Price = c.String(),
                        Food3Description = c.String(),
                        Food4Name = c.String(),
                        Food4Price = c.String(),
                        Food4Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MenuMainDesert");
            DropTable("dbo.MenuDrinkStarers");
        }
    }
}
