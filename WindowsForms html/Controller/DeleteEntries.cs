using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForms_html.Models;

namespace WindowsForms_html.Controller
{
    class DeleteEntries
    {
        public static void DeleteCl(int c)
        {
            string json = File.ReadAllText(@"C:\Users\George\Desktop\Clients.json");
            var array = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Client>>(json);
            array.RemoveAt(c);
            string outputprice = Newtonsoft.Json.JsonConvert.SerializeObject(array, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(@"C:\Users\George\Desktop\Clients.json", outputprice);
        }
        public static void DeleteMo(int m) 
        {
            string json = File.ReadAllText(@"C:\Users\George\Desktop\Movies.json");
            var array = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Movie>>(json);
            array.RemoveAt(m);
            string outputprice = Newtonsoft.Json.JsonConvert.SerializeObject(array, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(@"C:\Users\George\Desktop\Movies.json", outputprice);
        }

        public static void DeleteRe(int r)
        {
            string json = File.ReadAllText(@"C:\Users\George\Desktop\Rentals.json");
            var array = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Rental>>(json);
            array.RemoveAt(r);
            string outputprice = Newtonsoft.Json.JsonConvert.SerializeObject(array, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(@"C:\Users\George\Desktop\Rentals.json", outputprice);
        }

    }
}
