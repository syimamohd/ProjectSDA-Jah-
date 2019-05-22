using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PatientCarePlan.Models
{
    public class Nutrition
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Caffeine: ")]
        public string Caffeine { get; set; }

        [Required]
        [Display(Name = "Calcium: ")]
        public string Calcium { get; set; }

        [Required]
        [Display(Name = "Carbohydrates: ")]
        public string Carbohydrates { get; set; }

        [Required]
        [Display(Name = "Fibre: ")]
        public string Fibre { get; set; }

        [Required]
        [Display(Name = "Protein: ")]
        public string Protein { get; set; }

        [Required]
        [Display(Name = "Saturated Fat: ")]
        public string SaturatedFat { get; set; }

        [Required]
        [Display(Name = "Water: ")]
        public string Water { get; set; }
    }

}