namespace Lib4U.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterUserIdOnReaders : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Readers", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Readers", new[] { "UserId" });
            AlterColumn("dbo.Readers", "UserId", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Readers", "UserId");
            AddForeignKey("dbo.Readers", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Readers", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Readers", new[] { "UserId" });
            AlterColumn("dbo.Readers", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Readers", "UserId");
            AddForeignKey("dbo.Readers", "UserId", "dbo.AspNetUsers", "Id");
        }
    }
}
