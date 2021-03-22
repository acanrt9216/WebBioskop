using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebBioskop.Data;
using WebBioskop.Models;

namespace WebBioskop.Controllers
{
    public class SerieController : Controller
    {
        private readonly ApplicationDbContext _db;
        public SerieController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Serie> listSeries = _db.Series;
            IEnumerable<Genre> listGenres = _db.Genres;
            Collection col = new Collection();
            col.Series = listSeries;
            col.Genres = listGenres;

            return View(col);
        }
        [HttpGet]
        public IActionResult Review(int id)
        {
            IEnumerable<Serie> lista = _db.Series.Where(m => m.serieId == id);
            IEnumerable<Genre> listGenres = _db.Genres;
            Collection col = new Collection();
            col.Series = lista;
            col.Genres = listGenres;
            return View(col);
        }
        [HttpGet]
        public IActionResult Genre(int id)
        {
            ViewBag.id = id;
            IEnumerable<Serie> listSeries = _db.Series.Where(m => m.genre_ids.Contains(id.ToString()));
            IEnumerable<Genre> listGenres = _db.Genres;
            Collection col = new Collection();
            col.Series = listSeries;
            col.Genres = listGenres;
            return View(col);
        }
    }
}
