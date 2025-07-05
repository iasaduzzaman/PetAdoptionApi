namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdoptionApplications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Applicationdate = c.DateTime(nullable: false),
                        PetId = c.Int(nullable: false),
                        ApplicationStatus = c.String(nullable: false, maxLength: 20),
                        ReviewDate = c.DateTime(),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pets", t => t.PetId, cascadeDelete: true)
                .Index(t => t.PetId);
            
            CreateTable(
                "dbo.Pets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Species = c.String(nullable: false),
                        Breed = c.String(nullable: false),
                        Gender = c.String(nullable: false),
                        Description = c.String(),
                        Status = c.String(),
                        CreatedAt = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ApplicationHistories",
                c => new
                    {
                        HistoryId = c.Int(nullable: false, identity: true),
                        ApplicationId = c.Int(nullable: false),
                        ApplicationStatus = c.String(),
                        ChangedBy = c.Int(nullable: false),
                        ChangedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.HistoryId)
                .ForeignKey("dbo.AdoptionApplications", t => t.ApplicationId, cascadeDelete: true)
                .Index(t => t.ApplicationId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Uname = c.String(nullable: false, maxLength: 128),
                        Password = c.String(nullable: false, maxLength: 20),
                        Name = c.String(nullable: false, maxLength: 20),
                        type = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Uname);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ApplicationHistories", "ApplicationId", "dbo.AdoptionApplications");
            DropForeignKey("dbo.AdoptionApplications", "PetId", "dbo.Pets");
            DropIndex("dbo.ApplicationHistories", new[] { "ApplicationId" });
            DropIndex("dbo.AdoptionApplications", new[] { "PetId" });
            DropTable("dbo.Users");
            DropTable("dbo.ApplicationHistories");
            DropTable("dbo.Pets");
            DropTable("dbo.AdoptionApplications");
        }
    }
}
