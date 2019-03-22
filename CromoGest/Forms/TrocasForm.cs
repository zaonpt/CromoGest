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
        private List<CadernetaModelo> cadernetas = GlobalConfig.Connection.GetCadernetas();
        private List<TrocaModelo> trocas = new List<TrocaModelo>();
        private char charSeparador;


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

            SetupGrid();
            ResetComboBox();

        }

        #region Métodos suporte
        /// <summary>
        /// Cria as colunas da Grid.
        /// </summary>
        private void SetupGrid()
        {


            DataGridViewColumn col1 = new DataGridViewColumn();
            DataGridViewColumn col2 = new DataGridViewColumn();
            DataGridViewColumn col3 = new DataGridViewColumn();
            DataGridViewColumn col4 = new DataGridViewColumn();
            DataGridViewColumn col5 = new DataGridViewColumn();
            DataGridViewColumn col6 = new DataGridViewColumn();
            DataGridViewColumn col7 = new DataGridViewColumn();
            DataGridViewColumn col8 = new DataGridViewColumn();
            DataGridViewColumn col9 = new DataGridViewColumn();
            DataGridViewColumn col10 = new DataGridViewColumn();
            DataGridViewColumn col11 = new DataGridViewColumn();
            DataGridViewColumn col12 = new DataGridViewColumn();
            DataGridViewColumn col13 = new DataGridViewColumn();
            DataGridViewColumn col14 = new DataGridViewColumn();

            col1.Name = "NumTroca";
            col1.HeaderText = "Troca";
            col2.Name = "Progresso";
            col2.HeaderText = "Progresso";
            col3.Name = "Dest_Iniciais";
            col3.HeaderText = $"Destinatário{Environment.NewLine}Iniciais";
            col4.Name = "Dest_Nome";
            col4.HeaderText = $"Destinatário{Environment.NewLine}Nome";
            col5.Name = "Dest_Origem";
            col5.HeaderText = $"Destinatário{Environment.NewLine}Origem";
            col6.Name = "Dest_Reputacao";
            col6.HeaderText = $"Destinatário{Environment.NewLine}Reputação";
            col7.Name = "Dest_Morada";
            col7.HeaderText = $"Destinatário{Environment.NewLine}Morada";
            col8.Name = "QuantidadeCromosRecebidos";
            col8.HeaderText = $"Recebidos{Environment.NewLine}#";
            col9.Name = "ListCromosRecebidos";
            col9.HeaderText = $"Recebidos{Environment.NewLine}Cromos";
            col10.Name = "QuantidadeCromosEnviados";
            col10.HeaderText = $"Enviados{Environment.NewLine}#";
            col11.Name = "ListCromosEnviados";
            col11.HeaderText = $"Enviados{Environment.NewLine}Cromos";
            col12.Name = "DataProposta";
            col12.HeaderText = $"Data{Environment.NewLine}Proposto";
            col13.Name = "DataEnvio";
            col13.HeaderText = $"Data{Environment.NewLine}Envio";
            col14.Name = "DataRececao";
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

            dataGridViewTrocas.AutoGenerateColumns = false;
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
            //dataGridViewTrocas.Columns["Id"].Visible = false;
            //dataGridViewTrocas.Columns["Destinatario"].Visible = false;
            //dataGridViewTrocas.Columns["CromosEnviados"].Visible = false;
            //dataGridViewTrocas.Columns["CromosRecebidos"].Visible = false;
        }



        #endregion




        #region Eventos
        private void CadernetasComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxCadernetas.SelectedItem == null) return;
            trocas = GlobalConfig.Connection.GetTrocas((CadernetaModelo)ComboBoxCadernetas.SelectedItem);
            LoadTrocasToGrid();
        }



        #endregion
    }
}
