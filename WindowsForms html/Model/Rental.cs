using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_html.Models
{
    class Rental
    {
        public int Days { get; set; } = 0;
        public static int ListAmount { get; set; } = 0;
        public string Name { get; set; } = null;
        public string Tel { get; set; } = null;
        public string Title { get; set; } = null;

        public int Amount { get; set; } = 0;

        public static List<Rental> RentalList = new List<Rental>();

        public static int getAmount(int price, int days)
        {
            return ListAmount = price * days;
        }
        public Rental(string name, string tel, string title, int days, int amount)
        {
            Name = name;
            Tel = tel;
            Days = days;
            ListAmount = amount;
            Title = title;
            Amount = ListAmount;
        }
    }
}
