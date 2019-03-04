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
        private List<CadernetaHorizontalModelo> cadernetasHorizontais = GlobalConfig.Connection.GetCadernetasHorizontais();
        char charSeparador;

        public Caderneta()
        {
            InitializeComponent();
            charSeparador = GlobalConfig.Connection.GetConfig(ConfigCategory.CharSeparador.Value)[0];
            ResetComboBox();
            LoadCadernetasGrid();
        }

        private void ResetComboBox()
        {
            ComboBoxCadernetas.DataSource = null;
            ComboBoxCadernetas.DataSource = cadernetasHorizontais;
            ComboBoxCadernetas.DisplayMember = "Nome";
            ComboBoxCadernetas.ValueMember = "Id";
        }

        private void LoadCadernetasGrid()
        {





            //dataGridViewCaderneta.DataSource = CromosCadernetaSelecionada;
            //dataGridViewCaderneta.Columns["Id"].Visible = false;
            //dataGridViewCaderneta.Columns["Quantidade"].Visible = false;
            //dataGridViewCaderneta.Columns["IdPagina"].Visible = false;
        }



        
    }
}
