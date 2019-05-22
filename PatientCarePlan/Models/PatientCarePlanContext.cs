using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PatientCarePlan.Models
{
    public class PatientCarePlanContext : DbContext
    {
        public DbSet<CheckUp> CheckUps { get; set; }
        public DbSet<User> Users { get; set; }

        public System.Data.Entity.DbSet<PatientCarePlan.Models.Nutrition> Nutritions { get; set; }

        public System.Data.Entity.DbSet<PatientCarePlan.Models.BodyMeasurement> BodyMeasurements { get; set; }

        public System.Data.Entity.DbSet<PatientCarePlan.Models.Activity> Activities { get; set; }
    }
}
