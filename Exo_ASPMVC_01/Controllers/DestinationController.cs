using Microsoft.AspNetCore.Mvc;

namespace Exo_ASPMVC_01.Controllers
{
    public class DestinationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail(int id)
        {
            return View();
        }
    }
}
