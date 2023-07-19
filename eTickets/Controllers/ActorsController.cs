using eTickets.Data;
using eTickets.Data.Services.Interfaces;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        //Get: Actors/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")]ActorModel actor)
        {
            if(!ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }

        //Get: Actors/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var ActorsDetails = await _service.GetByIdAsync(id);

            if (ActorsDetails == null) return View("NotFound");
            return View(ActorsDetails);
            
        }

        //Get: Actors/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var ActorsDetails = await _service.GetByIdAsync(id);

            if (ActorsDetails == null) return View("NotFound");

            return View(ActorsDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, FullName,ProfilePictureURL,Bio")] ActorModel actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.UpdateAsync(id, actor);
            return RedirectToAction(nameof(Index));
        }
    }
}
