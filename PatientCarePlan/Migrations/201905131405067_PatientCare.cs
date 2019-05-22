namespace PatientCarePlan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PatientCare : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CheckUps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BloodPressure = c.String(nullable: false),
                        BodyTemperature = c.String(nullable: false),
                        HeartRate = c.String(nullable: false),
                        RespiratoryRate = c.String(nullable: false),
                        TypeOfPrescription = c.String(nullable: false),
                        Disease = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 30),
                        Email = c.String(nullable: false),
                        RetypeEmail = c.String(nullable: false),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.CheckUps");
        }
    }
}
