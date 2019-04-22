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
    public partial class EditarTrocaForm : Form
    {
        private TrocasForm formPai;
        private CadernetaModelo caderneta;
        private DestinatarioPickerForm FormFilhoDest;
        private readonly char charSeparador=CromoGestLibrary.GlobalConfig.Connection.GetConfig(ConfigCategory.CharSeparador.Value)[0];
        private TrocaModelo trocaEditada;

        public EditarTrocaForm()
        {
            InitializeComponent();
        }

        public EditarTrocaForm(TrocasForm formArgPai, CadernetaModelo cadernetaArg, TrocaModelo troca)
        {
            InitializeComponent();
            if (cadernetaArg == null)
            {
                this.Hide();
                formArgPai.Show();
                this.Close();
            }
            trocaEditada = troca;
            formPai = formArgPai;
            caderneta = cadernetaArg;
            cadernetaLabel.Text = $"Caderneta: {caderneta.Nome}";
            textBoxNome.DataBindings.Add("Text",trocaEditada, "Dest_Nome");
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

            if (!EntradasValidas()) return;

            int numTroca = CromoGestLibrary.GlobalConfig.Connection.GetNextTrocaNum(caderneta.Id) + 1;

            idDestinatario = CromoGestLibrary.GlobalConfig.Connection.SetDestinatario(
                    textBoxNome.Text, textBoxIniciais.Text, textBoxOrigem.Text, textBoxReputacao.Text, textBoxMorada.Text);

            int idTroca = CromoGestLibrary.GlobalConfig.Connection.SetTroca(numTroca, idDestinatario, comboBoxProgresso.Text,
                dateTimePickerProposta.Text, dateTimePickerEnvio.Text, dateTimePickerRececao.Text, caderneta.Id);

            //RECEBIDOS
            if (textBoxCromosRecebidos.Text.Length > 0)
                foreach (string numCromo in textBoxCromosRecebidos.Text.ToString().Split(charSeparador))
                {
                    isRecebido = 1;
                    int idCromo = CromoGestLibrary.GlobalConfig.Connection.GetCromoId(numCromo, caderneta.Id);
                    int idCromoDaTroca = CromoGestLibrary.GlobalConfig.Connection.CriaCromoDaTroca(idCromo, idTroca, isRecebido);
                    CromoGestLibrary.GlobalConfig.Connection.IncCromoQuatidade(numCromo, caderneta.Id);
                }
            //ENVIADOS
            if (textBoxCromosEnviados.Text.Length > 0)
                foreach (string numCromo in textBoxCromosEnviados.Text.ToString().Split(charSeparador))
                {
                    isRecebido = 0;
                    int idCromo = CromoGestLibrary.GlobalConfig.Connection.GetCromoId(numCromo, caderneta.Id);
                    int idCromoDaTroca = CromoGestLibrary.GlobalConfig.Connection.CriaCromoDaTroca(idCromo, idTroca, isRecebido);
                    CromoGestLibrary.GlobalConfig.Connection.DecCromoQuatidade(numCromo, caderneta.Id);
                }
            this.Close();
        }

        private bool EntradasValidas()
        {
            int quantidade;

            if (textBoxCromosRecebidos.Text.Length > 0)
                foreach (string numCromo in textBoxCromosRecebidos.Text.ToString().Split(charSeparador))
                {
                    //verificar se o cromo existe
                    try { CromoGestLibrary.GlobalConfig.Connection.GetCromoId(numCromo, caderneta.Id); }
                    catch {
                        MessageBox.Show($"Cromo {numCromo} invalido");
                        return false;
                    }
                    quantidade = CromoGestLibrary.GlobalConfig.Connection.GetCromoQuatidade(numCromo, caderneta.Id);
                    if (quantidade > 0)
                    {
                        DialogResult dr = MessageBox.Show($"Já tem o Cromo {numCromo}. Deseja continuar?","ALERTA",MessageBoxButtons.YesNo);
                        if (dr == DialogResult.No) return false;
                    }
                }

            if (textBoxCromosEnviados.Text.Length > 0)
                foreach (string numCromo in textBoxCromosEnviados.Text.ToString().Split(charSeparador))
                {
                    //verificar se o cromo existe
                    try { CromoGestLibrary.GlobalConfig.Connection.GetCromoId(numCromo, caderneta.Id); }
                    catch {
                        MessageBox.Show($"Cromo {numCromo} invalido");
                        return false;
                    }

                    quantidade = CromoGestLibrary.GlobalConfig.Connection.GetCromoQuatidade(numCromo, caderneta.Id);
                    if (quantidade < 2)
                    {
                        MessageBox.Show($"Quantidade insuficiente para enviar o Cromo {numCromo}.");
                        return false;
                    }
                }
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
                DestinatarioModelo destinatario = CromoGestLibrary.GlobalConfig.Connection.GetDestinatario(idDest);
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
