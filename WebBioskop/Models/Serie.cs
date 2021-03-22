using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebBioskop.Models
{
    public class Serie
    {
        [Key]
        public int serieId { get; set; }
        public string backdrop_path { get; set; }
        public string genre_ids { get; set; }
        public DateTime first_air_date { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string original_language { get; set; }
        public string original_name { get; set; }
        public string overview { get; set; }
        public double popularity { get; set; }
        public string poster_path { get; set; }
        public double vote_average { get; set; }
        public int vote_count { get; set; }
        public string type { get; set; }
    }
}
