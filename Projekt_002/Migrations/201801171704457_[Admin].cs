namespace Projekt_002.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Admin : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Benutzername = c.String(nullable: false, maxLength: 128),
                        Email = c.String(),
                        Passwort = c.String(),
                        Plz = c.String(),
                        Ort = c.String(),
                        Land = c.String(),
                    })
                .PrimaryKey(t => t.Benutzername);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Admins");
        }
    }
}
