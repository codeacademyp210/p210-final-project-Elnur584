namespace PatoFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReservArea : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ReservationForm", "ReservDate");
            DropColumn("dbo.ReservationForm", "ReservTime");
            DropColumn("dbo.ReservationForm", "ReservPeople");
            DropColumn("dbo.ReservationForm", "ReservPhone");
            DropColumn("dbo.ReservationForm", "ReservName");
            DropColumn("dbo.ReservationForm", "ReservEmail");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ReservationForm", "ReservEmail", c => c.String());
            AddColumn("dbo.ReservationForm", "ReservName", c => c.String());
            AddColumn("dbo.ReservationForm", "ReservPhone", c => c.String());
            AddColumn("dbo.ReservationForm", "ReservPeople", c => c.Int(nullable: false));
            AddColumn("dbo.ReservationForm", "ReservTime", c => c.Int(nullable: false));
            AddColumn("dbo.ReservationForm", "ReservDate", c => c.Int(nullable: false));
        }
    }
}
