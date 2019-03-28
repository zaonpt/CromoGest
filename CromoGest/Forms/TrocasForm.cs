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
    public partial class TrocasForm : Form
    {
        #region Atributos
        private List<CadernetaModelo> cadernetas = GlobalConfig.Connection.GetCadernetas();
        private List<TrocaModelo> trocas = new List<TrocaModelo>();
        private char charSeparador;
        CadernetaForm caderneta;
        #endregion

        #region Metodos de Arranque
        /// <summary>
        /// Construtor Generico - usado por debuging.
        /// </summary>
        public TrocasForm()
        {
            InitializeComponent();

            charSeparador = GlobalConfig.Connection.GetConfig(ConfigCategory.CharSeparador.Value)[0];

            SetupGrid();
            ResetComboBox();
        }


        /// <summary>
        /// construtor chamado apartir da form Cadernetas.
        /// </summary>
        /// <param name="cadernetaIN"></param>
        /// <param name="cbIndex"></param>
        public TrocasForm(CadernetaForm cadernetaIN, int cbIndex)
        {
            InitializeComponent();

            charSeparador = GlobalConfig.Connection.GetConfig(ConfigCategory.CharSeparador.Value)[0];
            caderneta = cadernetaIN;
            SetupGrid();
            ResetComboBox();
            ComboBoxCadernetas.SelectedIndex = cbIndex;
        }

        /// <summary>
        /// Cria as colunas da Grid.
        /// </summary>
        private void SetupGrid()
        {
            dataGridViewTrocas.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col6 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col7 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col8 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col9 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col10 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col11 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col12 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col13 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col14 = new DataGridViewTextBoxColumn();

            col1.DataPropertyName = col1.Name = "NumTroca";
            col1.HeaderText = "Troca";
            col2.DataPropertyName = col2.Name = "Progresso";
            col2.HeaderText = "Progresso";
            col3.DataPropertyName = col3.Name = "Dest_Iniciais";
            col3.HeaderText = $"Dest.{Environment.NewLine}Iniciais";
            col4.DataPropertyName = col4.Name = "Dest_Nome";
            col4.HeaderText = $"Dest.{Environment.NewLine}Nome";
            col5.DataPropertyName = col5.Name = "Dest_Origem";
            col5.HeaderText = $"Dest.{Environment.NewLine}Origem";
            col6.DataPropertyName = col6.Name = "Dest_Reputacao";
            col6.HeaderText = $"Dest.{Environment.NewLine}Reputação";
            col7.DataPropertyName = col7.Name = "Dest_Morada";
            col7.HeaderText = $"Dest.{Environment.NewLine}Morada";
            col8.DataPropertyName = col8.Name = "QuantidadeCromosRecebidos";
            col8.HeaderText = $"R.{Environment.NewLine}#";
            col9.DataPropertyName = col9.Name = "ListCromosRecebidos";
            col9.HeaderText = $"Recebidos{Environment.NewLine}Cromos";
            col10.DataPropertyName = col10.Name = "QuantidadeCromosEnviados";
            col10.HeaderText = $"E.{Environment.NewLine}#";
            col11.DataPropertyName = col11.Name = "ListCromosEnviados";
            col11.HeaderText = $"Enviados{Environment.NewLine}Cromos";
            col12.DataPropertyName = col12.Name = "DataProposta";
            col12.HeaderText = $"Data{Environment.NewLine}Proposto";
            col13.DataPropertyName = col13.Name = "DataEnvio";
            col13.HeaderText = $"Data{Environment.NewLine}Envio";
            col14.DataPropertyName = col14.Name = "DataRececao";
            col14.HeaderText = $"Data{Environment.NewLine}Receção";

            dataGridViewTrocas.Columns.Add(col1);
            dataGridViewTrocas.Columns.Add(col2);
            dataGridViewTrocas.Columns.Add(col3);
            dataGridViewTrocas.Columns.Add(col4);
            dataGridViewTrocas.Columns.Add(col5);
            dataGridViewTrocas.Columns.Add(col6);
            dataGridViewTrocas.Columns.Add(col7);
            dataGridViewTrocas.Columns.Add(col8);
            dataGridViewTrocas.Columns.Add(col9);
            dataGridViewTrocas.Columns.Add(col10);
            dataGridViewTrocas.Columns.Add(col11);
            dataGridViewTrocas.Columns.Add(col12);
            dataGridViewTrocas.Columns.Add(col13);
            dataGridViewTrocas.Columns.Add(col14);
        }

        private void ResetComboBox()
        {
            ComboBoxCadernetas.DataSource = null;
            ComboBoxCadernetas.DataSource = cadernetas;
            ComboBoxCadernetas.DisplayMember = "Nome";
            ComboBoxCadernetas.ValueMember = "Id";
        }

        /// <summary>
        /// Carrega trocas, garantido que a ComboBox não é nula
        /// </summary>
        private void LoadTrocasToGrid()
        {
            if (trocas == null) return;
            dataGridViewTrocas.DataSource = null;
            dataGridViewTrocas.DataSource = trocas;
        }


        #endregion

        #region Métodos suporte



        #endregion

        #region Eventos
        private void CadernetasComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxCadernetas.SelectedItem == null) return;
            trocas = GlobalConfig.Connection.GetTrocas((CadernetaModelo)ComboBoxCadernetas.SelectedItem);
            LoadTrocasToGrid();
        }

        private void TrocasForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            caderneta.Show();
        }

        private void ButtonNova_Click(object sender, EventArgs e)
        {
            if ((CadernetaModelo)ComboBoxCadernetas.SelectedItem != null)
            {
                this.Hide();
                NovaTrocaForm formNova = new NovaTrocaForm(this, ((CadernetaModelo)ComboBoxCadernetas.SelectedItem));
                formNova.Show();
                this.Hide();
            }
        }

        private void TrocasForm_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                trocas = GlobalConfig.Connection.GetTrocas((CadernetaModelo)ComboBoxCadernetas.SelectedItem);
                LoadTrocasToGrid();
            }
        }


        #endregion

    }
}
