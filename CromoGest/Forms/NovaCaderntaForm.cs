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
    public partial class NovaCadernetaForm : Form
    {
        private List<CadernetaModelo> cadernetasExistentes = GlobalConfig.Connection.GetCadernetas();
        private List<CromoModelo> CromosCadernetaSelecionada = new List<CromoModelo>();
        private CadernetaForm caderneta;
               
        public NovaCadernetaForm()
        { 
            InitializeComponent();
            LigaLista();
            DataGridViewCromos.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
        }

        public NovaCadernetaForm(CadernetaForm cadernetaIN, int cbIndex)
        {
            InitializeComponent();
            LigaLista();
            DataGridViewCromos.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            caderneta = cadernetaIN;
            ComboBoxCadernetas.SelectedIndex = cbIndex;
        }

        private void LigaTextboxes(bool ligar)
        {
            TextNome.Enabled = ligar;
            TextQuantidade.Enabled = ligar;
            TextQuantidadeCarteira.Enabled = ligar;
            TextCarteiraCusto.Enabled = ligar;
        }

        private void LigaGrid(DataGridView dgv, bool liga)
        {
            if (liga)
            {
                foreach (DataGridViewColumn c in dgv.Columns)
                {
                    c.DefaultCellStyle.SelectionForeColor = Color.Black;
                    c.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
            else
            {
                dgv.ForeColor = Color.Gray;
                dgv.DefaultCellStyle.ForeColor = Color.Gray;
                foreach (DataGridViewColumn c in dgv.Columns)
                {
                    c.DefaultCellStyle.SelectionForeColor = Color.Gray;
                    c.DefaultCellStyle.ForeColor = Color.Gray;
                }
            }
        }

        private void LimparGrid(DataGridView dgv)
        {
            if (dgv.Rows.Count > 0) dgv.Rows.Clear();
        }

        private void LigaButtonsPaginas(bool liga)
        {
            DataGridViewPaginas.Enabled = liga;
            ButtonAceitarPaginas.Enabled = liga;
        }

        private void LigaButtonsCromos(bool liga) {
            DataGridViewCromos.Enabled = liga;
            ButtonConcluir.Enabled = liga;
        }

        private void ResetComboBox()
        {
            ComboBoxCadernetas.DataSource = null;
            ComboBoxCadernetas.DataSource = cadernetasExistentes;
            ComboBoxCadernetas.DisplayMember = "Nome";
            ComboBoxCadernetas.ValueMember = "Id";
        }

        private void ResetGridPaginas()
        {
            DataGridViewPaginas.DataSource = ((CadernetaModelo)ComboBoxCadernetas.SelectedItem).Paginas;
            DataGridViewPaginas.Columns["IdCaderneta"].Visible = false;
            DataGridViewPaginas.Columns["Id"].Visible = false;
        }

        private void LigaLista()
        {
            ResetComboBox();
            ResetGridPaginas();
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
                GlobalConfig.Connection.NewCaderneta(caderneta);
                cadernetasExistentes.Add(caderneta);
                LigaLista();
                
                // TODO - Apagar proxima linha quando implentar bindagem aos TextBoxes
                ComboBoxCadernetas.SelectedValue = caderneta.Id;

                LigaGridPaginas();
                ToolStripLabelNovaCaderneta.Text = "Proximo passo é preencher informação das páginas. Descrição da pagina e quantidade de cromos por pagina";
                ToolStripNovaCaderneta.Update();
            }
            else { MessageBox.Show("Campos incorrectos, verificar e tentar novamente."); }
        }

        private bool ValidarForm()
        {
            bool valido = true;
            if (!int.TryParse(TextQuantidade.Text, out int Quantidade) || Quantidade<1) { valido = false; }
            if (TextNome.Text.Length==0) { valido = false; }
            if (!decimal.TryParse(TextCarteiraCusto.Text, out decimal Custo) || Custo==0) { valido = false; }
            if(!int.TryParse(TextQuantidadeCarteira.Text, out int CQuantidade) || CQuantidade== 0) { valido = false; }
            return valido;
        }

        private void LimpaGrids()
        {
            DataGridViewPaginas.AutoGenerateColumns = false;
            DataGridViewPaginas.DataSource = null;
            DataGridViewCromos.AutoGenerateColumns = false;
            DataGridViewCromos.DataSource = null;
            LimparGrid(DataGridViewPaginas);
            LimparGrid(DataGridViewCromos);
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
                    LigaGrid(DataGridViewPaginas,true);
                    DataGridViewPaginas.Enabled = true;
                    ButtonAceitarPaginas.Enabled = true;
                    ToolStripLabelNovaCaderneta.Text = "Caderneta sem Paginas nem Cromos inseridos. Por favor preencher a informação das Paginas primeiro";
                    ToolStripNovaCaderneta.Update();
                }
                else
                {
                    DataGridViewPaginas.DataSource = ((CadernetaModelo)ComboBoxCadernetas.SelectedItem).Paginas;
                    FillCromos();
                    LigaGrid(DataGridViewCromos,false);
                    LigaButtonsCromos(false);

                    LigaGrid(DataGridViewPaginas,false);
                    DataGridViewPaginas.Enabled = false;
                    ButtonAceitarPaginas.Enabled = false;

                    LigaTextboxes(false);

                    ButtonCriar.Enabled=false;
                    ToolStripLabelNovaCaderneta.Text = "Criação da Caderneta terminada.";
                    ToolStripNovaCaderneta.Update();
                }
            }
            else
            {
                ToolStripLabelNovaCaderneta.Text = "Preencher informação geral da caderneta";
                ToolStripNovaCaderneta.Update();
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
            LigaGrid(DataGridViewPaginas, true);
            LigaButtonsPaginas(true);
            LigaGrid(DataGridViewCromos, false);
            LigaButtonsCromos(false);
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
            if (!int.TryParse(TextQuantidade.Text, out int quantidadeText)) { MessageBox.Show("Quantidade de cromos invalida!"); }
            else if (quantidade == quantidadeText)
            {
                LigaGrid(DataGridViewPaginas, false);
                LigaButtonsPaginas(false);
                CromosCadernetaSelecionada = null;
                CromosCadernetaSelecionada = new List<CromoModelo>();

                LigaGrid(DataGridViewCromos, true);
                LigaButtonsCromos(true);
                int cromosTotal = 1;
                int paginas = DataGridViewPaginas.Rows.Count-1;
                for (int p = 0; p < paginas; p++)
                {
                    string novaPaginaNome = DataGridViewPaginas.Rows[p].Cells["Nome"].Value.ToString();
                        
                    novaPagina = new PaginaModelo(nome: novaPaginaNome, idCaderneta: caderneta.Id);
                    caderneta.Paginas.Add(novaPagina);
                    int cromos = Convert.ToInt32(DataGridViewPaginas.Rows[p].Cells["Quantidade"].Value);
                    for (int c = 0;  c < cromos; c++)
                    {
                        string novoCromoNumero = (cromosTotal++).ToString();
                        string novoCromoDescricao = "";
                        novoCromo = new CromoModelo(numero : novoCromoNumero, descricao: novoCromoDescricao, idPagina: novaPagina.Id);
                        caderneta.Paginas[p].Cromos.Add(novoCromo);
                        CromosCadernetaSelecionada.Add(novoCromo);
                    }
                }
                DataGridViewCromos.DataSource = CromosCadernetaSelecionada;
                DataGridViewCromos.Columns["Id"].Visible = false;
                DataGridViewCromos.Columns["Quantidade"].Visible = false;
                DataGridViewCromos.Columns["IdPagina"].Visible = false;
                DataGridViewCromos.Refresh();
                ToolStripLabelNovaCaderneta.Text = "Criação da Caderneta terminada.";
                ToolStripNovaCaderneta.Update();
            }
            else { MessageBox.Show("Erro: Quantidade errada de cromos. O total de cromos tem de ser igual à soma dos cromo das paginas."); }
        }

        private bool ConfirmadoGravar() {
            string message = "Tem a certeza que a informação que introduziu está toda correcta?";
            string caption = "Atenção:";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            return (MessageBox.Show(message, caption, buttons) == DialogResult.Yes);
        }

        private void ButtonGravar_Click(object sender, EventArgs e)
        {
            if (ConfirmadoGravar() && DadosValidados())
            {
                CadernetaModelo caderneta = (CadernetaModelo)ComboBoxCadernetas.SelectedItem;
                if (caderneta.Paginas.Count == 0)
                {
                    int totalCromos = SomatorioCromosPaginas();
                    int cromoCounter = 0;
                    int nrows = DataGridViewPaginas.Rows.Count - 1;
                    for (int j = 0; j < nrows; j++)
                    {
                        int cromosPagina = Convert.ToInt32(DataGridViewPaginas.Rows[j].Cells["Quantidade"].Value.ToString());
                        caderneta.Paginas.Add(new PaginaModelo(
                                DataGridViewPaginas.Rows[j].Cells["Pagina"].Value.ToString(),
                                idCaderneta: caderneta.Id
                                ));
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
                }
                GlobalConfig.Connection.PopulateCaderneta(caderneta);
                MessageBox.Show("Caderneta Criada com sucesso!");
            }
        }

        private bool DadosValidados()
        {
            return SomatorioCromosPaginas() == Convert.ToInt32(TextQuantidade.Text);
        }

        private void LigaBotoes(bool liga)
        {
            ButtonCriar.Enabled = liga;
            ButtonLimpar.Enabled = liga;
            ButtonEliminar.Enabled = liga;
        }

        private void ButtonLimpar_Click(object sender, EventArgs e)
        {
            ComboBoxCadernetas.SelectedItem = null;
            LimpaGrids();
            LimpaTexts();
            LigaGrid(DataGridViewPaginas, false);
            LigaButtonsPaginas(false);
            LigaGrid(DataGridViewCromos, false);
            LigaButtonsCromos(false);
            LigaTextboxes(true);
            LigaBotoes(true);
        }

        private void LimpaTexts()
        {
            TextNome.Text = "";
            TextQuantidade.Text = "";
            TextQuantidadeCarteira.Text = "";
            TextCarteiraCusto.Text = "";
        }

        private void ButtonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ConfirmadoEliminar()
        {
            string caption = "Atenção:";
            string message = "Tem a certeza que quer eliminar a caderneta : "+ ((CadernetaModelo)ComboBoxCadernetas.SelectedItem).Nome +"?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            return (MessageBox.Show(message, caption, buttons) == DialogResult.Yes);
        }

        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            if (ConfirmadoEliminar())
            {
                GlobalConfig.Connection.DeleteCaderneta(((CadernetaModelo)ComboBoxCadernetas.SelectedItem).Id);
                cadernetasExistentes.Remove((CadernetaModelo)ComboBoxCadernetas.SelectedItem);
                ResetComboBox();
                LimpaGrids();
                LimpaTexts();
                LigaBotoes(true);
                LigaButtonsCromos(true);
                LigaTextboxes(true);
                LimparGrid(DataGridViewPaginas);
            }
        }

        /// <summary>
        /// past from clipboard
        /// </summary>
        /// <remarks>CREDITS TO: Pratik Bhoir in https://stackoverflow.com/questions/22833327/pasting-excel-data-into-a-blank-datagridview-index-out-of-range-exception</remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewCromos_KeyUp(object sender, KeyEventArgs e)
        {
            //if user clicked Shift+Ins or Ctrl+V (paste from clipboard)
            
            if ((e.Shift && e.KeyCode == Keys.Insert) || (e.Control && e.KeyCode == Keys.V))
            {
                char[] rowSplitter = { '\r', '\n' };
                char[] columnSplitter = { '\t' };

                //get the text from clipboard
                IDataObject dataInClipboard = Clipboard.GetDataObject();
                string stringInClipboard = (string)dataInClipboard.GetData(DataFormats.Text);

                //split it into lines
                string[] rowsInClipboard = stringInClipboard.Split(rowSplitter, StringSplitOptions.RemoveEmptyEntries);

                //get the row and column of selected cell in grid
                int r = DataGridViewCromos.SelectedCells[0].RowIndex;
                int c = DataGridViewCromos.SelectedCells[0].ColumnIndex;

                //add rows into grid to fit clipboard lines
                if (DataGridViewCromos.Rows.Count < (r + rowsInClipboard.Length))
                {
                    DataGridViewCromos.Rows.Add(r + rowsInClipboard.Length - DataGridViewCromos.Rows.Count);
                }

                // loop through the lines, split them into cells and place the values in the corresponding cell.
                for (int iRow = 0; iRow < rowsInClipboard.Length; iRow++)
                {
                    //split row into cell values
                    string[] valuesInRow = rowsInClipboard[iRow].Split(columnSplitter);

                    //cycle through cell values
                    for (int iCol = 0; iCol < valuesInRow.Length; iCol++)
                    {
                        //assign cell value, only if it within columns of the grid
                        if (DataGridViewCromos.ColumnCount - 1 >= c + iCol)
                        {
                            DataGridViewCromos.Rows[r + iRow].Cells[c + iCol].Value = valuesInRow[iCol];
                        }
                    }
                }
            }
        }

        private void NovaCaderneta_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            caderneta.Show();
        }
    }
}
