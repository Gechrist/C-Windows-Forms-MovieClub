using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForms_html.Models;

namespace WindowsForms_html.Controller
{
    class UpdateEntries
    {
        public static bool CheckClient(string fname = "aaaa", string lname = "aaaa", string email = "aaa@aaa.gr",
                 string tel = "0000000000")
        {
            if (fname.Length < 3 || lname.Length < 3 || !email.Contains("@")
                || !email.Contains(".") || tel.Length != 10)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void UpdateClJson(dynamic orval, string field, string value, int index)
        {
            string json = File.ReadAllText(@"C:\Users\George\Desktop\Clients.json");
            dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            jsonObj[index][field] = value;
            if (field == "Fname")
            {
                jsonObj[index]["Name"] = value + " " + jsonObj[index]["Lname"];

                string rental_t = File.ReadAllText(@"C:\Users\George\Desktop\Rentals.json");
                var rentals_t = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Rental>>(rental_t);
                foreach (Rental r in rentals_t)
                {
                    if (orval + " " + jsonObj[index]["Lname"] == r.Name)
                    {
                        r.Name = jsonObj[index]["Name"];
                    }
                }
                string outputtitle = Newtonsoft.Json.JsonConvert.SerializeObject(rentals_t, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(@"C:\Users\George\Desktop\Rentals.json", outputtitle);
            }
            else if (field == "Lname")
            {
                jsonObj[index]["Name"] = jsonObj[index]["Fname"] + " " + value;

                string rental_t = File.ReadAllText(@"C:\Users\George\Desktop\Rentals.json");
                var rentals_t = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Rental>>(rental_t);
                foreach (Rental r in rentals_t)
                {
                    if (jsonObj[index]["Fname"] + " " + orval == r.Name)
                    {
                        r.Name = jsonObj[index]["Name"];
                    }
                }
                string outputtitle = Newtonsoft.Json.JsonConvert.SerializeObject(rentals_t, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(@"C:\Users\George\Desktop\Rentals.json", outputtitle);
            }

            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(@"C:\Users\George\Desktop\Clients.json", output);
        }

        public static void UpdateMoJson(dynamic orval, string field, string value, int index)
        {
            string json = File.ReadAllText(@"C:\Users\George\Desktop\Movies.json");
            dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            jsonObj[index][field] = value;
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(@"C:\Users\George\Desktop\Movies.json", output);
            if (field == "Title")
            {
                string rental_t = File.ReadAllText(@"C:\Users\George\Desktop\Rentals.json");
                var rentals_t = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Rental>>(rental_t);
                foreach (Rental r in rentals_t)
                {
                    if (orval == r.Title)
                    {
                        r.Title = value;
                    }
                }
                string outputtitle = Newtonsoft.Json.JsonConvert.SerializeObject(rentals_t, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(@"C:\Users\George\Desktop\Rentals.json", outputtitle);
            }
            if (field == "Price")
            {
                string rental_r = File.ReadAllText(@"C:\Users\George\Desktop\Rentals.json");
                var rentals_r = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Rental>>(rental_r);
                foreach (Rental r in rentals_r)
                {
                    if (jsonObj[index]["Title"] == r.Title)
                    {
                        r.Amount = Rental.getAmount(int.Parse(value), r.Days);
                    }
                }
                string outputprice = Newtonsoft.Json.JsonConvert.SerializeObject(rentals_r, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(@"C:\Users\George\Desktop\Rentals.json", outputprice);

            }

        }
        public static bool CheckMovie(string title = "aaaa", string genre = "aaaa", string duration = "10",
                 string price = "10")
        {
            if (title.Length < 3 || genre.Length < 3 || string.IsNullOrEmpty(duration) || duration.Length > 3
                || !duration.Any(char.IsDigit) || string.IsNullOrEmpty(price) || !price.Any(char.IsDigit) || price.Equals(0) || price.Length > 3)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static void UpdateReJson(string field, string value, int index, string optional = "")
        {
            string json = File.ReadAllText(@"C:\Users\George\Desktop\Rentals.json");
            dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            jsonObj[index][field] = value;

            if (field == "Name")
            {
                jsonObj[index]["Tel"] = optional;
            }

            if (field == "Days")
            {
                string movie_m = File.ReadAllText(@"C:\Users\George\Desktop\Movies.json");
                var movies_m = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Movie>>(movie_m);
                foreach (Movie m in movies_m)
                {
                    if (jsonObj[index]["Title"] == m.Title)
                    {
                        jsonObj[index]["Amount"] = Rental.getAmount(m.Price, int.Parse(value));
                    }
                }
            }

            if (field == "Title")
            {
                string movie_m = File.ReadAllText(@"C:\Users\George\Desktop\Movies.json");
                var movies_m = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Movie>>(movie_m);
                int val = int.Parse(optional);
                foreach (Movie m in movies_m)
                {
                    if (jsonObj[index]["Title"] == m.Title)
                    {
                        jsonObj[index]["Amount"] = Rental.getAmount(m.Price, val);
                    }
                }
            }
            string outputprice = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(@"C:\Users\George\Desktop\Rentals.json", outputprice);
        }
    }
}    

