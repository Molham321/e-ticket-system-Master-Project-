
using EcommerceShop.Business.Definitions;
using EcommerceShop.Business.Implementations.FileUploadService;
using EcommerceShop.Business.Implementations.Services;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceShop.Web.Controllers
{
    public class CinemasController : Controller
    {
        private readonly ICinemasService _service;
        private readonly IFileUploadService _uploadService;

        public static string? FilePath;

        public CinemasController(ICinemasService service, IFileUploadService uploadService)
        {
            _service = service;
            _uploadService = uploadService;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        //Get: Cinemas/Create
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name,Description")] Cinema cinema, IFormFile file)
        {
            if (!ModelState.IsValid || file == null)
            {
                ModelState.AddModelError("file", "Please upload a logo.");
                return View(cinema);
            }

            cinema.Logo = file.FileName;

            await _uploadService.UploadFileAsync(file);
            await _service.AddAsync(cinema);
            return RedirectToAction(nameof(Index));
        }


        // Get: Cinemas/Details/{id}
        public async Task<IActionResult> Details(int id)
        {
            var cinemaDetails = await _service.GetByIdAsync(id);

            if (cinemaDetails == null)
            {
                return View("NotFound");
            }

            return View(cinemaDetails);
        }

        //Get: Cinemas/Edit/{id}
        public async Task<IActionResult> Edit(int id)
        {
            var cinemaDetails = await _service.GetByIdAsync(id);

            if (cinemaDetails == null)
            {
                return View("NotFound");
            }

            return View(cinemaDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Logo,Name,Description")] Cinema cinema, IFormFile? file)
        {
            if (!ModelState.IsValid)
            {
                return View(cinema);
            }

            if(file != null)
            {
                cinema.Logo = file.FileName;
                await _uploadService.UploadFileAsync(file);
            }

            await _service.UpdateAsync(id, cinema);
            return RedirectToAction(nameof(Index));
        }

        //Get: Actors/Delete/{id}
        public async Task<IActionResult> Delete(int id)
        {
            var cinemaDetails = await _service.GetByIdAsync(id);

            if (cinemaDetails == null)
            {
                return View("NotFound");
            }

            return View(cinemaDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cinemaDetails = await _service.GetByIdAsync(id);
            if (cinemaDetails == null)
            {
                return View("NotFound");
            }
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
