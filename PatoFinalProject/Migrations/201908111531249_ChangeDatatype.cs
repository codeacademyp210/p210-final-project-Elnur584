namespace PatoFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDatatype : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ContactForm", "Name", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.ContactForm", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.ContactForm", "Phone", c => c.String(nullable: false));
            AlterColumn("dbo.ReservationForm", "ReservPhone", c => c.String(nullable: false));
            AlterColumn("dbo.ReservationForm", "ReservName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.ReservationForm", "ReservEmail", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ReservationForm", "ReservEmail", c => c.String());
            AlterColumn("dbo.ReservationForm", "ReservName", c => c.String());
            AlterColumn("dbo.ReservationForm", "ReservPhone", c => c.String());
            AlterColumn("dbo.ContactForm", "Phone", c => c.String());
            AlterColumn("dbo.ContactForm", "Email", c => c.String());
            AlterColumn("dbo.ContactForm", "Name", c => c.String());
        }
    }
}
