using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PatientCarePlan.Models
{
    public class BodyMeasurement
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Height: ")]
        public string Height { get; set; }

        [Required]
        [Display(Name = "Weight: ")]
        public string Weight { get; set; }

        [Required]
        [Display(Name = "Body Fat Percentage: ")]
        public string BodyFatPercent { get; set; }

        [Required]
        [Display(Name = "Body Mass Index: ")]
        public string BodyMassIndex { get; set; }

        [Required]
        [Display(Name = "Lean Body Mass: ")]
        public string LeanBodyMass { get; set; }

        [Required]
        [Display(Name = "Waist Circumference: ")]
        public string WaistCircumference { get; set; }
    }
}