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

            //dataGridView1 = new DataGridView();
            DataGridViewCromoTextBoxColumn col =
                new DataGridViewCromoTextBoxColumn();
            dataGridView1.Columns.Add(col);
            //dataGridView1.Rows.Add(new string[] { "11" });
            //dataGridView1.Rows.Add(new string[] { "22" });
            //dataGridView1.Rows.Add(new string[] { "33" });
            //dataGridView1.Rows.Add(new string[] { "44" });
            //this.Controls.Add(dataGridView1);
            //this.Text = "DataGridView rollover-cell demo";



            List<string> s1 = new List<string>();
            s1.Add("a11");
            s1.Add("a21");
            List<string> s2 = new List<string>();
            s2.Add("a12");
            s2.Add("a22");
            List<string> s3 = new List<string>();
            s3.Add("a13");
            s3.Add("a23");
            List<string> s4 = new List<string>();
            s4.Add("a14");
            s4.Add("a24");

            List<List<string>> ss = new List<List<string>>();

            ss.Add(s1);
            ss.Add(s2);
            ss.Add(s3);
            ss.Add(s4);

            dataGridView1.DataSource = ss;
            dataGridView1.AutoGenerateColumns = true;



        }
    }
}
