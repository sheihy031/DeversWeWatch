namespace DeversWeWatch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ReportModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Förnamn = c.String(),
                        Efternamn = c.String(),
                        Email = c.String(),
                        Telefonnummer = c.String(),
                        Personnummer = c.String(maxLength: 10),
                        Datum = c.DateTime(nullable: false),
                        Plats_Adress = c.String(nullable: false),
                        Kategori = c.Int(nullable: false),
                        Meddelande = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ReportModels");
        }
    }
}
