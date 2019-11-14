using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_html.Models
{
    class Movie
    {
        public string Title { get; set; } = null;
        public string Genre { get; set; } = null;
        public int Duration { get; set; } = 0;
        public int Price { get; set; } = 0;

        public static List<Movie> MovieList = new List<Movie>();

        public Movie(string title, string genre, int duration, int price)
        {
            Title = title;
            Genre = genre;
            Duration = duration;
            Price = price;
        }
    }
}
