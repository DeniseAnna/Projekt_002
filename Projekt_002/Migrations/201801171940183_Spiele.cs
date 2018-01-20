namespace Projekt_002.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Spiele : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Spieles", "Preis", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Spieles", "Preis");
        }
    }
}
