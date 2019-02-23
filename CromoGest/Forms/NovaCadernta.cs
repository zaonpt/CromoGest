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
    public partial class FormNovaCaderneta : Form
    {
        private List<CadernetaModelo> cadernetasExistentes = GlobalConfig.Connection.GetCadernetas();
               
        public FormNovaCaderneta()
        {
            InitializeComponent();
            LigaLista();
        }
        
        private void LigaLista()
        {
            CadernetasComboBox.DataSource = null;
            CadernetasComboBox.DataSource = cadernetasExistentes;
            CadernetasComboBox.DisplayMember =  "Nome";
            CadernetasComboBox.ValueMember = "Id";
            if (cadernetasExistentes.Count==0)
            {
                DataGridViewPaginas.Enabled = false;
                ButtonAceitarPaginas.Enabled = false;
            }
            else
            {
                DataGridViewPaginas.Enabled = true;
                ButtonAceitarPaginas.Enabled = true;
                // TODO - Buscar as paginas que existam nesta caderneta
            }            
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
                
                // TODO - Apagar proxima linha quando implentar bindagem aos TextBoxes
                CadernetasComboBox.SelectedValue = caderneta.Id;

                LigaGridPaginas();

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

        private void CadernetasComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            // TODO - Bindar TextBoxes com ComboBoxes para evitar o HORROR que se segue
            CadernetaModelo caderneta = ((CadernetaModelo)CadernetasComboBox.SelectedItem);
            TextNome.Text = caderneta.Nome;
            TextQuantidade.Text = caderneta.QuantidadeCromos.ToString();
            TextQuantidadeCarteira.Text = caderneta.QuantidadeCromosSaqueta.ToString();
            TextCarteiraCusto.Text = caderneta.CustoCarteira.ToString();
        }
                     
        private void LigaGridPaginas()
        {
            DataGridViewPaginas.Enabled = true;
            ButtonAceitarPaginas.Enabled = true;
        }

        private void LigaGridCromos()
        {
            DataGridViewCromos.Enabled = true;
            ButtonConcluir.Enabled = true;
            DataGridViewCromos.Rows.Clear();
        }

        private void ButtonAceitarPaginas_Click(object sender, EventArgs e)
        {
            int quantidade = DataGridViewPaginas.Rows.
                        Cast<DataGridViewRow>().
                        Sum(t => Convert.ToInt32(t.Cells["Quantidade"].Value));
            if (!int.TryParse(TextQuantidade.Text, out int quantidadeText)) { MessageBox.Show("quantidade de cromos invalida!"); }
            else if (quantidade == quantidadeText)
            {
                if (GerarNovaspaginas())
                {
                    LigaGridCromos();

                    for (int i = 1; i <= quantidade; i++)
                    {
                        DataGridViewCromos.Rows.Add(new object[] { i.ToString(), "" });
                    }
                }
                else
                {
                    MessageBox.Show("Implementar refazer lista de cromos existente!");
                }
            }
            else {
                MessageBox.Show("Erro: Quantidade errada de cromos. O total de cromos tem de ser igual à soma dos cromo das paginas.");
            }
        }

        private bool GerarNovaspaginas()
        {
            // TODO - Verificar se é para gerar novas paginas ou seja existem.
            return true;
        }


        private void ButtonGravar_Click(object sender, EventArgs e)
        {
            string message = "Tem a certeza que a informação que introduziu está toda correcta?";
            string caption = "Atenção:";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                List<PaginaModelo> paginasDaCaderneta = new List<PaginaModelo>(); //trocar uma chamada da globalconfig



            }

            //CRIAR UMA LISTA?! COM CROMOS NOVOS (TODOS LOGO) 
            //OU SACAR À BD E GUARDAS NUMA LISTA (POR ORDEM) E APAGAR CROMOS E PAGINAS DA BD

            //PARA CADA PAGINA INTRODUZIDA NO GRID IR SACAR À LISTA O NUMERO DE CROMOS INDICADOS NA GRID
            //AINDA EM CADA PAGINA, GRAVAR TUDO NA BD




            //LIXO!!!!!!!!!!!!!!!!!!!!
            //PaginaModelo pagina;
            //foreach (DataGridViewRow row in DataGridViewPaginas.Rows)
            //{
            //    pagina = new PaginaModelo(Name);
            //    pagina.CromosNaPagina.Add(new CromoModelo(Name));
            //    //paginasDaCaderneta.Add();
            //}
        }
    }
}
