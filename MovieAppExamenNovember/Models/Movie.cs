using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAppExamenNovember.Models
{
    public class Movie
    {
        public string title { get; set; }
        public int episode_id { get; set; }
        public string opening_crawl { get; set; }
        public string director { get; set; }
        public string producer { get; set; }
        public string release_date { get; set; }
        public List<string> characters { get; set; } = new List<string>();
        public List<Character> characterObjects { get; set; } = new List<Character>();
        public List<string> planets { get; set; } = new List<string>();
        public List<string> starships { get; set; } = new List<string>();
        public List<string> vehicles { get; set; } = new List<string>();
        public List<string> species { get; set; } = new List<string>();
    }
}
