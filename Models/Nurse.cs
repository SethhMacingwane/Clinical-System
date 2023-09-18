using Hospital_App.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace Hospital_App.Models
{
    public class Nurse
    {
        public int NurseID { get; set; }
        public ApplicationUser ApplicationyUser { get; set; }
        public string ApplicationUserId { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        public string Surname { get; set; }
        [Display(Name = "ID Number")]
        public int IDNumber { get; set; }
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
        [Display(Name = "Contact Number")]
        public string ContactNumber { get; set; }
        public string Gender { get; set; }
  
    }
}
