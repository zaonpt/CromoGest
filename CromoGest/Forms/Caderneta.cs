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
    public partial class Caderneta : Form
    {
        private List<CadernetaModelo> cadernetas = GlobalConfig.Connection.GetCadernetas();
        char charSeparador;

        public Caderneta()
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

            foreach (CadernetaModelo caderneta in cadernetas)
            {
                foreach (PaginaModelo pagina in caderneta.Paginas)
                {
                    ncromo = 1;
                    foreach (CromoModelo cromo in pagina.Cromos)
                    {
                        cromoPosicao = "C" + ncromo++;
                        pagina[cromoPosicao]= cromo.Numero; 
                    }
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
            dataGridViewCaderneta.DataSource = ((CadernetaModelo)ComboBoxCadernetas.SelectedItem).Paginas;
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
    }
}
