using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_html
{
    public partial class MainForm : Form
    {
        
        
        public MainForm()
        {
            InitializeComponent();
           
        }

        public static string savedir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\";
        
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
