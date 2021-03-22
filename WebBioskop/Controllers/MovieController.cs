using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Index()
        {
            IEnumerable<Movie> listMovies = _db.Movies;
            IEnumerable<Genre> listGenres = _db.Genres;
            Collection col = new Collection();
            col.Movies=listMovies;
            col.Genres=listGenres;
            return View(col); ;
        }
        [HttpGet]
        public IActionResult Review(int id)
        {
            IEnumerable<Movie> lista= _db.Movies.Where(m => m.movieId == id);
            IEnumerable<Genre> listGenres = _db.Genres;
            Collection col = new Collection();
            col.Movies = lista;
            col.Genres = listGenres;
            return View(col);
        }
        [HttpGet]
        public IActionResult Genre(int id)
        {
            ViewBag.id = id;
            IEnumerable<Movie> listMovies = _db.Movies.Where(m => m.genre_ids.Contains(id.ToString()));
            IEnumerable<Genre> listGenres = _db.Genres;
            Collection col = new Collection();
            col.Movies = listMovies;
            col.Genres = listGenres;
            return View(col);
        }
        
        
    }
}
