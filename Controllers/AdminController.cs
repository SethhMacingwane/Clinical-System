using Hospital_App.CollectionViewModel;
using Hospital_App.Data;
using Hospital_App.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using static Hospital_App.Areas.Identity.Pages.Account.RegisterModel;

namespace Hospital_App.Controllers
{
    public class AdminController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _context;

        public AdminController(UserManager<ApplicationUser> userManager,RoleManager<IdentityRole> roleManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddNurse()
        {
            var collection = new NurseCollection
            {
                ApplicationUser = new InputModel(),
                Nurse = new Nurse(),

            };
            return View(collection);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddNurse(NurseCollection model)
        {
            var user = new ApplicationUser
            {
                UserName = model.ApplicationUser.UserName,
                Email = model.ApplicationUser.Email,
                UserRole = "Nurse",
            };

            var result = await _userManager.CreateAsync(user, model.ApplicationUser.Password);

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "Nurse");

                var nurse = new Nurse
                {
                    FirstName = model.Nurse.FirstName,
                    Surname = model.Nurse.Surname,
                    EmailAddress = model.ApplicationUser.Email,
                    IDNumber = model.Nurse.IDNumber,
                    ContactNumber = model.Nurse.ContactNumber,
                    Gender = model.Nurse.Gender,
                    ApplicationUserId = user.Id,

                };

                _context.Nurses.Add(nurse);
                await _context.SaveChangesAsync();

                return RedirectToAction("ListOfNurses");
            }

            return NotFound();
        }
        public async Task<IActionResult> ListOfNurses()
        {
            return View(await _context.Nurses.ToListAsync());
        }
        public IActionResult AddOfficeManager()
        {
            var collection = new OfficeManagerCollection
            {
                ApplicationUser = new InputModel(),
                OfficeManager = new OfficeManager(),

            };
            return View(collection);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOfficeManager(OfficeManagerCollection model)
        {
            var user = new ApplicationUser
            {
                UserName = model.ApplicationUser.UserName,
                Email = model.ApplicationUser.Email,
                UserRole = "OfficeManager",
            };

            var result = await _userManager.CreateAsync(user, model.ApplicationUser.Password);

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "OfficeManager");

                var officeManager = new OfficeManager
                {
                    FirstName = model.OfficeManager.FirstName,
                    Surname = model.OfficeManager.Surname,
                    EmailAddress = model.ApplicationUser.Email,
                    IDNumber = model.OfficeManager.IDNumber,
                    ContactNumber = model.OfficeManager.ContactNumber,
                    Gender = model.OfficeManager.Gender,
                    ApplicationUserId = user.Id,

                };

                _context.OfficeManagers.Add(officeManager);
                await _context.SaveChangesAsync();

                return RedirectToAction("ListOfOfficeManagers");
            }

            return NotFound();
        }
        public async Task<IActionResult> ListOfOfficeManagers()
        {
            return View(await _context.OfficeManagers.ToListAsync());
        }
    }

}
