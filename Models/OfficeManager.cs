using Hospital_App.Data;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Hospital_App.Models
{
    public class OfficeManager
    {
        public int Id { get; set; }
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
