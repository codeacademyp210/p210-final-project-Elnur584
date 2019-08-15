namespace PatoFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReservationForm : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ReservationForm",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ReservDate = c.Int(nullable: false),
                        ReservTime = c.Int(nullable: false),
                        ReservPeople = c.Int(nullable: false),
                        ReservPhone = c.String(),
                        ReservName = c.String(),
                        ReservEmail = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ReservationForm");
        }
    }
}
