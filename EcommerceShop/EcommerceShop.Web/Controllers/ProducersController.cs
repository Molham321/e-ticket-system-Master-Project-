
using EcommerceShop.Business.Definitions;
using EcommerceShop.Business.Implementations.FileUploadService;
using EcommerceShop.Business.Implementations.Services;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceShop.Web.Controllers
{
    public class ProducersController : Controller
    {
        private readonly IProducersService _service;
        private readonly IFileUploadService _uploadService;


        public ProducersController(IProducersService service, IFileUploadService uploadService)
        {
            _service = service;
            _uploadService = uploadService;

        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        // Get: Producers/Details/{id}
        public async Task<IActionResult> Details(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);

            if(producerDetails == null)
            {
                return View("NotFound");
            }

            return View(producerDetails);
        }

        //Get: Producers/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,Bio")] Producer producer, IFormFile file)
        {
            if (!ModelState.IsValid || file == null)
            {
                return View(producer);
            }

            producer.ProfilePictureURL = file.FileName;

            await _uploadService.UploadFileAsync(file);
            await _service.AddAsync(producer);
            return RedirectToAction(nameof(Index));
        }

        //Get: Producers/Edit/{id}
        public async Task<IActionResult> Edit(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if(producerDetails == null)
            {
                return View("NotFound");
            }

            return View(producerDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,ProfilePictureURL,Bio")] Producer producer, IFormFile? file)
        {
            if (!ModelState.IsValid)
            {
                return View(producer);
            }

            if (file != null)
            {
                producer.ProfilePictureURL = file.FileName;
                await _uploadService.UploadFileAsync(file);
            }

            await _service.UpdateAsync(id, producer);
            return RedirectToAction(nameof(Index));
        }

        //Get: Producers/Delete/{id}
        public async Task<IActionResult> Delete(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null)
            {
                return View("NotFound");
            }

            return View(producerDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null)
            {
                return View("NotFound");
            }
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
