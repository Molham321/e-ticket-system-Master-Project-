﻿using EcommerceShop.Business.Definitions.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EcommerceShop.Web.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;

        public MoviesController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allMovies = await _context.Movies.ToListAsync();
            return View(allMovies);
        }
    }
}
