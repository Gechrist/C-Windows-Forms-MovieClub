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

namespace WindowsForms_html
{
    public partial class AddMovie : Form
    {
        public AddMovie()
        {
            InitializeComponent();
        }
        public static string title;
        public static string genre;
        public static int duration;
        public static int price;

        private void AdMobtn1_Click(object sender, EventArgs e)
        {
            title = AdCltxtbox1.Text;
            genre = AdCltxtbox2.Text;
            duration = int.Parse(AdCltxtbox3.Text);
            price = int.Parse(AdCltxtbox4.Text);
          
            if (CreateEntries.ValidateMovie(title, genre, duration, price))
            {
                MessageBox.Show("Wrong or incomplete data inserted");
            }
            else
            {
                MessageBox.Show("New Movie Created Succesfully");
            }
        }
    }
}
