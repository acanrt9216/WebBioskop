using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebBioskop.Models
{
    public class Genre
    {
        [Key]
        public int genreId { get; set; }
        public int id { get; set; }
        public string name { get; set; }
    }
}
