using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForms_html;
using WindowsForms_html.Models;


namespace WindowsForms_html.Controller
{
    class CreateEntries
    {
        
        public static bool ValidateClient(string fname, string lname, string email, string tel)
        {
            if (!Client.NewClient(fname, lname, email, tel))
            {
                return true;
            }
            else 
            {
                Client c = new Client(fname, lname, email, tel);
                Client.ClientList.Add(c);
                File.WriteAllText(MainForm.savedir + "Clients.json", JsonConvert.SerializeObject(Client.ClientList));
                return false;
            }
            

        }

        public static bool ValidateMovie(string title, string genre, int duration, int price)
        {
            if (title == null || title.Length < 3 || genre == null || genre.Length < 3 || duration.ToString().Length < 2 ||
                price.ToString().Length <1)
            {
                return true;
            }
            else
            {
                Movie m = new Movie(title, genre, duration, price);
                Movie.MovieList.Add(m);
                File.WriteAllText(MainForm.savedir+"Movies.json", JsonConvert.SerializeObject(Movie.MovieList));
                return false;
            }

        }

        public static bool ValidateRental(string name, string tel, string title, int days, int amount)
        {
            if (days.ToString()== "0")
            {
                return true;
            }
            else
            {
                Rental r = new Rental(name, tel, title, days, amount);
                Rental.RentalList.Add(r);
                File.WriteAllText(MainForm.savedir + "Rentals.json", JsonConvert.SerializeObject(Rental.RentalList));
                return false;
            }

        }

    }
}
