namespace Lib4U.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddQuantityToBooks : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Quantity", c => c.Int(nullable: false));
            AddColumn("dbo.Books", "AvailableQuantity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "AvailableQuantity");
            DropColumn("dbo.Books", "Quantity");
        }
    }
}
