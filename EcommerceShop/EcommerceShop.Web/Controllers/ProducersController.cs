
using EcommerceShop.Business.Implementations.Services;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceShop.Web.Controllers
{
    public class ProducersController : Controller
    {
        private readonly IProducersService _service;

        public ProducersController(IProducersService service)
        {
            _service = service;
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
    }
}
