namespace Lib4U.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPhoneToReaders : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Readers", "MobilePhone", c => c.String(nullable: false));
            AlterColumn("dbo.Readers", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Readers", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Readers", "LastName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Readers", "LastName", c => c.String());
            AlterColumn("dbo.Readers", "FirstName", c => c.String());
            AlterColumn("dbo.Readers", "Address", c => c.String());
            DropColumn("dbo.Readers", "MobilePhone");
        }
    }
}
