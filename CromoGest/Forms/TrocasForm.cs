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
        public TrocasForm()
        {
            InitializeComponent();
            SetupGrid();
        }


        public TrocasForm(CadernetaForm cadernetaIN, int cbIndex)
        {
            InitializeComponent();
            SetupGrid();
        }

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

            col1.Name = col1.HeaderText = "Troca";
            col2.Name = col2.HeaderText = "Progresso";
            col3.Name = "Iniciais";
            col3.HeaderText = $"Destinatário{Environment.NewLine}Iniciais";
            col4.Name = "Nome";
            col4.HeaderText = $"Destinatário{Environment.NewLine}Nome";
            col5.Name = "Origem";
            col5.HeaderText = $"Destinatário{Environment.NewLine}Origem";
            col6.Name = "Feedback";
            col6.HeaderText = $"Destinatário{Environment.NewLine}Feedback";
            col7.Name = "Morada";
            col7.HeaderText = $"Destinatário{Environment.NewLine}Morada";
            col8.Name = "QuantRecebidos";
            col8.HeaderText = $"Recebidos{Environment.NewLine}#";
            col9.Name = "CromosRecebidos";
            col9.HeaderText = $"Recebidos{Environment.NewLine}Cromos";
            col10.Name = "QuantEnviados";
            col10.HeaderText = $"Enviados{Environment.NewLine}#";
            col11.Name = "CromosEnviados";
            col11.HeaderText = $"Enviados{Environment.NewLine}Cromos";
            col12.Name = "PropostoData";
            col12.HeaderText = $"Data{Environment.NewLine}Proposto";
            col13.Name = "EnvioData";
            col13.HeaderText = $"Data{Environment.NewLine}Envio";
            col14.Name = "Rececao";
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
    }
}
