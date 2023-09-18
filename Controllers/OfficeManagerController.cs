using Microsoft.AspNetCore.Mvc;

namespace Hospital_App.Controllers
{
    public class OfficeManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
