using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PatientCarePlan.Models
{
    public class Activity
    {
        [Key]
        public string Date { get; set; }
        public string Distance { get; set; }
        public string Steps { get; set; }
        public string Flights { get; set; }
    }
}