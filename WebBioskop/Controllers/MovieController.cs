using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBioskop.Data;
using WebBioskop.Models;

namespace WebBioskop.Controllers
{
    public class MovieController : Controller
    {
        private readonly ApplicationDbContext _db;
        public MovieController(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            var listMovies = _db.Movies;
            var listGenres = _db.Genres;

            Collection col = new Collection();
            col.Movies=await listMovies.ToListAsync();
            col.Genres=await listGenres.ToListAsync();
            return View(col);
        }
        [HttpGet]
        public async Task<IActionResult> Review(int id)
        {
            var lista= _db.Movies.Where(m => m.movieId == id);
            var listGenres = _db.Genres;
            Collection col = new Collection();
            col.Movies =await lista.ToListAsync();
            col.Genres =await listGenres.ToListAsync();
            return View(col);
        }
        [HttpGet]
        public async Task<IActionResult> Genre(int id)
        {
            ViewBag.id = id;
            var listMovies = _db.Movies.Where(m => m.genre_ids.Contains(id.ToString()));
            var listGenres = _db.Genres;
            Collection col = new Collection();
            col.Movies =await listMovies.ToListAsync();
            col.Genres =await listGenres.ToListAsync();
            return View(col);
        }
        
    }
}
