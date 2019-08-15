namespace PatoFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReservTableUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ReservationForm", "ReservDate", c => c.String());
            AddColumn("dbo.ReservationForm", "ReservTime", c => c.String());
            AddColumn("dbo.ReservationForm", "ReservPeople", c => c.String());
            AddColumn("dbo.ReservationForm", "ReservPhone", c => c.String());
            AddColumn("dbo.ReservationForm", "ReservName", c => c.String());
            AddColumn("dbo.ReservationForm", "ReservEmail", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ReservationForm", "ReservEmail");
            DropColumn("dbo.ReservationForm", "ReservName");
            DropColumn("dbo.ReservationForm", "ReservPhone");
            DropColumn("dbo.ReservationForm", "ReservPeople");
            DropColumn("dbo.ReservationForm", "ReservTime");
            DropColumn("dbo.ReservationForm", "ReservDate");
        }
    }
}
