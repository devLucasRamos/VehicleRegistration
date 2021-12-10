using Microsoft.AspNetCore.Mvc;

namespace VehicleRegistration.Controllers
{
    public class OwnersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
