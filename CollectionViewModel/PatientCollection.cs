using Hospital_App.Models;
using static Hospital_App.Areas.Identity.Pages.Account.RegisterModel;

namespace Hospital_App.CollectionViewModel
{
    public class PatientCollection
    {
        public InputModel ApplicationUser { get; set; }
        public Patient Patient { get; set; }
        public string ReturnUrl { get; set; }
    }
}
