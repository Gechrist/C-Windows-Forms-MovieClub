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
    public partial class EditRental : Form
    {
        private string SearchRe;

        public EditRental()
        {
            InitializeComponent();

        }

       dynamic orval;

        private void EdReSebtn1_Click(object sender, EventArgs e)
        {
            SearchRe = EdReSetxtbox1.Text;
            ReadEntries.SearchRental(SearchRe);
            if (ReadEntries.SearchRentals.Count() == 0)
            {
                MessageBox.Show("No Results Found");
                dataGridView1.DataSource = null;
            }
            else
            {
                dataGridView1.DataSource = null;
                combobox();
                dataGridView1.DataSource = ReadEntries.AllRentals();
                dataGridView1.CurrentCell = null;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (ReadEntries.SearchRentals.Contains(row.Index))
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
            ReadEntries.SearchRentals.Clear();
            EdReSetxtbox1.Text = null;

        }

        private void AllRenbtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ReadEntries.AllRentals();
            combobox();
            dataGridView1.CellEndEdit -= dataGridView1_CellEndEdit;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            dataGridView1.CellBeginEdit -= dataGridView1_CellBeginEdit;
            dataGridView1.CellBeginEdit += dataGridView1_CellBeginEdit;
        }

        private void combobox()
        {
            DataGridViewComboBoxColumn namecol = (DataGridViewComboBoxColumn)dataGridView1.Columns[0];
            DataGridViewComboBoxColumn titlecol = (DataGridViewComboBoxColumn)dataGridView1.Columns[2];
            namecol.DataSource = ReadEntries.AllClients();
            titlecol.DataSource = ReadEntries.AllMovies();
            dataGridView1.Columns[4].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "Days")
            {
                orval = dataGridView1.CurrentCell.Value;
            }
        }


        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "Days")
            {
                string title = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                int days = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString());
                foreach (Movie m in ReadEntries.AllMovies())
                {
                    if (m.Title == title)
                    {

                        dataGridView1.Rows[e.RowIndex].Cells[4].Value = Rental.getAmount(m.Price, days);
                        MessageBox.Show("Rental data updated succesfully");
                        UpdateEntries.UpdateReJson("Days", dataGridView1.CurrentCell.Value.ToString(), dataGridView1.CurrentCell.RowIndex);
                    }
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "Name")
            {
                string name = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString();
                foreach (Client c in ReadEntries.AllClients())
                {
                    if (c.Name == name)
                    {
                        dataGridView1.Rows[e.RowIndex].Cells[1].Value = c.Tel;
                        MessageBox.Show("Rental data updated succesfully");
                        UpdateEntries.UpdateReJson("Name", dataGridView1.CurrentCell.Value.ToString(), dataGridView1.CurrentCell.RowIndex, dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                    }
                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "Title")
            {

                string title = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString();
                int days = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString());
                foreach (Movie m in ReadEntries.AllMovies())
                {
                    if (m.Title == title)
                    {
                        dataGridView1.Rows[e.RowIndex].Cells[4].Value = Rental.getAmount(m.Price, days);
                        MessageBox.Show("Rental data updated succesfully");
                        UpdateEntries.UpdateReJson("Title", dataGridView1.CurrentCell.Value.ToString(), dataGridView1.CurrentCell.RowIndex, dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                    }
                }

            }

        }

        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Wrong rental info");
            dataGridView1.CurrentCell.Value = orval;
        }

        private void EdReDelbtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this entry?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int delre = dataGridView1.CurrentCell.RowIndex;
                DeleteEntries.DeleteRe(delre);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ReadEntries.AllRentals();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }

    }
}
