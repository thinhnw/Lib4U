namespace Lib4U.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.IO;

    public partial class RunSqlScript : DbMigration
    {
        public override void Up()
        {
            var sqlFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data.sql");
            Sql(File.ReadAllText(sqlFile));

        }
        
        public override void Down()
        {

        }
    }
}
