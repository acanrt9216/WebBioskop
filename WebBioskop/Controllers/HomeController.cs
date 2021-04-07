using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using WebBioskop.Data;
using WebBioskop.Models;

namespace WebBioskop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger,ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            var countMovies = _db.Movies.Count();
            if (countMovies == 0)
            {
                writeMoviesToDB();
            }
            var listMovies = _db.Movies;
            var countGenresMovies = _db.Genres.Count();
            if (countGenresMovies == 0)
            {
                writeGenresMoviesToDB();
            }
            var listGenres = _db.Genres;
            var countSeries = _db.Series.Count();
            if (countSeries == 0)
            {
                writeSeriesToDB();
            }
            var listSeries = _db.Series;

            Collection col = new Collection();
            col.Movies =await listMovies.ToListAsync();
            col.Genres =await listGenres.ToListAsync();
            col.Series =await listSeries.ToListAsync();
            return View(col);
        }
        [HttpGet]
        public async Task<IActionResult> Search(string inputSrch)
        {
            ViewBag.inputSrch= inputSrch;
            var listMovies = _db.Movies.Where(mov => mov.title.Contains(inputSrch));
            var listSeries = _db.Series.Where(ser => ser.name.Contains(inputSrch));
            var listGenres = _db.Genres;
            Collection col = new Collection();
            col.Movies =await listMovies.ToListAsync();
            col.Series =await listSeries.ToListAsync();
            col.Genres =await listGenres.ToListAsync();
            return View(col);
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
        public void writeMoviesToDB()
        {
            string json;
            using (var reader = new StreamReader("Files/movies.json"))
            {
                json = reader.ReadToEnd();

                reader.Dispose();
                reader.Close();
            }
            var listMovies = JsonConvert.DeserializeObject<List<Movie>>(json);
            foreach (var item in listMovies)
            {
                try
                {
                    _db.Movies.Add(item);
                    _db.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void writeGenresMoviesToDB()
        {
            string json;
            using (var reader = new StreamReader("Files/genresMovies.json"))
            {
                json = reader.ReadToEnd();

                reader.Dispose();
                reader.Close();
            }
            var listGenresMovies = JsonConvert.DeserializeObject<List<Genre>>(json);
            foreach (var item in listGenresMovies)
            {
                try
                {
                    _db.Genres.Add(item);
                    _db.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public void writeSeriesToDB()
        {
            string json;
            using (var reader = new StreamReader("Files/series.json"))
            {
                json = reader.ReadToEnd();

                reader.Dispose();
                reader.Close();
            }
            var listSeries = JsonConvert.DeserializeObject<List<Serie>>(json);
            foreach (var item in listSeries)
            {
                try
                {
                    _db.Series.Add(item);
                    _db.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }

            }
        }
        public void updateGenres()
        {
            string json;
            using (var reader = new StreamReader("Files/movies.json"))
            {
                json = reader.ReadToEnd();

                reader.Dispose();
                reader.Close();
            }
            var listMovies = JsonConvert.DeserializeObject<List<Movie>>(json);
            foreach (var item in listMovies)
            {
                try
                {
                    
                    _db.Movies.Update(item);
                    _db.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
