namespace DeversWeWatch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ReportModels", "Email", c => c.String(maxLength: 75));
            AlterColumn("dbo.ReportModels", "Telefonnummer", c => c.String(maxLength: 50));
            AlterColumn("dbo.ReportModels", "Personnummer", c => c.String());
            AlterColumn("dbo.ReportModels", "Plats_Adress", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.ReportModels", "Meddelande", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ReportModels", "Meddelande", c => c.String(nullable: false));
            AlterColumn("dbo.ReportModels", "Plats_Adress", c => c.String(nullable: false));
            AlterColumn("dbo.ReportModels", "Personnummer", c => c.String(maxLength: 10));
            AlterColumn("dbo.ReportModels", "Telefonnummer", c => c.String());
            AlterColumn("dbo.ReportModels", "Email", c => c.String());
        }
    }
}
