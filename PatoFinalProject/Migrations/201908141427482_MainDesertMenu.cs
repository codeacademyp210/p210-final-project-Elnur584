namespace PatoFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MainDesertMenu : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MenuMainDesert", "Food5Name", c => c.String());
            AddColumn("dbo.MenuMainDesert", "Food5Price", c => c.String());
            AddColumn("dbo.MenuMainDesert", "Food5Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MenuMainDesert", "Food5Description");
            DropColumn("dbo.MenuMainDesert", "Food5Price");
            DropColumn("dbo.MenuMainDesert", "Food5Name");
        }
    }
}
