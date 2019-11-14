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
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }
        public static string fname;
        public static string lname;
        public static string email;
        public static string tel;



        private void AdClbtn1_Click(object sender, EventArgs e)
        {
            
            fname = AdCltxtbox1.Text;
            lname = AdCltxtbox2.Text;
            email = AdCltxtbox3.Text;
            tel = AdCltxtbox4.Text;
            
            
            if (CreateEntries.ValidateClient(fname, lname, email, tel))
            {
                MessageBox.Show("Wrong or incomplete data inserted");
            }
            else
            {
                MessageBox.Show("New Client Created Succesfully");
            }
        }
    }
}
