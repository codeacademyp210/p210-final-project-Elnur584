namespace PatoFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContactForm : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContactForm",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ContactForm");
        }
    }
}
