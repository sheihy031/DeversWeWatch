namespace DeversWeWatch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial_create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ReportModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Förnamn = c.String(maxLength: 50),
                        Efternamn = c.String(maxLength: 50),
                        Email = c.String(maxLength: 75),
                        Telefonnummer = c.String(maxLength: 50),
                        Personnummer = c.String(),
                        Datum = c.DateTime(nullable: false),
                        Plats_Adress = c.String(nullable: false, maxLength: 50),
                        Kategori = c.Int(nullable: false),
                        Meddelande = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ReportModels");
        }
    }
}
