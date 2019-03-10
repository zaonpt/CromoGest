﻿using CromoGestLibrary;
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
                        novaPagina[cromoPosicao] = cromo.Numero;
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
            ColorGrid();
            dataGridViewCaderneta.Refresh();
            dataGridViewCaderneta.ClearSelection();
        }

        private void ColorGrid()
        {
            int colsCount;
            int quantidade;
            foreach (DataGridViewRow row in dataGridViewCaderneta.Rows)
            {
                colsCount = dataGridViewCaderneta.Columns.Count;
                for (int col = 1; col < colsCount; col++)
                {
                    quantidade = GlobalConfig.Connection.GetCromoQuatidade(
                          row.Cells[col].Value.ToString(),
                          ((CadernetaModelo)ComboBoxCadernetas.SelectedItem).Id);

                    switch (quantidade)
                    {
                        case 0:
                            PaintCell(row.Cells[col], Color.LightSalmon);
                            break;
                        case 1:
                            PaintCell(row.Cells[col], Color.LightGreen);
                            break;
                        default:
                            PaintCell(row.Cells[col], Color.Green);
                            break;
                    }
                    row.Cells[col].Tag = quantidade;
                }
            }
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
            NovaCadernetaForm formNova = new NovaCadernetaForm(this);
            formNova.Show();
            this.Hide();
            cadernetas = GlobalConfig.Connection.GetCadernetas();
        }

        private void ButtonEntradas_Click(object sender, EventArgs e)
        {
            EntradasForm entradas = new EntradasForm(this);
            entradas.Show();
            this.Hide();
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
                        if (GlobalConfig.Connection.IncCromoQuatidade(cromoNumero, idCadernetaSelecionada) == 1)
                        {
                            dataGridViewCaderneta.Rows[row].Cells[col].Style.BackColor = Color.LightGreen;
                            dataGridViewCaderneta.Rows[row].Cells[col].Style.SelectionBackColor = Color.LightGreen;
                        }
                        else // > 1 (com repetidos)
                        {
                            dataGridViewCaderneta.Rows[row].Cells[col].Style.BackColor = Color.Green;
                            dataGridViewCaderneta.Rows[row].Cells[col].Style.SelectionBackColor = Color.Green;
                        }
                        ToolStripStatusLabelCaderneta.Text = $"Cromo { cromoNumero } adicionado.";
                        break;
                    case MouseButtons.Right:
                        if (cromoOldQuantidade > 0)
                        {
                            cromoNewQuantidade = GlobalConfig.Connection.DecCromoQuatidade(cromoNumero, idCadernetaSelecionada);
                            switch (cromoNewQuantidade)
                            {
                                case 0:
                                    dataGridViewCaderneta.Rows[row].Cells[col].Style.BackColor = Color.LightSalmon;
                                    dataGridViewCaderneta.Rows[row].Cells[col].Style.SelectionBackColor = Color.LightSalmon;
                                    break;
                                case 1:
                                    dataGridViewCaderneta.Rows[row].Cells[col].Style.BackColor = Color.LightGreen;
                                    dataGridViewCaderneta.Rows[row].Cells[col].Style.SelectionBackColor = Color.LightGreen;
                                    break;
                                default:
                                    dataGridViewCaderneta.Rows[row].Cells[col].Style.BackColor = Color.Green;
                                    dataGridViewCaderneta.Rows[row].Cells[col].Style.SelectionBackColor = Color.Green;
                                    break;
                            }
                            ToolStripStatusLabelCaderneta.Text = $"Cromo { cromoNumero } foi reduzida a quantidade.";
                        }
                        break;
                }
            }
        }

        private void ButtonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PaintCell(DataGridViewCell cell, Color color)
        {
            cell.Style.BackColor = color;
            cell.Style.SelectionBackColor = color;                
        }

        private void dataGridViewCaderneta_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ColorGrid();
        }

    }
}
