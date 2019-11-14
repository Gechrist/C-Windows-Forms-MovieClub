using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_html.Models
{
   class Client
    {
        public string Fname { get; set; } = null;
        public string Lname { get; set; } = null;
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = null;
        public string Tel { get; set; } = null;
        public string Name { get; set; } = null;

        public bool Active { get; set; } = true;


        public static List<Client> ClientList = new List<Client>();

        public Client(string fname, string lname, string email, string tel)
        {
            Fname = fname;
            Lname = lname;
            Email = email;
            Tel = tel;
            Name = fname + " " + lname;

           
        }

        public static bool NewClient(string fname, string lname, string email,
           string tel)
        {
            if (string.IsNullOrEmpty(fname) || fname.Length < 3 || string.IsNullOrEmpty(lname) || lname.Length < 3 || string.IsNullOrEmpty(email) || !email.Contains("@")
                || !email.Contains(".") || string.IsNullOrEmpty(tel) || tel.Length != 10)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


    }
}
