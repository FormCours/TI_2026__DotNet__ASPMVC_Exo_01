using Exo_ASPMVC_01.Models;
using Exo_ASPMVC_01.Services;
using Microsoft.AspNetCore.Mvc;

namespace Exo_ASPMVC_01.Controllers
{
    public class DestinationController : Controller
    {
        private readonly TravelService _travelService;
        public DestinationController()
        {
            _travelService = new TravelService();
        }

        public IActionResult Index()
        {
            IEnumerable<Travel> travels = _travelService.GetAll();
            return View(travels);
        }

        public IActionResult Detail(int id)
        {
            Travel? travel = _travelService.GetById(id);
            return View(travel);
        }

      
    }
}
