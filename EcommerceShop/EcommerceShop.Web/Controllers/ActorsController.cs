
using EcommerceShop.Business.Definitions;
using EcommerceShop.Business.Implementations.FileUploadService;
using EcommerceShop.Business.Implementations.Services;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceShop.Web.Controllers
{
    public class ActorsController : Controller
    {

        private readonly IActorsService _service;
        private readonly IFileUploadService _uploadService;

        public ActorsController(IActorsService service, IFileUploadService uploadService)
        {
            _service = service;
            _uploadService = uploadService;
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
        public async Task<IActionResult> Create([Bind("FullName,Bio")]Actor actor, IFormFile file)
        {
            if (!ModelState.IsValid || file == null)
            {
                return View(actor);
            }

            actor.ProfilePictureURL = file.FileName;

            await _uploadService.UploadFileAsync(file);
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
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,ProfilePictureURL,Bio")] Actor actor, IFormFile? file)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }

            if (file != null)
            {
                actor.ProfilePictureURL = file.FileName;
                await _uploadService.UploadFileAsync(file);
            }

            await _service.UpdateAsync(id, actor);
            return RedirectToAction(nameof(Index));
        }

        //Get: Actors/Delete/{id}
        public async Task<IActionResult> Delete(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);

            if (actorDetails == null)
            {
                return View("NotFound");
            }

            return View(actorDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if(actorDetails == null)
            {
                return View("NotFound");
            }
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
