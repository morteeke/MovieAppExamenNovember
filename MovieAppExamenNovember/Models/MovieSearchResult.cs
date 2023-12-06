using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAppExamenNovember.Models
{
    public class MovieSearchResult
    {
        public List<Movie> results { get; set; } = new List<Movie>();
        public int count { get; set; }

    }
}
