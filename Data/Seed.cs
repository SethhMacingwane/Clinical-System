using Hospital_App.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Hospital_App.Data
{
    public class Seed
    {
        public static async Task SeedRolesAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole(UserRoles.Patient.ToString()));
            await roleManager.CreateAsync(new IdentityRole(UserRoles.Doctor.ToString()));
            await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(UserRoles.Nurse.ToString()));
        }
    }
}
