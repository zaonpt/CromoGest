using CromoGest.Controls;
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
        private char charSeparador;

        public CadernetaForm()
        {
            InitializeComponent();

            dataGridViewCaderneta.AutoGenerateColumns = false;
            charSeparador = GlobalConfig.Connection.GetConfig(ConfigCategory.CharSeparador.Value)[0];

            ResetComboBox();
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
            ApagaGrid();
            foreach (CadernetaModelo caderneta in cadernetas)
            {
                if (caderneta.Id == ((CadernetaModelo)ComboBoxCadernetas.SelectedItem).Id)
                {
                    int numMaxCromosNasPaginas = GetNumMaxCromosNasPaginas(caderneta);
                    int numPaginas = caderneta.Paginas.Count;

                    //adiciona colunas
                    for (int col = 0; col < (numMaxCromosNasPaginas + 1); col++)
                        dataGridViewCaderneta.Columns.Add(new DataGridViewCromoColumn());

                    //adiciona linhas
                    for (int row = 0; row < numPaginas; row++)
                        dataGridViewCaderneta.Rows.Add(new DataGridViewRow());

                    //preenche primeira coluna (nome das paginas)
                    for (int i = 0; i < numPaginas; i++)
                    {
                        ((DataGridViewCromoCell)dataGridViewCaderneta.Rows[i].Cells[0]).Value = caderneta.Paginas[i].Nome;
                        ((DataGridViewCromoCell)dataGridViewCaderneta.Rows[i].Cells[0]).NumCromos = -1;
                    }

                    //preenche cromos e quantidade de cromos
                    for (int col = 0; col < numMaxCromosNasPaginas; col++)
                    {
                        for (int row = 0; row < numPaginas; row++)
                        {
                            ((DataGridViewCromoCell)dataGridViewCaderneta.Rows[row].Cells[col+1]).Value = caderneta.Paginas[row].Cromos[col].Numero;
                            ((DataGridViewCromoCell)dataGridViewCaderneta.Rows[row].Cells[col+1]).NumCromos = caderneta.Paginas[row].Cromos[col].Quantidade;
                        }
                    }
                }
            }

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

        private int GetNumMaxCromosNasPaginas(CadernetaModelo caderneta)
        {
            int nMax = 0;

            foreach (PaginaModelo pagina in caderneta.Paginas)
                nMax = (nMax < pagina.Cromos.Count) ? pagina.Cromos.Count : nMax;

            return nMax;
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
            NovaCadernetaForm formNova = new NovaCadernetaForm(this, ComboBoxCadernetas.SelectedIndex);
            formNova.Show();
            this.Hide();
            cadernetas = GlobalConfig.Connection.GetCadernetas();
        }

        private void ButtonEntradas_Click(object sender, EventArgs e)
        {
            EntradasForm entradas = new EntradasForm(this, ComboBoxCadernetas.SelectedIndex);
            entradas.Show();
            this.Hide();
        }

        private void SetCromosColors(Color backcolor, Color textColor, DataGridViewCell cell)
        {
            cell.Style.BackColor = backcolor;
            cell.Style.SelectionBackColor = backcolor;
            cell.Style.ForeColor = textColor;
            cell.Style.SelectionForeColor = textColor;
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
                int cromoNewQuantidade;
                switch (e.Button)
                {
                    case MouseButtons.Left:
                        GlobalConfig.Connection.IncCromoQuatidade(cromoNumero, idCadernetaSelecionada);
                        ((CadernetaModelo)ComboBoxCadernetas.SelectedItem).Paginas[row].Cromos[col-1].Quantidade++;
                        ((DataGridViewCromoCell)dataGridViewCaderneta.Rows[row].Cells[col]).NumCromos++;
                        ToolStripStatusLabelCaderneta.Text = $"Cromo { cromoNumero } adicionado.";
                        break;
                    case MouseButtons.Right:
                        if (cromoOldQuantidade > 0)
                        {
                            cromoNewQuantidade = GlobalConfig.Connection.DecCromoQuatidade(cromoNumero, idCadernetaSelecionada);
                            ((CadernetaModelo)ComboBoxCadernetas.SelectedItem).Paginas[row].Cromos[col-1].Quantidade--;
                            ((DataGridViewCromoCell)dataGridViewCaderneta.Rows[row].Cells[col]).NumCromos--;
                            ToolStripStatusLabelCaderneta.Text = $"Cromo { cromoNumero } foi reduzida a quantidade.";
                        }
                        break;
                }
                dataGridViewCaderneta.Refresh();
            }
        }

        private void ButtonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
