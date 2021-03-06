namespace Lib4U.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReaders : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Readers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        UserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Readers", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Readers", new[] { "UserId" });
            DropTable("dbo.Readers");
        }
    }
}
