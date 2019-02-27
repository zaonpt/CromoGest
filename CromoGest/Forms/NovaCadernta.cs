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
        private List<CromoModelo> CromosCadernetaSelecionada = new List<CromoModelo>();
               
        public FormNovaCaderneta()
        {
            InitializeComponent();
            LigaLista();
        }
        
        private void LigaTextboxes(bool ligar)
        {
            TextNome.Enabled = ligar;
            TextQuantidade.Enabled = ligar;
            TextQuantidadeCarteira.Enabled = ligar;
            TextCarteiraCusto.Enabled = ligar;
        }

        private void LigaGridPaginas(bool ligar)
        {
            DataGridViewPaginas.Enabled = ligar;
            ButtonAceitarPaginas.Enabled = ligar;
        }

        private void LigaGridCromos(bool ligar)
        {
            DataGridViewCromos.Enabled = ligar;
            ButtonConcluir.Enabled = ligar;
            if (ligar) DataGridViewCromos.Rows.Clear();
        }


        private void LigaLista()
        {
            ComboBoxCadernetas.DataSource = null;
            ComboBoxCadernetas.DataSource = cadernetasExistentes;
            ComboBoxCadernetas.DisplayMember =  "Nome";
            ComboBoxCadernetas.ValueMember = "Id";
            DataGridViewPaginas.DataSource = ((CadernetaModelo)ComboBoxCadernetas.SelectedItem).Paginas;
            DataGridViewPaginas.Columns["IdCaderneta"].Visible = false;
            DataGridViewPaginas.Columns["Id"].Visible = false;
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
                caderneta = GlobalConfig.Connection.CriarCaderneta(caderneta);
                cadernetasExistentes.Add(caderneta);
                LigaLista();
                
                // TODO - Apagar proxima linha quando implentar bindagem aos TextBoxes
                ComboBoxCadernetas.SelectedValue = caderneta.Id;

                LigaGridPaginas();
            }
            else { MessageBox.Show("Campos incorrectos, verificar e tentar novamente."); }
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

        private void LimpaGrids()
        {
            DataGridViewPaginas.AutoGenerateColumns = false;
            DataGridViewPaginas.DataSource = null;
            DataGridViewCromos.AutoGenerateColumns = false;
            DataGridViewCromos.DataSource = null;
        }

        private void CadernetasComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            // TODO - Bindar TextBoxes com ComboBoxes para evitar o HORROR que se segue
            CadernetaModelo caderneta = ((CadernetaModelo)ComboBoxCadernetas.SelectedItem);
            if (caderneta != null) { 
                TextNome.Text = caderneta.Nome;
                TextQuantidade.Text = caderneta.QuantidadeCromos.ToString();
                TextQuantidadeCarteira.Text = caderneta.QuantidadeCromosCarteira.ToString();
                TextCarteiraCusto.Text = caderneta.CustoCarteira.ToString();
                if (GlobalConfig.Connection.TotalCromos(caderneta) == 0)
                {
                    LimpaGrids();
                    LigaGridPaginas(true);
                }
                else
                {
                    LigaGridPaginas(false);
                    DataGridViewPaginas.DataSource = ((CadernetaModelo)ComboBoxCadernetas.SelectedItem).Paginas;
                    FillCromos();
                }
            }
        }

        private void FillCromos()
        {
            CromosCadernetaSelecionada = new List<CromoModelo>();
            foreach (PaginaModelo pagina in ((CadernetaModelo)ComboBoxCadernetas.SelectedItem).Paginas)
            {
                foreach (CromoModelo cromo in pagina.Cromos)
                {
                    CromosCadernetaSelecionada.Add(cromo);
                }
            }
            DataGridViewCromos.DataSource = CromosCadernetaSelecionada;
            DataGridViewCromos.Columns["Id"].Visible = false;
            DataGridViewCromos.Columns["Quantidade"].Visible = false;
            DataGridViewCromos.Columns["IdPagina"].Visible = false;


        }

        private void LigaGridPaginas()
        {
            LigaTextboxes(false);
            LigaGridPaginas(true);
            LigaGridCromos(false);
        }


        private int SomatorioCromosPaginas()
        {
            return DataGridViewPaginas.Rows.
                        Cast<DataGridViewRow>().
                        Sum(t => Convert.ToInt32(t.Cells["Quantidade"].Value));
        }

        private void ButtonAceitarPaginas_Click(object sender, EventArgs e)
        {
            int quantidade = SomatorioCromosPaginas();
            CadernetaModelo caderneta = (CadernetaModelo)ComboBoxCadernetas.SelectedItem;
            PaginaModelo novaPagina;
            CromoModelo novoCromo;
            if (!int.TryParse(TextQuantidade.Text, out int quantidadeText)) { MessageBox.Show("quantidade de cromos invalida!"); }
            else if (quantidade == quantidadeText)
            {
                LigaGridPaginas(false);
                if (GerarNovaspaginas())
                {
                    LigaGridCromos(true);
                    int cromosTotal = 1;
                    int paginas = DataGridViewPaginas.Rows.Count-1;
                    for (int p = 0; p < paginas; p++)
                    {
                        string novaPaginaNome = DataGridViewPaginas.Rows[p].Cells["Nome"].Value.ToString();
                        novaPagina = new PaginaModelo(nome: novaPaginaNome);
                        caderneta.Paginas.Add(novaPagina);
                        int cromos = Convert.ToInt32(DataGridViewPaginas.Rows[p].Cells["Quantidade"].Value);
                        for (int c = 0;  c < cromos; c++)
                        {
                            string novoCromoNumero = cromosTotal.ToString();
                            string novoCromoDescricao = "";
                            novoCromo = new CromoModelo(numero : novoCromoNumero, descricao: novoCromoDescricao, idPagina: novaPagina.Id);
                            caderneta.Paginas[p].Cromos.Add(novoCromo);
                        }
                    }
                    DataGridViewCromos.DataSource = (CadernetaModelo)ComboBoxCadernetas.SelectedItem;
                    DataGridViewCromos.Columns["Id"].Visible = false;
                    DataGridViewCromos.Columns["Quantidade"].Visible = false;
                    DataGridViewCromos.Columns["IdPagina"].Visible = false;

                }
                else  { MessageBox.Show("Implementar refazer lista de cromos existente!"); }
            }
            else { MessageBox.Show("Erro: Quantidade errada de cromos. O total de cromos tem de ser igual à soma dos cromo das paginas."); }
        }

        private bool GerarNovaspaginas()
        {
            // TODO - Verificar se é para gerar novas paginas ou seja existem.
            return true;
        }

        private bool Confirmado() {
            string message = "Tem a certeza que a informação que introduziu está toda correcta?";
            string caption = "Atenção:";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            return (MessageBox.Show(message, caption, buttons) == DialogResult.Yes);
        }


        private void ButtonGravar_Click(object sender, EventArgs e)
        {
            if (Confirmado() && DadosValidados())
            {
                CadernetaModelo caderneta = (CadernetaModelo)ComboBoxCadernetas.SelectedItem;
                int totalCromos = SomatorioCromosPaginas();
                int cromoCounter = 0;

                int nrows = DataGridViewPaginas.Rows.Count - 1;
                for (int j = 0; j < nrows; j++)
                {
                    int cromosPagina = Convert.ToInt32(DataGridViewPaginas.Rows[j].Cells["Quantidade"].Value.ToString());
                    caderneta.Paginas.Add(new PaginaModelo(DataGridViewPaginas.Rows[j].Cells["Pagina"].Value.ToString()));
                    for (int i = 0; i < cromosPagina; i++)
                    {
                        string descricaoCromo = DataGridViewCromos.Rows[cromoCounter++].Cells["Descricao"].Value.ToString();
                        caderneta.Paginas.Last<PaginaModelo>().Cromos.Add(new CromoModelo(
                            numero: cromoCounter.ToString(),
                            descricao: descricaoCromo,
                            idPagina: caderneta.Paginas.Last<PaginaModelo>().Id
                        ));
                    }
                }
                if (GlobalConfig.Connection.PopulateCaderneta(caderneta)) {
                    MessageBox.Show("Caderneta Criada com sucesso!");
                }
            }
        }

        private bool DadosValidados()
        {
            return SomatorioCromosPaginas() == Convert.ToInt32(TextQuantidade.Text);
        }

        private void ButtonAlterar_Click(object sender, EventArgs e)
        {
            // TODO - VERIFICAR SE CADERNETA JA TEM CROMOS (SE SIM PERGUNTAR O QUE FAZER, SE NAO PERGUNTAR O QUE FAZER)
            int totalCromos = GlobalConfig.Connection.TotalCromos((CadernetaModelo)ComboBoxCadernetas.SelectedItem);
            
            if(totalCromos == 0)
            {

            }
            else
            {

            }

        }

        private void ButtonLimpar_Click(object sender, EventArgs e)
        {
            ComboBoxCadernetas.SelectedItem = null;
            LimpaGrids();
            LimpaTexts();
        }

        private void LimpaTexts()
        {
            TextNome.Text = "";
            TextQuantidade.Text ="";
            TextQuantidadeCarteira.Text = "";
            TextCarteiraCusto.Text = "";
        }
    }
}
