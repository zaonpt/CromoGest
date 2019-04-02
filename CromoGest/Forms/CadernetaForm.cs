using CromoGest.Controls;
using CromoGestLibrary;
using CromoGestLibrary.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CromoGest.Forms
{
    public static class ExtensionMethods
    {
        public static void DoubleBuffered(this DataGridView dgv, bool setting)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, setting, null);
        }
    }

    public partial class CadernetaForm : Form
    {
        #region Declaracões de atributos (properties)
        private List<CadernetaModelo> cadernetas = GlobalConfig.Connection.GetCadernetas();
        private char charSeparador;
        private bool FullyLoaded = false;

        #endregion



        #region Metodos (methods) associados ao carregamento
        public CadernetaForm()
        {
            InitializeComponent();

            dataGridViewCaderneta.AutoGenerateColumns = false;
            charSeparador = GlobalConfig.Connection.GetConfig(ConfigCategory.CharSeparador.Value)[0];

            ResetComboBox();
            dataGridViewCaderneta.DoubleBuffered(true);
        }

        private void ResetComboBox()
        {
            ComboBoxCadernetas.DataSource = null;
            ComboBoxCadernetas.DataSource = cadernetas;
            ComboBoxCadernetas.DisplayMember = "Nome";
            ComboBoxCadernetas.ValueMember = "Id";
        }

        private void PreencheListas()
        {
            TextListaCromos.Text = "";
            TextListaRepetidos.Text = "";
            if (ComboBoxCadernetas.SelectedItem == null) return;

            foreach (PaginaModelo pagina in ((CadernetaModelo)ComboBoxCadernetas.SelectedItem).Paginas)
            {
                foreach (CromoModelo cromo in pagina.Cromos)
                {
                    PreencheCell(cromo);
                }
            }
            if (TextListaCromos.Text.Length > 2)
                TextListaCromos.Text = TextListaCromos.Text.Substring(2);
            if (TextListaRepetidos.Text.Length > 2)
                TextListaRepetidos.Text = TextListaRepetidos.Text.Substring(2);
        }

        private void PreencheCell(CromoModelo cromo)
        {
            if (cromo.Quantidade == 0)
                TextListaCromos.Text += $"{charSeparador} { cromo.Numero }";
            if (CBmultiRepetidos.Checked)
            {
                if (cromo.Quantidade > 1)
                    if (cromo.Quantidade == 2)
                        TextListaRepetidos.Text += $"{charSeparador} { cromo.Numero }";
                    else
                        TextListaRepetidos.Text += $"{charSeparador} { cromo.Quantidade - 1 }*{ cromo.Numero }";
            }
            else
            {
                if (cromo.Quantidade > 1)
                    TextListaRepetidos.Text += $"{charSeparador} { cromo.Numero }";
            }
        }

        private void LoadCadernetasGrid()
        {
            if (ComboBoxCadernetas.SelectedItem == null) return;
            ApagaGrid();
            foreach (CadernetaModelo caderneta in cadernetas)
            {
                if (caderneta.Id == ((CadernetaModelo)ComboBoxCadernetas.SelectedItem).Id)
                {
                    int numMaxCromosNasPaginas = GetNumMaxCromosNasPaginas(caderneta);
                    int numPaginas = caderneta.Paginas.Count;

                    LoadCadernetaCriaGrid(numMaxCromosNasPaginas, numPaginas);

                    LoadCadernetaPopulate(caderneta, numMaxCromosNasPaginas, numPaginas);
                }
            }
            PreencheListas();
        }

        private void LoadCadernetaPopulate(CadernetaModelo caderneta, int numMaxCromosNasPaginas, int numPaginas)
        {
            for (int i = 0; i < numPaginas; i++)
            {
                ((DataGridViewCromoCell)dataGridViewCaderneta.Rows[i].Cells[0]).Value = caderneta.Paginas[i].Nome;
                ((DataGridViewCromoCell)dataGridViewCaderneta.Rows[i].Cells[0]).PaginaCell = true;
            }

            for (int row = 0; row < numPaginas; row++)
            {
                for (int col = 0; col < numMaxCromosNasPaginas; col++)
                {
                    if (col < caderneta.Paginas[row].Cromos.Count)
                    {
                        ((DataGridViewCromoCell)dataGridViewCaderneta.Rows[row].Cells[col + 1]).Value = caderneta.Paginas[row].Cromos[col].Numero;
                        ((DataGridViewCromoCell)dataGridViewCaderneta.Rows[row].Cells[col + 1]).NumCromos = caderneta.Paginas[row].Cromos[col].Quantidade;
                        ((DataGridViewCromoCell)dataGridViewCaderneta.Rows[row].Cells[col + 1]).ToolTipText = caderneta.Paginas[row].Cromos[col].Descricao;
                    }
                    else
                    {
                        ((DataGridViewCromoCell)dataGridViewCaderneta.Rows[row].Cells[col + 1]).EmptyCell = true;
                    }

                }
            }
        }

        private void LoadCadernetaCriaGrid(int numMaxCromosNasPaginas, int numPaginas)
        {
            for (int col = 0; col < (numMaxCromosNasPaginas + 1); col++)
                dataGridViewCaderneta.Columns.Add(new DataGridViewCromoColumn());

            for (int row = 0; row < numPaginas; row++)
                dataGridViewCaderneta.Rows.Add(new DataGridViewRow());
        }

        private void ApagaGrid()
        {
            for (int i = 0; i < dataGridViewCaderneta.Rows.Count; i++)
                dataGridViewCaderneta.Rows.Remove(dataGridViewCaderneta.Rows[i]);

            for (int i = 0; i < dataGridViewCaderneta.Columns.Count; i++)
                dataGridViewCaderneta.Columns.Remove(dataGridViewCaderneta.Columns[i]);
            dataGridViewCaderneta.Rows.Clear();
            dataGridViewCaderneta.Columns.Clear();
            dataGridViewCaderneta.Refresh();
        }
        #endregion



        #region Eventos
        private void ComboBoxCadernetas_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewCaderneta.RowHeadersVisible = false;
            toolStripStatusLabel1.Text = "";
            if (ComboBoxCadernetas.SelectedItem == null) return;
            LoadCadernetasGrid();
            PreencheListas();
            if (((CadernetaModelo)ComboBoxCadernetas.SelectedItem).Paginas.Count == 0)
                toolStripStatusLabel1.Text = "Caderneta Incompleta. Entrar em \"Nova Caderneta\" e preencher informação em falta.";
            dataGridViewCaderneta.RowHeadersVisible = true;

        }

        private void dataGridViewCaderneta_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void dataGridViewCaderneta_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (CheckBoxHack.Checked)
            {
                int col = e.ColumnIndex;
                int row = e.RowIndex;

                string cromoNumero = dataGridViewCaderneta.Rows[row].Cells[col].Value.ToString();
                int idCadernetaSelecionada = ((CadernetaModelo)ComboBoxCadernetas.SelectedItem).Id;
                int cromoOldQuantidade = GlobalConfig.Connection.GetCromoQuatidade(cromoNumero, idCadernetaSelecionada);

                AccaoMouse(e, col, row, cromoNumero, idCadernetaSelecionada, cromoOldQuantidade);
                dataGridViewCaderneta.Refresh();
                PreencheListas();
            }
        }

        private void ButtonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CBmultiRepetidos_CheckedChanged(object sender, EventArgs e)
        {
            PreencheListas();
        }

        private void ButtonTrocas_Click(object sender, EventArgs e)
        {
            if (ComboBoxCadernetas.SelectedItem != null)
            {
                TrocasForm trocas = new TrocasForm(this, ComboBoxCadernetas.SelectedIndex);
                trocas.Show();
                this.Hide();
               
            }
            else toolStripStatusLabel1.Text = "Sem cadernetas. Criar uma nova.   ";

        }

        private void CadernetaForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true && FullyLoaded) {
                cadernetas = GlobalConfig.Connection.GetCadernetas();
                try
                {
                    ResetComboBox();
                    toolStripStatusLabel1.Text = "";
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void CadernetaForm_Shown(object sender, EventArgs e)
        {
            FullyLoaded = true;
        }

        private void ButtonNova_Click(object sender, EventArgs e)
        {
            NovaCadernetaForm formNova = new NovaCadernetaForm(this, ComboBoxCadernetas.SelectedIndex);
            formNova.Show();
            this.Hide();
        }

        private void ButtonEntradas_Click(object sender, EventArgs e)
        {
            if ((CadernetaModelo)ComboBoxCadernetas.SelectedItem != null)
            {
                EntradasForm entradas = new EntradasForm(this, ComboBoxCadernetas.SelectedIndex);
                entradas.Show();
                this.Hide();
            }
            else toolStripStatusLabel1.Text = "Sem cadernetas. Criar uma nova.   ";

        }
        #endregion



        #region Metodos de apoio
        private int GetNumMaxCromosNasPaginas(CadernetaModelo caderneta)
        {
            int nMax = 0;

            foreach (PaginaModelo pagina in caderneta.Paginas)
                nMax = (nMax < pagina.Cromos.Count) ? pagina.Cromos.Count : nMax;

            return nMax;
        }

        private void SetCromosColors(Color backcolor, Color textColor, DataGridViewCell cell)
        {
            cell.Style.BackColor = backcolor;
            cell.Style.SelectionBackColor = backcolor;
            cell.Style.ForeColor = textColor;
            cell.Style.SelectionForeColor = textColor;
        }

        private void AccaoMouse(DataGridViewCellMouseEventArgs e, int col, int row, string cromoNumero, int idCadernetaSelecionada, int cromoOldQuantidade)
        {
            int cromoNewQuantidade;
            switch (e.Button)
            {
                case MouseButtons.Left:
                    AccaoIncCromo(col, row, cromoNumero, idCadernetaSelecionada);
                    break;
                case MouseButtons.Right:
                    if (cromoOldQuantidade > 0)
                    {
                        cromoNewQuantidade = AccaoDecCromo(col, row, cromoNumero, idCadernetaSelecionada);
                    }
                    break;
            }
        }

        private int AccaoDecCromo(int col, int row, string cromoNumero, int idCadernetaSelecionada)
        {
            int cromoNewQuantidade = GlobalConfig.Connection.DecCromoQuatidade(cromoNumero, idCadernetaSelecionada);
            ((CadernetaModelo)ComboBoxCadernetas.SelectedItem).Paginas[row].Cromos[col - 1].Quantidade--;
            ((DataGridViewCromoCell)dataGridViewCaderneta.Rows[row].Cells[col]).NumCromos--;
            toolStripStatusLabel1.Text = $"Cromo { cromoNumero } foi reduzida a quantidade.";
            return cromoNewQuantidade;
        }

        private void AccaoIncCromo(int col, int row, string cromoNumero, int idCadernetaSelecionada)
        {
            GlobalConfig.Connection.IncCromoQuatidade(cromoNumero, idCadernetaSelecionada);
            ((CadernetaModelo)ComboBoxCadernetas.SelectedItem).Paginas[row].Cromos[col - 1].Quantidade++;
            ((DataGridViewCromoCell)dataGridViewCaderneta.Rows[row].Cells[col]).NumCromos++;
            toolStripStatusLabel1.Text = $"Cromo { cromoNumero } adicionado.";
        }

        #endregion
    }
}
