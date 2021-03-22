using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBioskop.Models
{
    public class Collection
    {
        public IEnumerable<Movie> Movies { get; set; }
        public IEnumerable<Serie> Series { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}
