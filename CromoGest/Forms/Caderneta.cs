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
    public partial class Caderneta : Form
    {
        // TODO - ELIMINAR ISTO E CARREGAR O HORIZONTAL SOMENTE
        private List<CadernetaVerticalModelo> cadernetasVerticais = GlobalConfig.Connection.GetCadernetasVerticias();

        private List<CadernetaHorizontalModelo> cadernetasHorizontais = GlobalConfig.Connection.GetCadernetasHorizontais();
        char charSeparador;

        public Caderneta()
        {
            InitializeComponent();
            charSeparador = GlobalConfig.Connection.GetConfig(ConfigCategory.CharSeparador.Value)[0];
            ResetComboBox();
            LoadCadernetasGrid();
        }

        private void LoadCadernetasGrid()
        {
            //int posCromo;

            //foreach (CadernetaVerticalModelo caderneta in ComboBoxCadernetas.Items)
            //{
            //    cadernetasHorizontais.Add()
            //    foreach (PaginaModelo pagina in caderneta.Paginas)
            //    {
            //        posCromo = 1;
            //        foreach (CromoModelo cromo in pagina.Cromos)
            //        {
            //            string cromoNaPagina = "C" + posCromo++;

            //        }
            //    }
            }




            //dataGridViewCaderneta.DataSource = CromosCadernetaSelecionada;
            //dataGridViewCaderneta.Columns["Id"].Visible = false;
            //dataGridViewCaderneta.Columns["Quantidade"].Visible = false;
            //dataGridViewCaderneta.Columns["IdPagina"].Visible = false;
        }

        private void ResetComboBox()
        {
            ComboBoxCadernetas.DataSource = null;
            ComboBoxCadernetas.DataSource = cadernetasHorizontais;
            ComboBoxCadernetas.DisplayMember = "Nome";
            ComboBoxCadernetas.ValueMember = "Id";
        }

        
    }
}
