using CromoGestLibrary;
using CromoGestLibrary.Modelos;
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
        List<DestinatarioModelo> destinatarios = GlobalConfig.Connection.GetDestinatarios();
        private int idDest { get; set; }

        public DestinatarioPickerForm()
        {
            InitializeComponent();
        }

        public DestinatarioPickerForm(NovaTrocaForm formArgPai)
        {
            InitializeComponent();
            idDest = -1;
            formPai = formArgPai;
            dataGridViewContatos.AutoGenerateColumns = true;
            dataGridViewContatos.DataSource = destinatarios;
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

        private void dataGridViewContatos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            idDest = int.Parse(dataGridViewContatos.Rows[e.RowIndex].Cells[0].Value.ToString());
            this.Close();
        }
    }
}
