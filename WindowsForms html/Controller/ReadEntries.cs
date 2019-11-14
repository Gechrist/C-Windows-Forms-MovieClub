using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForms_html.Models;



namespace WindowsForms_html.Controller
{
    class ReadEntries
    {
        
        public static List<int> SearchClients = new List<int>();
        public static List<int> SearchRentals = new List<int>();
        public static List<int> SearchMovies = new List<int>();


        public static List<Client> AllClients()
        {
            string json = System.IO.File.ReadAllText(@"C:\Users\George\Desktop\Clients.json");
            var clients = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Client>>(json);
            return clients;
        }

        public static List<Movie> AllMovies()
        {
            string json = System.IO.File.ReadAllText(@"C:\Users\George\Desktop\Movies.json");
            var movies = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Movie>>(json);
            return movies;
        }

        public static List<Rental> AllRentals()
        {
            string json = System.IO.File.ReadAllText(@"C:\Users\George\Desktop\Rentals.json");
            var rentals = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Rental>>(json);
            return rentals;
        }

        public static List<int> SearchClient(string searchCl)
        {
            SearchClients.Clear();
            string json = System.IO.File.ReadAllText(@"C:\Users\George\Desktop\Clients.json");
            var clients = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Client>>(json);
            int counter;
            foreach (Client c in clients)
            {
                if (c.Email.Contains(searchCl) || c.Fname.Contains(searchCl)
                    || c.Lname.Contains(searchCl) || c.Tel.Contains(searchCl) || c.Active.ToString() == searchCl)
                {
                    counter = clients.IndexOf(c);
                    SearchClients.Add(counter);
                     
                }
            }
            return SearchClients;
        } 

        public static List<int> SearchRental(string searchRe)
        {
            SearchRentals.Clear();
            string json = System.IO.File.ReadAllText(@"C:\Users\George\Desktop\Rentals.json");
            var rentals = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Rental>>(json);
            int counter;
            foreach (Rental r in rentals)
            {
                if (r.Name.Contains(searchRe) || r.Tel.Contains(searchRe) || r.Title.Contains(searchRe)
                    || r.Days.ToString().Contains(searchRe) || r.Amount.ToString().Contains(searchRe))
                {
                    counter = rentals.IndexOf(r);
                    SearchRentals.Add(counter);
                }
            }
            return SearchRentals;
        }   

        public static List<int> SearchMovie(string searchMo)
        {
            SearchMovies.Clear();
            string json = System.IO.File.ReadAllText(@"C:\Users\George\Desktop\Movies.json");
            var movies = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Movie>>(json);
            int counter;
            foreach (Movie m in movies)
            {
                if (m.Title.Contains(searchMo) || m.Genre.Contains(searchMo)
                    || m.Duration.ToString().Contains(searchMo) || m.Price.ToString().Contains(searchMo))
                {
                    counter = movies.IndexOf(m);
                    SearchMovies.Add(counter);
                }
            }return SearchMovies;
        }
    }
}

       

