namespace Lib4U.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBookSuggestions : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BookSuggestions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Author = c.String(nullable: false),
                        Title = c.String(nullable: false),
                        Publisher = c.String(nullable: false),
                        PublishcationDate = c.DateTime(nullable: false),
                        ReasonForSuggestion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BookSuggestions");
        }
    }
}
