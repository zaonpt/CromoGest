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
        private char charSeparador;

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

            charSeparador = GlobalConfig.Connection.GetConfig(ConfigCategory.CharSeparador.Value)[0];

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
            int idDestinatario;
            int isRecebido;

            int numTroca = GlobalConfig.Connection.GetNextTrocaNum(caderneta.Id) + 1;

            //if (!DestinararioVazio())
                idDestinatario = GlobalConfig.Connection.SetDestinatario(
                    textBoxNome.Text, textBoxIniciais.Text, textBoxOrigem.Text, textBoxReputacao.Text, textBoxMorada.Text);
            //else idDestinatario = 0;

            int idTroca = GlobalConfig.Connection.SetTroca(numTroca, idDestinatario, comboBoxProgresso.Text,
                dateTimePickerProposta.Text, dateTimePickerEnvio.Text, dateTimePickerRececao.Text, caderneta.Id);

            if (!EntradasValidas(idTroca))
            {
                return;
            }

            //RECEBIDOS
            if (textBoxCromosRecebidos.Text.Length > 0)
                foreach (string numCromo in textBoxCromosRecebidos.Text.ToString().Split(charSeparador))
                {
                    isRecebido = 1;
                    int idCromo = GlobalConfig.Connection.GetCromoId(numCromo, caderneta.Id);
                    int idCromoDaTroca = GlobalConfig.Connection.CriaCromoDaTroca(idCromo, idTroca, isRecebido);
                    GlobalConfig.Connection.IncCromoQuatidade(numCromo, caderneta.Id);
                }
            //ENVIADOS
            if (textBoxCromosEnviados.Text.Length > 0)
                foreach (string numCromo in textBoxCromosEnviados.Text.ToString().Split(charSeparador))
                {
                    isRecebido = 0;
                    int idCromo = GlobalConfig.Connection.GetCromoId(numCromo, caderneta.Id);
                    int idCromoDaTroca = GlobalConfig.Connection.CriaCromoDaTroca(idCromo, idTroca, isRecebido);
                    GlobalConfig.Connection.DecCromoQuatidade(numCromo, caderneta.Id);
                }
            this.Close();
        }

        private bool EntradasValidas(int idTroca)
        {


            return true;
        }

        private bool DestinararioVazio()
        {
            return
                textBoxIniciais.Text.Length > 0 &&
                textBoxOrigem.Text.Length > 0 &&
                textBoxReputacao.Text.Length > 0 &&
                textBoxMorada.Text.Length > 0;
        }


        private void buttonExistentes_Click(object sender, EventArgs e)
        {
            FormFilhoDest = new DestinatarioPickerForm(this);
            this.Hide();
            FormFilhoDest.Show();
        }

        private void buttonExistentes_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible && FormFilhoDest != null && FormFilhoDest.GetIdDest() != -1)
            {
                int idDest = FormFilhoDest.GetIdDest();
                DestinatarioModelo destinatario = GlobalConfig.Connection.GetDestinatario(idDest);
                if (destinatario != null)
                {
                    textBoxNome.Text = destinatario.Nome;
                    textBoxIniciais.Text = destinatario.Iniciais;
                    textBoxOrigem.Text = destinatario.Origem;
                    textBoxReputacao.Text = destinatario.Reputação;
                    textBoxMorada.Text = destinatario.Morada;
                }
            }
        }

        private void NovaTrocaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            formPai.Show();
        }
    }
}
