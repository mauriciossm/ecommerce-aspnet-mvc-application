using eTickets.Data;
using eTickets.Data.Services.Interfaces;
using eTickets.Models;
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

        //GET: Cinemas/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Logo, Name, Description")] CinemaModel cinema)
        {
            if (!ModelState.IsValid) return View(cinema);
            await _cinemasService.AddAsync(cinema);
            return RedirectToAction(nameof(Index));
        }

        //GET: Cinemas/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var cinemaDetails = await _cinemasService.GetByIdAsync(id);
            if (cinemaDetails == null) return View("NotFound");
            return View(cinemaDetails);
        }
        //GET: Cinemas/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var cinemaDetails = await _cinemasService.GetByIdAsync(id);
            if (cinemaDetails == null) return View("NotFound");
            return View(cinemaDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, Logo, Name, Description")] CinemaModel cinema)
        {
            if (!ModelState.IsValid) return View(cinema);
            await _cinemasService.UpdateAsync(id, cinema);
            return RedirectToAction(nameof(Index));
        }
    }
}
