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
    public partial class DestinatarioPickerForm : Form
    {
        NovaTrocaForm formPai;
        private int idDest { get; set; }

        public DestinatarioPickerForm()
        {
            InitializeComponent();
        }

        public DestinatarioPickerForm(NovaTrocaForm formArgPai)
        {
            InitializeComponent();
            formPai = formArgPai;
        }

        public int GetIdDest()
        {
            return idDest;
        }

        private void DestinatarioPickerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            formPai.Show();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DestinatarioPickerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cadernetasBDDataSet1.Destinatario' table. You can move, or remove it, as needed.
            this.destinatarioTableAdapter1.Fill(this.cadernetasBDDataSet1.Destinatario);

        }

        private void dataGridViewContatos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            idDest = int.Parse(dataGridViewContatos.Rows[e.RowIndex].Cells[0].Value.ToString());
            this.Close();
        }
    }
}
