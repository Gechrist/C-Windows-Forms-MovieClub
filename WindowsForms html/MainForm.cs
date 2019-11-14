using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms_html.Models;

namespace WindowsForms_html
{
    public partial class MainForm : Form
    {
        
        
        public MainForm()
        {
            InitializeComponent();
            Client.ClientList.Add(new Client("alpha", "alpha", "alpha@alpha.gr", "1142149212"));
            Client.ClientList.Add(new Client("beta", "beta", "beta@beta.gr", "1212121212"));
            Client.ClientList.Add(new Client("charlie", "charlie", "charlie@charlie.gr", "1216128412"));
            Movie.MovieList.Add(new Movie("Die Hard", "action", 112, 10));
            Movie.MovieList.Add(new Movie("Interstellar", "sci-fi", 140, 15));
            Movie.MovieList.Add(new Movie("Dumb and Dumber", "comedy", 100, 9));
            Rental.RentalList.Add(new Rental("alpha alpha", "1142149212", "Die Hard", 1, 10));
        }

        private void deleteMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditMovie editmovie = new EditMovie();
            editmovie.Show();
        }

        private void addClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClient addClient = new AddClient();
            addClient.Show();
        }

        private void addMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMovie addmovie = new AddMovie();
            addmovie.Show();
        }

        private void editClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditClSeClbtn editclient = new EditClSeClbtn();
            editclient.Show();
        }

        private void newRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRental addrental = new AddRental();
            addrental.Show();
        }

        private void editRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditRental editrental = new EditRental();
            editrental.Show();
        }
    }


}
