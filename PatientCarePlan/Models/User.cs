using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PatientCarePlan.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Name e.g. Jenny")]
        [StringLength(30, MinimumLength = 3)]
        [Display(Name = "Name:")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "ID:")]
        public int UserId { get; set; }

        [Required]
        [PasswordPropertyText]
        [Display(Name = "Password:")]
        public string password { get; set; }

        [DisplayName("Role")]
        [Display(Name = "Role:")]
        public string Role { get; set; }
    }
}