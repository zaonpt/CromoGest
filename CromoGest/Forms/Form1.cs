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

            DataGridViewCromoColumn col1 = new DataGridViewCromoColumn();
            DataGridViewCromoColumn col2 = new DataGridViewCromoColumn();
            DataGridViewCromoCell c1 = new DataGridViewCromoCell("aa", 1);
            DataGridViewCromoCell c2 = new DataGridViewCromoCell("bb", 2);

            DataGridViewRow r1 = new DataGridViewRow();

            r1.Cells.Add(c1);
            r1.Cells.Add(c2);

            dataGridView1.Columns.Add(col1);
            dataGridView1.Columns.Add(col2);
            dataGridView1.Rows.Add(r1);




            //dataGridView1.Rows.Add("aa");


            //dataGridView1.Rows.Add(new DataGridViewCromoCell("bb", 2));
            //dataGridView1.Rows.Add(new DataGridViewCromoCell("cc", 3));




            //dataGridView1.DataSource = ss;



        }
    }
}
