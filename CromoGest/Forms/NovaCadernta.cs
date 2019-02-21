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
    public partial class NovaCaderneta : Form
    {
        private List<CadernetaModelo> cadernetasExistentes = GlobalConfig.Connection.GetCadernetas();
               
        public NovaCaderneta()
        {
            InitializeComponent();
            LigaLista();
        }
        
        private void LigaLista()
        {
            CadernetasComboBox.DataSource = null;
            CadernetasComboBox.DataSource = cadernetasExistentes;
            CadernetasComboBox.DisplayMember =  "Nome";
        }

        private void ButtonCriar_Click(object sender, EventArgs e)
        {
            if (ValidarForm())
            {
                CadernetaModelo caderneta = new CadernetaModelo(
                    TextNome.Text, 
                    TextQuantidade.Text, 
                    TextQuantidadeCarteira.Text, 
                    TextCarteiraCusto.Text);
                GlobalConfig.Connection.CriarCaderneta(caderneta);

                cadernetasExistentes.Add(caderneta);

                LigaLista();

                CadernetasComboBox.Text = TextNome.Text;

                TextNome.Text = "";
                TextQuantidade.Text = "";
                TextQuantidadeCarteira.Text = "";
                TextCarteiraCusto.Text = "";
            }
            else
            {
                MessageBox.Show("Campos incorrectos, verificar e tentar novamente.");
            }
        }

        private bool ValidarForm()
        {
            bool valido = true;
            if (!int.TryParse(TextQuantidade.Text, out int Quantidade) || Quantidade<1)
            {
                valido = false;
            }
            if (TextNome.Text.Length==0)
            {
                valido = false;
            }
            if (!decimal.TryParse(TextCarteiraCusto.Text, out decimal Custo) || Custo==0){
                valido = false;
            }
            if(!int.TryParse(TextQuantidadeCarteira.Text, out int CQuantidade) || CQuantidade== 0)
            {
                valido = false;
            }


            return valido;
        }

    }
}
