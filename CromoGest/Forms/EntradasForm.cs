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
    public partial class EntradasForm : Form
    {
        private List<CadernetaModelo> cadernetasExistentes = CromoGestLibrary.GlobalConfig.Connection.GetCadernetas();
        char charSeparador;
        DashboardForm caderneta;

        public EntradasForm()
        {
            InitializeComponent();
            ResetComboBox();
            charSeparador = CromoGestLibrary.GlobalConfig.Connection.GetConfig(ConfigCategory.CharSeparador.Value)[0];
        }

        public EntradasForm(DashboardForm cadernetaIN, int cbIndex)
        {
            InitializeComponent();
            ResetComboBox();
            charSeparador = CromoGestLibrary.GlobalConfig.Connection.GetConfig(ConfigCategory.CharSeparador.Value)[0];
            caderneta = cadernetaIN;
            ComboBoxCadernetas.SelectedIndex = cbIndex;
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

        int IncCromoQuantidade(string cromo)
        {
            int idCaderneta = ((CadernetaModelo)ComboBoxCadernetas.SelectedItem).Id;
            return CromoGestLibrary.GlobalConfig.Connection.IncCromoQuatidade(cromo, idCaderneta);
        }

        int GetCromoQuantidade(string cromo)
        {
            int idCaderneta = ((CadernetaModelo)ComboBoxCadernetas.SelectedItem).Id;
            return CromoGestLibrary.GlobalConfig.Connection.GetCromoQuatidade(cromo, idCaderneta);
        }

        private void ButtonIntroduzir_Click(object sender, EventArgs e)
        {
            if (!CromosValidos()) return;
            bool IsNovo;
            int oldQuant;
            int rows = dataGridViewCromos.Rows.Count - 1;

            LimpaResultados();
            for (int i = 0; i < rows; i++)
            {
                string row = dataGridViewCromos.Rows[i].Cells["Cromos"].Value.ToString();
                if (row.Contains(charSeparador))
                {
                    string[] cromos = row.Replace(" ", string.Empty).Split(charSeparador);
                    foreach (string cromo in cromos)
                    {
                        oldQuant = GetCromoQuantidade(cromo);
                        IsNovo = (IncCromoQuantidade(cromo)==1);
                        AddCromoToResults(cromo, IsNovo);
                    }
                }
                else
                {
                    string cromo = row;
                    oldQuant = GetCromoQuantidade(cromo);
                    IsNovo = (IncCromoQuantidade(cromo) == 1);
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

        private bool CromoValido(string cromo)
        {
            return CromoGestLibrary.GlobalConfig.Connection.IsValidCromo(
                cromo: cromo, 
                idCaderneta: ((CadernetaModelo)ComboBoxCadernetas.SelectedItem).Id
            );
        }

        private bool CromosValidos()
        {
            if (ComboBoxCadernetas.SelectedItem == null)
            {
                MessageBox.Show("Sem cadernetas");
                return false;
            }

            CadernetaModelo caderneta = (CadernetaModelo)ComboBoxCadernetas.SelectedItem;
            if (CromoGestLibrary.GlobalConfig.Connection.TotalCromos(caderneta) == 0) {
                MessageBox.Show("Caderneta existe mas não está populada com informacão das paginas e cromos. " +
                    "Por favor sair e ir 'Nova Caderneta' selecionar esta caderneta e preencher a informação em falta.");
                LimpaListas();
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

        private void LimpaResultados()
        {
            ListBoxNovos.Items.Clear();
            ListBoxRepetidos.Items.Clear();
        }

        private void LimpaEntradas()
        {
            dataGridViewCromos.Rows.Clear();
            dataGridViewCromos.Refresh();
        }

        private void LimpaListas()
        {
            LimpaEntradas();
            LimpaResultados();
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

        private void ButtonVerificar_Click(object sender, EventArgs e)
        {
            if (!CromosValidos()) return;
            int CromoQuantidade;
            int rows = dataGridViewCromos.Rows.Count - 1;
            bool isNew;

            LimpaResultados();
            for (int i = 0; i < rows; i++)
            {
                string row = dataGridViewCromos.Rows[i].Cells["Cromos"].Value.ToString();
                if (row.Contains(charSeparador))
                {
                    string[] cromos = row.Replace(" ", string.Empty).Split(charSeparador);
                    foreach (string cromo in cromos)
                    {
                        CromoQuantidade = GetCromoQuantidade(cromo);
                        isNew = (CromoQuantidade == 0);
                        AddCromoToResults(cromo, isNew);
                    }
                }
                else
                {
                    string cromo = row;
                    CromoQuantidade = GetCromoQuantidade(cromo);
                    isNew = (CromoQuantidade == 0);
                    AddCromoToResults(cromo, isNew);
                }
            }
        }

        private void Entradas_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            caderneta.Show();
        }
    }
}
