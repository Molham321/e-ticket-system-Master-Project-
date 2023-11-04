using EcommerceShop.Business.Definitions;
using EcommerceShop.Business.Definitions.Data;
using EcommerceShop.Business.Implementations;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceShop.Web.Controllers
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
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")]Actor actor)
        {
            if (!ModelState.IsValid) //Frage: das funktioniert nicht und gibt immer true aus.ich habe es getestet ohne und es fuktioniert ganu gut!
            {
                return View(actor);
            }
            await _service.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }

        // Get: Actors/Details/{id}
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);

            if(actorDetails == null)
            {
                return View("NotFound");
            }

            return View(actorDetails);
        }

        //Get: Actors/Edit/{id}
        public async Task<IActionResult> Edit(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);

            if (actorDetails == null)
            {
                return View("NotFound");
            }

            return View(actorDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,ProfilePictureURL,Bio")] Actor actor)
        {
            if (!ModelState.IsValid) //Frage: das funktioniert nicht und gibt immer true aus.ich habe es getestet ohne und es fuktioniert ganu gut!
            {
                //foreach (var modelState in ModelState.Values)
                //{
                //    foreach (var error in modelState.Errors)
                //    {
                //        // Log or debug the error messages
                //        Console.WriteLine(error.ErrorMessage);
                //    }
                //}

                return View(actor);
            }
            await _service.UpdateAsync(id, actor);
            return RedirectToAction(nameof(Index));
        }
    }
}
