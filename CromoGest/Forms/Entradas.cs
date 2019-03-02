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
            charSeparador = GlobalConfig.Connection.GetConfig(ConfigCategory.CharSeparador.Value);
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
            if (!CromosValidos())
            {
                MessageBox.Show("Cromos invalidos, verifique e tente de novo.");
                return;
            }
            bool novo;
            int rows = dataGridViewCromos.Rows.Count-1;
            for (int i = 0; i < rows; i++)
            {
                if (dataGridViewCromos.Rows[i].Cells["Cromos"].Value.ToString().Contains(charSeparador))
                {
                    // TODO - SEPARAR OS CROMO NA CELULA E INSERIR NA BD
                }
                else
                {
                    novo = Convert.ToBoolean(
                        GlobalConfig.Connection.IncCromoQuatidade(
                            dataGridViewCromos.Rows[i].Cells["Cromos"].Value.ToString()
                        ));
                    if (novo)
                    {
                        ListBoxNovos.Items.Add(dataGridViewCromos.Rows[i].Cells["Cromos"].Value.ToString());
                    }
                    else
                    {
                        ListBoxRepetidos.Items.Add(dataGridViewCromos.Rows[i].Cells["Cromos"].Value.ToString());
                    }
                }
            }
            ActivarControles(false);
        }

        private void ActivarControles(bool v)
        {
            dataGridViewCromos.Enabled = v;
            ButtonIntroduzir.Enabled = v;
            ButtonVerificar.Enabled = v;
        }

        private bool CromosValidos()
        {
            int cromos = dataGridViewCromos.Rows.Count - 1;
            for (int i = 0; i < cromos; i++)
            {
                string cromo = dataGridViewCromos.Rows[i].Cells["Cromos"].Value.ToString();
                if (!GlobalConfig.Connection.IsValidCromo(cromo))
                {
                    return false;
                }
            }
            return true;
        }

        private void LimpaListas()
        {
            dataGridViewCromos.Rows.Clear();
            dataGridViewCromos.Refresh();
            ListBoxNovos.Items.Clear();
            ListBoxRepetidos.Items.Clear();
        }

        private void ButtonLimpar_Click(object sender, EventArgs e)
        {
            ActivarControles(true);
            LimpaListas();
        }

        private void ComboBoxCadernetas_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpaListas();
            ActivarControles(true);
        }
    }
}
