using eTickets.Data;
using eTickets.Data.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class CinemasController : Controller
    {

        private readonly ICinemasService _cinemasService;

        public CinemasController(ICinemasService cinemasService)
        {
            _cinemasService = cinemasService;
        }

        public async Task<IActionResult> Index()
        {
            var allCinemas = await _cinemasService.GetAllAsync();
            return View(allCinemas);
        }
    }
}
