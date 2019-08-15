namespace PatoFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SettingLevel : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Settings", "Menu1");
            DropColumn("dbo.Settings", "Menu2");
            DropColumn("dbo.Settings", "Menu3");
            DropColumn("dbo.Settings", "Menu4");
            DropColumn("dbo.Settings", "Menu5");
            DropColumn("dbo.Settings", "Menu6");
            DropColumn("dbo.Settings", "Menu7");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Settings", "Menu7", c => c.String());
            AddColumn("dbo.Settings", "Menu6", c => c.String());
            AddColumn("dbo.Settings", "Menu5", c => c.String());
            AddColumn("dbo.Settings", "Menu4", c => c.String());
            AddColumn("dbo.Settings", "Menu3", c => c.String());
            AddColumn("dbo.Settings", "Menu2", c => c.String());
            AddColumn("dbo.Settings", "Menu1", c => c.String());
        }
    }
}
