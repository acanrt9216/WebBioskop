using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public async Task<IActionResult> Index()
        {
            var listSeries = _db.Series;
            var listGenres = _db.Genres;
            Collection col = new Collection();
            col.Series =await listSeries.ToListAsync();
            col.Genres =await listGenres.ToListAsync();

            return View(col);
        }
        [HttpGet]
        public async Task<IActionResult> Review(int id)
        {
            var lista = _db.Series.Where(m => m.serieId == id);
            var listGenres = _db.Genres;
            Collection col = new Collection();
            col.Series =await lista.ToListAsync();
            col.Genres =await listGenres.ToListAsync();
            return View(col);
        }
        [HttpGet]
        public async Task<IActionResult> Genre(int id)
        {
            ViewBag.id = id;
            var listSeries = _db.Series.Where(m => m.genre_ids.Contains(id.ToString()));
            var listGenres = _db.Genres;
            Collection col = new Collection();
            col.Series =await listSeries.ToListAsync();
            col.Genres =await listGenres.ToListAsync();
            return View(col);
        }
    }
}
