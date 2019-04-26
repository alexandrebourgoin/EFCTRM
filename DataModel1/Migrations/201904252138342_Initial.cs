namespace DataModel1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ContactFirstName = c.String(),
                        ContactLastName = c.String(),
                        Gender = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Markets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MarketName = c.String(),
                        MarketType = c.String(),
                        CreatedContactId = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedContactId = c.String(),
                        UpdatedDate = c.DateTime(nullable: false),
                        CreatedContact_Id = c.Int(nullable: false),
                        UpdatedContact_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contacts", t => t.CreatedContact_Id, cascadeDelete: true)
                .ForeignKey("dbo.Contacts", t => t.UpdatedContact_Id)
                .Index(t => t.CreatedContact_Id)
                .Index(t => t.UpdatedContact_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Markets", "UpdatedContact_Id", "dbo.Contacts");
            DropForeignKey("dbo.Markets", "CreatedContact_Id", "dbo.Contacts");
            DropIndex("dbo.Markets", new[] { "UpdatedContact_Id" });
            DropIndex("dbo.Markets", new[] { "CreatedContact_Id" });
            DropTable("dbo.Markets");
            DropTable("dbo.Contacts");
        }
    }
}
