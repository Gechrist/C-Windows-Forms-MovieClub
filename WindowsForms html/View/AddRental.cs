using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms_html.Controller;
using WindowsForms_html.Models;

namespace WindowsForms_html
{
    public partial class AddRental : Form
    {
        

        public AddRental()
        {
            InitializeComponent();
            comboBox1.DataSource = ReadEntries.AllClients();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Name";

            comboBox2.DataSource = ReadEntries.AllMovies();
            comboBox2.DisplayMember = "Title";
            comboBox2.ValueMember = "Title";
            comboBox3.Text = 0.ToString();
        }

        private int price;
        private int days;
   
        private int ChPrice()
        {
            Movie m = (Movie)comboBox2.SelectedItem;
            price = m.Price;
            return price;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
            days = Convert.ToInt32(Math.Round(AdRenNum.Value));
            comboBox3.Text = Rental.getAmount(days, ChPrice()).ToString();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Text = Rental.getAmount(days, ChPrice()).ToString();
        }

        private void AdRenBtn_Click(object sender, EventArgs e)
        {
            Client c = (Client)comboBox1.SelectedItem;
            Movie m = (Movie)comboBox2.SelectedItem;
            
            if (CreateEntries.ValidateRental(c.Name, c.Tel, m.Title, days, int.Parse(comboBox3.Text)))
            {
                MessageBox.Show("Days = 0");
            }
            else
            {
                MessageBox.Show("New Rental Created Succesfully");
            }
        }
    }
   
}
