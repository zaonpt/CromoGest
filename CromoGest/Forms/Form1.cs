using CromoGest.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CromoGest.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;

            for (int i = 0; i < 3; i++)
            {
                dataGridView1.Columns.Add(new DataGridViewCromoColumn());
            }

            for (int i = 0; i < 3; i++)
            {
                dataGridView1.Rows.Add(new DataGridViewRow());
            }

            for (int col = 0; col < 3; col++)
            {
                for (int row = 0; row < 3; row++)
                {
                    ((DataGridViewCromoCell)dataGridView1.Rows[row].Cells[col]).Value = $"a{row}{col}";
                    ((DataGridViewCromoCell)dataGridView1.Rows[row].Cells[col]).NumCromos = row + col;
                }
            }
        }
    }
}
