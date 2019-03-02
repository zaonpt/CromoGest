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
        char charSeparador;
        public Entradas()
        {
            InitializeComponent();
            ResetComboBox();
            charSeparador = GlobalConfig.Connection.GetConfig(ConfigCategory.CharSeparador.Value)[0];
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

        private void AddCromoToResults(string cromo, bool isNew)
        {
            if (isNew == true)
                ListBoxNovos.Items.Add(cromo);
            else
                ListBoxRepetidos.Items.Add(cromo);            
        }

        bool IncCromoQuantidade(string cromo)
        {
            int idCaderneta = ((CadernetaModelo)ComboBoxCadernetas.SelectedItem).Id;
            return GlobalConfig.Connection.IncCromoQuatidade(cromo, idCaderneta);
        }

        private void ButtonIntroduzir_Click(object sender, EventArgs e)
        {
            if (!CromosValidos()) return;
            bool IsNovo;
            int rows = dataGridViewCromos.Rows.Count - 1;
            for (int i = 0; i < rows; i++)
            {
                string row = dataGridViewCromos.Rows[i].Cells["Cromos"].Value.ToString();
                if (row.Contains(charSeparador))
                {
                    string[] cromos = row.Replace(" ", string.Empty).Split(charSeparador);
                    foreach (string cromo in cromos)
                    {
                        IsNovo = IncCromoQuantidade(cromo);
                        AddCromoToResults(cromo, IsNovo);
                    }
                }
                else
                {
                    string cromo = row;
                    IsNovo = IncCromoQuantidade(cromo);
                    AddCromoToResults(cromo, IsNovo);
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

        private bool CromoValido(string cromo) { return GlobalConfig.Connection.IsValidCromo(cromo); }


        private bool CromosValidos()
        {
            if (ComboBoxCadernetas.SelectedItem == null)
            {
                MessageBox.Show("Sem cadernetas");
                return false;
            }

            CadernetaModelo caderneta = (CadernetaModelo)ComboBoxCadernetas.SelectedItem;
            if (GlobalConfig.Connection.TotalCromos(caderneta) == 0) {
                MessageBox.Show("Caderneta existe mas não está populada com informacão das paginas e cromos. " +
                    "Por favor sair e ir 'Nova Caderneta' selecionar esta caderneta e preencher a informação em falta.");
                return false;
            }
            
            int ncromos = dataGridViewCromos.Rows.Count - 1;
            for (int i = 0; i < ncromos; i++)
            {
                string row = dataGridViewCromos.Rows[i].Cells["Cromos"].Value.ToString();
                if (row.Contains(charSeparador))
                {
                    string[] cromos = row.Replace(" ", string.Empty).Split(charSeparador);
                    foreach (string cromo in cromos)
                    {
                        if (!CromoValido(cromo))
                        {
                            MessageBox.Show($"Cromo {cromo} não existe na caderneta, corriga e tente de novo.");
                            return false;
                        }
                    }
                }
                else if (!CromoValido(row))
                {
                    MessageBox.Show($"Cromo {row} não existe na caderneta, corriga e tente de novo.");
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
