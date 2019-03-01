using CromoGest.Forms;
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

namespace CromoGest
{
    public partial class Entradas : Form
    {
        private List<CadernetaModelo> cadernetasExistentes = GlobalConfig.Connection.GetCadernetas();
        string charSeparador;
        public Entradas()
        {
            InitializeComponent();
            ResetComboBox();
            charSeparador = GlobalConfig.Connection.GetConfig("Separador");
        }

        private void ResetComboBox()
        {
            ComboBoxCadernetas.DataSource = null;
            ComboBoxCadernetas.DataSource = cadernetasExistentes;
            ComboBoxCadernetas.DisplayMember = "Nome";
            ComboBoxCadernetas.ValueMember = "Id";
        }

        private void Entradas_Load(object sender, EventArgs e)
        {

        }

        private void ButtonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonIntroduzir_Click(object sender, EventArgs e)
        {
            if (ComboBoxCadernetas.SelectedItem == null)
            {
                MessageBox.Show("Sem cadernetas");
                return;
            }

            foreach (DataGridViewRow row in dataGridViewCromos.Rows)
            {
                if (row.Cells["Cromos"].Value.ToString().Contains(charSeparador))
                {
                    // TODO - SEPARAR OS CROMO NA CELULA
                }
                else
                {
                    GlobalConfig.Connection.IncCromoQuatidade(row.Cells["Cromos"].Value.ToString());
                }
            } 
        }
    }
}
