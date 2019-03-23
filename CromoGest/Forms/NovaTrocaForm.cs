using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CromoGest.Controls;
using CromoGestLibrary;
using CromoGestLibrary.Modelos;

namespace CromoGest.Forms
{
    public partial class NovaTrocaForm : Form
    {
        private TrocasForm formPai;
        private CadernetaModelo caderneta;
        private DestinatarioPickerForm FormFilhoDest;

        public NovaTrocaForm()
        {
            InitializeComponent();
        }

        public NovaTrocaForm(TrocasForm formArgPai, CadernetaModelo cadernetaArg)
        {
            InitializeComponent();
            if (cadernetaArg == null)
            {
                this.Hide();
                formArgPai.Show();
                this.Close();
            }

            formPai = formArgPai;
            caderneta = cadernetaArg;
            cadernetaLabel.Text = $"Caderneta: {caderneta.Nome}";
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxCromosEnviados.Clear();
            textBoxCromosRecebidos.Clear();
            textBoxIniciais.Clear();
            textBoxMorada.Clear();
            textBoxNome.Clear();
            textBoxOrigem.Clear();
            textBoxReputacao.Clear();
            comboBoxProgresso.Text = "";
            dateTimePickerEnvio.ResetText();
            dateTimePickerProposta.ResetText();
            dateTimePickerRececao.ResetText();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (!EntradasValidas()) { return; }
            int numTroca = GlobalConfig.Connection.GetNextTrocaNum(caderneta.Id);
            int idDestinatario = GlobalConfig.Connection.SetDestinatario(textBoxNome.Text, textBoxIniciais.Text,
                textBoxOrigem.Text, textBoxReputacao.Text, textBoxMorada.Text);
            GlobalConfig.Connection.SetTroca(numTroca, idDestinatario, comboBoxProgresso.Text,
                dateTimePickerProposta.Text, dateTimePickerEnvio.Text, dateTimePickerRececao.Text, caderneta.Id);
        }

        private bool EntradasValidas()
        {
            return true;
        }

        private void buttonExistentes_Click(object sender, EventArgs e)
        {
            FormFilhoDest = new DestinatarioPickerForm(this);
            this.Hide();
            FormFilhoDest.Show();
        }

        private void buttonExistentes_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible && FormFilhoDest!=null)
            {
                int idDest = FormFilhoDest.GetIdDest();
                DestinatarioModelo destinatario = GlobalConfig.Connection.GetDestinatario(idDest);
                if (destinatario != null)
                {
                    textBoxNome.Text = destinatario.Nome;
                    textBoxIniciais.Text = destinatario.Iniciais;
                    textBoxOrigem.Text = destinatario.Origem;
                    textBoxReputacao.Text = destinatario.Reputacao;

                }
                textBoxMorada.Text = destinatario.Morada;
            }
        }

        private void NovaTrocaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            formPai.Show();
        }
    }
}
