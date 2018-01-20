namespace Projekt_002.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kundes",
                c => new
                {
                    benutzername = c.String(nullable: false, maxLength: 128),
                    email = c.String(nullable: false, maxLength: 128),
                    passwort = c.String(nullable: false, maxLength: 128),
                    strasse = c.String(nullable: false, maxLength: 128),
                    plz = c.String(nullable: false, maxLength: 128),
                    ort = c.String(nullable: false, maxLength: 128),
                    land = c.String(nullable: false, maxLength: 128),
                    Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.benutzername);
            
            CreateTable(
                "dbo.Spieles",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        Genre = c.String(),
                        Bewertung = c.Int(nullable: false),
                        Verfuegbarkeit = c.Boolean(nullable: false),
                        USK = c.Int(nullable: false),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Name);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Spieles");
            DropTable("dbo.Kundes");
        }
    }
}
