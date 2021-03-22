using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebBioskop.Data;
using WebBioskop.Models;

namespace WebBioskop
{
    public class Program
    {
        public static ApplicationDbContext _db;
        public static void Main(string[] args)
        {
            
            if (!File.Exists("Files/popular.json"))
            {
                writeToFilePopular();
            }
            
            if (!File.Exists("Files/newMovies.json"))
            {
                writeToFileNewMovies();
            }
            if (!File.Exists("Files/upcomingMovies.json"))
            {
                writeToFileUpcomingMovies();
            }
            if (!File.Exists("Files/popularSeries.json"))
            {
                writeToFilePopularSeries();
            }
            if (!File.Exists("Files/topRatedSeries.json"))
            {
                writeToFileTopRatedSeries();
            }
            if (!File.Exists("Files/upcomingSeries.json"))
            {
                writeToFileUpcomingSeries();
            }
            if (!File.Exists("Files/genresMovies.json"))
            {
                writeToFileGenresMovies();
            }
            

            CreateHostBuilder(args).Build().Run();
        }

        

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
        
        public static async void writeToFilePopular()
        {
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(@"https://api.themoviedb.org/3/movie/popular?api_key=77eaf5319e95020f0c433995370d189f");
            using(StreamWriter file = File.CreateText(@"C:\Users\AcaPC\source\repos\WebBioskop\WebBioskop\Files\popular.json"))
            {
                
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, response);
            }
        }
       
        public static async void writeToFileNewMovies()
        {
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(@"https://api.themoviedb.org/3/movie/now_playing?api_key=77eaf5319e95020f0c433995370d189f");
            using (StreamWriter file = File.CreateText(@"C:\Users\AcaPC\source\repos\WebBioskop\WebBioskop\Files\newMovies.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, response);
            }
        }
        public static async void writeToFileUpcomingMovies()
        {
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(@"https://api.themoviedb.org/3/movie/upcoming?api_key=77eaf5319e95020f0c433995370d189f");
            File.WriteAllText("Files/upcomingMovies.json", response);
        }

        public static async void writeToFilePopularSeries()
        {
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(@"https://api.themoviedb.org/3/tv/popular?api_key=77eaf5319e95020f0c433995370d189f");
            File.WriteAllText("Files/popularSeries.json", response);
        }
        public static async void writeToFileTopRatedSeries()
        {
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(@"https://api.themoviedb.org/3/tv/top_rated?api_key=77eaf5319e95020f0c433995370d189f");
            File.WriteAllText("Files/topRatedSeries.json", response);
        }
        public static async void writeToFileUpcomingSeries()
        {
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(@"https://api.themoviedb.org/3/tv/on_the_air?api_key=77eaf5319e95020f0c433995370d189f");
            File.WriteAllText("Files/upcomingSeries.json", response);
        }
        public static async void writeToFileGenresMovies()
        {
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(@"https://api.themoviedb.org/3/genre/movie/list?api_key=77eaf5319e95020f0c433995370d189f");
            File.WriteAllText("Files/genresMovies.json", response);
        }
        
        
        
    }
}
