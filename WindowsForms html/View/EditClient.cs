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
using System.IO;

namespace WindowsForms_html
{
    public partial class EditClSeClbtn : Form
    {
        private string SearchCl;
      
        public EditClSeClbtn()
        {
            InitializeComponent();
        }
        
       dynamic orval;

        private void EdClSebtn1_Click(object sender, EventArgs e)
        {
            SearchCl = EdClSetxtbox1.Text;
            ReadEntries.SearchClient(SearchCl);
            if (ReadEntries.SearchClients.Count() == 0)
            {
                MessageBox.Show("No Results Found");
                dataGridView1.DataSource = null;
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ReadEntries.AllClients();
                dataGridView1.CurrentCell = null;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (ReadEntries.SearchClients.Contains(row.Index))
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
            ReadEntries.SearchClients.Clear();
            EdClSetxtbox1.Text = null;
            dataGridView1.CellBeginEdit -= dataGridView1_CellBeginEdit;
            dataGridView1.CellBeginEdit += dataGridView1_CellBeginEdit;
            dataGridView1.CellEndEdit -= dataGridView1_CellEndEdit;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
        }

        private void AllMvbtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ReadEntries.AllClients();
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
            if (dataGridView1.CurrentCell.ColumnIndex == 5)
            {
                UpdateEntries.UpdateClJson(orval,"Active", dataGridView1.CurrentCell.Value.ToString(), dataGridView1.CurrentCell.RowIndex);
                MessageBox.Show("Client data updated succesfully");
            }
            var name = dataGridView1.CurrentCell.ColumnIndex;
            switch (name)
            {
                case 0:
                    if (dataGridView1.CurrentCell.Value != null && UpdateEntries.CheckClient(fname: dataGridView1.CurrentCell.Value.ToString()))
                    {
                        UpdateEntries.UpdateClJson(orval,"Fname", dataGridView1.CurrentCell.Value.ToString(), dataGridView1.CurrentCell.RowIndex);
                        MessageBox.Show("Client data updated succesfully");
                    }
                    else
                    {
                        MessageBox.Show("Wrong client info"); 
                        dataGridView1.CurrentCell.Value = orval;
                    }
                    break;
                case 1:
                    if (dataGridView1.CurrentCell.Value != null && UpdateEntries.CheckClient(lname: dataGridView1.CurrentCell.Value.ToString()))
                    {
                        UpdateEntries.UpdateClJson(orval,"Lname", dataGridView1.CurrentCell.Value.ToString(), dataGridView1.CurrentCell.RowIndex);
                        MessageBox.Show("Client data updated succesfully");
                    }
                    else
                    {
                        MessageBox.Show("Wrong client info");
                        dataGridView1.CurrentCell.Value = orval;
                    }
                    break;
                case 2:
                    if (dataGridView1.CurrentCell.Value != null && UpdateEntries.CheckClient(email: dataGridView1.CurrentCell.Value.ToString()))
                    {
                        UpdateEntries.UpdateClJson(orval,"Email", dataGridView1.CurrentCell.Value.ToString(), dataGridView1.CurrentCell.RowIndex);
                        MessageBox.Show("Client data updated succesfully");
                    }
                    else
                    {
                        MessageBox.Show("Wrong client info");
                        dataGridView1.CurrentCell.Value = orval;
                    }
                    break;
                case 3:
                    if (dataGridView1.CurrentCell.Value != null && UpdateEntries.CheckClient(tel: dataGridView1.CurrentCell.Value.ToString()))
                    {
                        UpdateEntries.UpdateClJson(orval,"Tel", dataGridView1.CurrentCell.Value.ToString(), dataGridView1.CurrentCell.RowIndex);
                        MessageBox.Show("Client data updated succesfully");
                    }
                    else
                    {
                        MessageBox.Show("Wrong client info");
                        dataGridView1.CurrentCell.Value = orval;
                    }
                    break;
            }
        }

        private void EdClDelbtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this entry?","", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int delcl = dataGridView1.CurrentCell.RowIndex;
                DeleteEntries.DeleteCl(delcl);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ReadEntries.AllClients();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }
    }
}  
  
