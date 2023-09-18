using Hospital_App.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;

namespace Hospital_App.Models
{
    public class Patient
    {
        public int PatientID { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public string ApplicationUserId { get; set; }

        [Display(Name = "Fist Name")]
        public string FirstName { get; set; }
        public string Surname { get; set; }
        [Display(Name = "ID Number")]
        public string IDNumber { get; set; }
        public string Address { get; set; }
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
        [Display(Name = "Contact Number")]
        public string ContactNumber { get; set; }
        public string Gender { get; set; }
        [Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }
    }


}
