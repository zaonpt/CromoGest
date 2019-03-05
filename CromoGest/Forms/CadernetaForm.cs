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
                        novaPagina[cromoPosicao]= cromo.Numero; 
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

        private void dataGridViewCaderneta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewCaderneta_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void ButtonNova_Click(object sender, EventArgs e)
        {
            NovaCaderneta formNova = new NovaCaderneta(this);
            formNova.Show();
            this.Hide();
        }

        private void ButtonEntradas_Click(object sender, EventArgs e)
        {
            Entradas entradas = new Entradas(this);
            entradas.Show();
            this.Hide();
        }
    }
}
