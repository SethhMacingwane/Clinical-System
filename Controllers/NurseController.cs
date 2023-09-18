using Microsoft.AspNetCore.Mvc;

namespace Hospital_App.Controllers
{
    public class NurseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
