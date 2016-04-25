namespace DeversWeWatch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ladetillbegränsningar : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ReportModels", "Förnamn", c => c.String(maxLength: 50));
            AlterColumn("dbo.ReportModels", "Efternamn", c => c.String(maxLength: 50));
            AlterColumn("dbo.ReportModels", "Email", c => c.String(maxLength: 75));
            AlterColumn("dbo.ReportModels", "Telefonnummer", c => c.String(maxLength: 50));
            AlterColumn("dbo.ReportModels", "Plats_Adress", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.ReportModels", "Meddelande", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ReportModels", "Meddelande", c => c.String(nullable: false));
            AlterColumn("dbo.ReportModels", "Plats_Adress", c => c.String(nullable: false));
            AlterColumn("dbo.ReportModels", "Telefonnummer", c => c.String());
            AlterColumn("dbo.ReportModels", "Email", c => c.String());
            AlterColumn("dbo.ReportModels", "Efternamn", c => c.String());
            AlterColumn("dbo.ReportModels", "Förnamn", c => c.String());
        }
    }
}
