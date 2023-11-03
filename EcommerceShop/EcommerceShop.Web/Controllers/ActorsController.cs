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
            var data = await _service.GetAll();
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
            //if(!ModelState.IsValid) Frage: das funktioniert nicht und gibt immer true aus. ich habe es getestet ohne und es fuktioniert ganu gut!
            //{
            //    return View(actor);
            //}
            _service.Add(actor);
            return RedirectToAction(nameof(Index));

        }
    }
}
