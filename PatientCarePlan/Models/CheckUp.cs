using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PatientCarePlan.Models
{
    public class CheckUp
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Blood Pressure: ")]
        public string BloodPressure { get; set; }

        [Required]
        [Display(Name = "Body Temperature: ")]
        public string BodyTemperature { get; set; }

        [Required]
        [Display(Name = "Heart Rate: ")]
        public string HeartRate { get; set; }

        [Required]
        [Display(Name = "Respiratory Rate: ")]
        public string RespiratoryRate { get; set; }

        [Required]
        [Display(Name = "Type Of Prescription: ")]
        public string TypeOfPrescription { get; set; }

        [Required]
        [Display(Name = "Disease: ")]
        public string Disease { get; set; }

    }
}