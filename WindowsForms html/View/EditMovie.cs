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
using WindowsForms_html.Controller;

namespace WindowsForms_html
{
    public partial class EditMovie : Form
    {
        private string SearchMo;
        public EditMovie()
        {
            InitializeComponent();
        }

        dynamic orval;
        private void EdClSebtn1_Click(object sender, EventArgs e)
        {
            SearchMo = EdClSetxtbox1.Text;
            ReadEntries.SearchMovie(SearchMo);
            if (ReadEntries.SearchMovies.Count() == 0)
            {
                MessageBox.Show("No Results Found");
                dataGridView1.DataSource = null;
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ReadEntries.AllMovies();
                dataGridView1.CurrentCell = null;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (ReadEntries.SearchMovies.Contains(row.Index))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
                dataGridView1.CellBeginEdit -= dataGridView1_CellBeginEdit;
                dataGridView1.CellBeginEdit += dataGridView1_CellBeginEdit;
                dataGridView1.CellEndEdit -= dataGridView1_CellEndEdit;
                dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            ReadEntries.SearchMovies.Clear();
            EdClSetxtbox1.Text = null;
        }

        private void AllMvbtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ReadEntries.AllMovies();
            dataGridView1.CellBeginEdit -= dataGridView1_CellBeginEdit;
            dataGridView1.CellBeginEdit += dataGridView1_CellBeginEdit;
            dataGridView1.CellEndEdit -= dataGridView1_CellEndEdit;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            orval = dataGridView1.CurrentCell.Value;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
                var name = dataGridView1.CurrentCell.ColumnIndex;
                switch (name)
                {
                    case 0:
                        if (dataGridView1.CurrentCell.Value != null && UpdateEntries.CheckMovie(title: dataGridView1.CurrentCell.Value.ToString()))
                        {
                        UpdateEntries.UpdateMoJson(orval,"Title", dataGridView1.CurrentCell.Value.ToString(), dataGridView1.CurrentCell.RowIndex);
                        MessageBox.Show("Movie data updated succesfully");
                        }
                        else
                        {
                            MessageBox.Show("Wrong movie info");
                            dataGridView1.CurrentCell.Value = orval;
                        }
                        break;
                    case 1:
                        if (dataGridView1.CurrentCell.Value != null && UpdateEntries.CheckMovie(genre: dataGridView1.CurrentCell.Value.ToString()))
                        {
                        UpdateEntries.UpdateMoJson(orval,"Genre", dataGridView1.CurrentCell.Value.ToString(), dataGridView1.CurrentCell.RowIndex);
                        MessageBox.Show("Movie data updated succesfully");
                        }
                        else
                        {
                            MessageBox.Show("Wrong movie info");
                            dataGridView1.CurrentCell.Value = orval;
                        }
                        break;
                    case 2:
                        if (UpdateEntries.CheckMovie(duration: dataGridView1.CurrentCell.Value.ToString()))
                        {
                        UpdateEntries.UpdateMoJson(orval,"Duration", dataGridView1.CurrentCell.Value.ToString(), dataGridView1.CurrentCell.RowIndex);
                        MessageBox.Show("Movie data updated succesfully");
                        }
                        else
                        {
                            MessageBox.Show("Wrong movie info");
                            dataGridView1.CurrentCell.Value = orval;
                        }
                        break;
                    case 3:
                        if (UpdateEntries.CheckMovie(price: dataGridView1.CurrentCell.Value.ToString()))
                        {
                            UpdateEntries.UpdateMoJson(orval,"Price", dataGridView1.CurrentCell.Value.ToString(), dataGridView1.CurrentCell.RowIndex);
                            MessageBox.Show("Movie data updated succesfully");
                        }
                        else
                        {
                            MessageBox.Show("Wrong movie info");
                            dataGridView1.CurrentCell.Value = orval;
                        }
                        break;
                }
            
        }

             private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
             {
               MessageBox.Show("Wrong movie info");
                dataGridView1.CurrentCell.Value = orval;
             }

            private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this entry?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int delmo = dataGridView1.CurrentCell.RowIndex;
                DeleteEntries.DeleteMo(delmo);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ReadEntries.AllMovies();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }
    }
    
}
