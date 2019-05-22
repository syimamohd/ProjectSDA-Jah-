namespace PatientCarePlan.Migrations
{
    using PatientCarePlan.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PatientCarePlan.Models.PatientCarePlanContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "PatientCarePlan.Models.PatientCarePlanContext";
        }

        protected override void Seed(PatientCarePlan.Models.PatientCarePlanContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Users.AddOrUpdate(
                p => p.UserId,
                new User { UserName = "Ali", UserId = 1, password = "123", Role = "Doctor"},
                new User { UserName = "Abu", UserId = 2, password = "456", Role = "Patient" }
                );
        }
    }
}
