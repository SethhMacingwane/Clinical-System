using Hospital_App.CollectionViewModel;
using Hospital_App.Data;
using Hospital_App.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using static Hospital_App.Areas.Identity.Pages.Account.RegisterModel;


namespace Hospital_App.Controllers
{
    public class PatientController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly Microsoft.AspNetCore.Identity.UserManager<ApplicationUser> _userManager;


        public PatientController(ApplicationDbContext context, Microsoft.AspNetCore.Identity.UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult UpdateProfile(string id)
        {

            var patient = _context.Patients.SingleOrDefault(c => c.ApplicationUserId ==id);

            return View(patient);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateProfile(Patient model, string id)
        {
            var patient = _context.Patients.SingleOrDefault(c => c.ApplicationUserId == id);

            patient.FirstName = model.FirstName;
            patient.Surname = model.Surname;
            patient.EmailAddress = model.EmailAddress;
            patient.IDNumber = model.IDNumber;
            patient.Address = model.Address;
            patient.DateOfBirth = model.DateOfBirth;
            patient.Gender = model.Gender;
            patient.ContactNumber = model.ContactNumber;
            _context.SaveChanges();
            return View();
        }
    }
}
