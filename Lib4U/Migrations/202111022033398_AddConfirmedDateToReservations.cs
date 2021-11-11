namespace Lib4U.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddConfirmedDateToReservations : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservations", "ConfirmedDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reservations", "ConfirmedDate");
        }
    }
}
