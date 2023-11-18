using EcommerceShop.Business.Definitions.Data;
using EcommerceShop.Business.Implementations.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EcommerceShop.Web.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMoviesService _service;

        public MoviesController(IMoviesService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            //var allMovies = await _context.Movies.Include(n => n.Cinema).OrderBy(n => n.Name).ToListAsync();
            var allMovies = await _service.GetAllAsync(n => n.Cinema);
            return View(allMovies);
        }
    }
}
