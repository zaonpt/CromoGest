using CromoGestLibrary;
using CromoGestLibrary.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CromoGest.Forms
{
    public partial class CadernetaForm : Form
    {
        private List<CadernetaModelo> cadernetas = GlobalConfig.Connection.GetCadernetas();
        char charSeparador;
        private List<CadernetaHorizontalModelo> cadernetasHorizontais = new List<CadernetaHorizontalModelo>();

        public CadernetaForm()
        {
            InitializeComponent();
            charSeparador = GlobalConfig.Connection.GetConfig(ConfigCategory.CharSeparador.Value)[0];
            ResetComboBox();
            SetPosicoesCromosNaPagina();
            LoadCadernetasGrid();
        }

        private void SetPosicoesCromosNaPagina()
        {
            string cromoPosicao;
            int ncromo;
            CadernetaHorizontalModelo novaCaderneta;
            PaginaHorizontalModelo novaPagina;
            foreach (CadernetaModelo caderneta in cadernetas)
            {
                novaCaderneta = new CadernetaHorizontalModelo();
                novaCaderneta.Id = caderneta.Id;
                cadernetasHorizontais.Add(novaCaderneta);
                foreach (PaginaModelo pagina in caderneta.Paginas)
                {
                    novaPagina = new PaginaHorizontalModelo();
                    novaPagina["Pagina"] = pagina.Nome;
                    ncromo = 1;
                    foreach (CromoModelo cromo in pagina.Cromos)
                    {
                        cromoPosicao = "C" + ncromo++;
                        novaPagina[cromoPosicao] = cromo.Numero;
                    }
                    novaCaderneta.PaginasHorizontais.Add(novaPagina);
                }
            }

        }

        private void ResetComboBox()
        {
            ComboBoxCadernetas.DataSource = null;
            ComboBoxCadernetas.DataSource = cadernetas;
            ComboBoxCadernetas.DisplayMember = "Nome";
            ComboBoxCadernetas.ValueMember = "Id";
        }

        private void LoadCadernetasGrid()
        {

            foreach (CadernetaHorizontalModelo caderneta in cadernetasHorizontais)
            {
                if (caderneta.Id == ((CadernetaModelo)ComboBoxCadernetas.SelectedItem).Id)
                {
                    dataGridViewCaderneta.DataSource = caderneta.PaginasHorizontais;
                }
            }

        }

        private void ComboBoxCadernetas_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCadernetasGrid();
        }



        private void dataGridViewCaderneta_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void ButtonNova_Click(object sender, EventArgs e)
        {
            NovaCadernetaForm formNova = new NovaCadernetaForm(this);
            formNova.Show();
            this.Hide();
            cadernetas = GlobalConfig.Connection.GetCadernetas();
        }

        private void ButtonEntradas_Click(object sender, EventArgs e)
        {
            EntradasForm entradas = new EntradasForm(this);
            entradas.Show();
            this.Hide();
        }

        private void dataGridViewCaderneta_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int col = e.ColumnIndex;
            int row = e.RowIndex;




            dataGridViewCaderneta.Rows[row].Cells[col].Style.BackColor = Color.Green;
            dataGridViewCaderneta.Rows[row].Cells[col].Style.SelectionBackColor = Color.Green;
        }

        private void ButtonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
