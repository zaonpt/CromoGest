using System.Drawing;

namespace CromoGest.Forms
{
    partial class EditarTrocaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxDestinatario = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxIniciais = new System.Windows.Forms.TextBox();
            this.textBoxOrigem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxReputacao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMorada = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonExistentes = new System.Windows.Forms.Button();
            this.LabelEditarTrocaTitulo = new System.Windows.Forms.Label();
            this.cadernetaLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxCromosRecebidos = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxProgresso = new System.Windows.Forms.ComboBox();
            this.textBoxCromosEnviados = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBoxDatas = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePickerRececao = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnvio = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerProposta = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxDestinatario.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBoxDatas.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBoxDestinatario, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LabelEditarTrocaTitulo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cadernetaLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxDatas, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(484, 534);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBoxDestinatario
            // 
            this.groupBoxDestinatario.Controls.Add(this.tableLayoutPanel3);
            this.groupBoxDestinatario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDestinatario.ForeColor = System.Drawing.Color.White;
            this.groupBoxDestinatario.Location = new System.Drawing.Point(3, 74);
            this.groupBoxDestinatario.Name = "groupBoxDestinatario";
            this.groupBoxDestinatario.Size = new System.Drawing.Size(478, 179);
            this.groupBoxDestinatario.TabIndex = 11;
            this.groupBoxDestinatario.TabStop = false;
            this.groupBoxDestinatario.Text = "Destinatário";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBoxNome, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBoxIniciais, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBoxOrigem, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.textBoxReputacao, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.textBoxMorada, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.buttonExistentes, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(472, 160);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNome.Location = new System.Drawing.Point(153, 5);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(216, 20);
            this.textBoxNome.TabIndex = 1;
            // 
            // textBoxIniciais
            // 
            this.textBoxIniciais.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.textBoxIniciais, 2);
            this.textBoxIniciais.Location = new System.Drawing.Point(153, 35);
            this.textBoxIniciais.Name = "textBoxIniciais";
            this.textBoxIniciais.Size = new System.Drawing.Size(316, 20);
            this.textBoxIniciais.TabIndex = 3;
            // 
            // textBoxOrigem
            // 
            this.textBoxOrigem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.textBoxOrigem, 2);
            this.textBoxOrigem.Location = new System.Drawing.Point(153, 65);
            this.textBoxOrigem.Name = "textBoxOrigem";
            this.textBoxOrigem.Size = new System.Drawing.Size(316, 20);
            this.textBoxOrigem.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Iniciais";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Origem";
            // 
            // textBoxReputacao
            // 
            this.textBoxReputacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.textBoxReputacao, 2);
            this.textBoxReputacao.Location = new System.Drawing.Point(153, 95);
            this.textBoxReputacao.Name = "textBoxReputacao";
            this.textBoxReputacao.Size = new System.Drawing.Size(316, 20);
            this.textBoxReputacao.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Reputação";
            // 
            // textBoxMorada
            // 
            this.textBoxMorada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.textBoxMorada, 2);
            this.textBoxMorada.Location = new System.Drawing.Point(153, 123);
            this.textBoxMorada.Multiline = true;
            this.textBoxMorada.Name = "textBoxMorada";
            this.textBoxMorada.Size = new System.Drawing.Size(316, 34);
            this.textBoxMorada.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Morada";
            // 
            // buttonExistentes
            // 
            this.buttonExistentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExistentes.ForeColor = System.Drawing.Color.Black;
            this.buttonExistentes.Location = new System.Drawing.Point(375, 3);
            this.buttonExistentes.Name = "buttonExistentes";
            this.buttonExistentes.Size = new System.Drawing.Size(94, 24);
            this.buttonExistentes.TabIndex = 10;
            this.buttonExistentes.Text = "Existentes";
            this.buttonExistentes.UseVisualStyleBackColor = true;
            this.buttonExistentes.VisibleChanged += new System.EventHandler(this.buttonExistentes_VisibleChanged);
            this.buttonExistentes.Click += new System.EventHandler(this.buttonExistentes_Click);
            // 
            // LabelEditarTrocaTitulo
            // 
            this.LabelEditarTrocaTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelEditarTrocaTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEditarTrocaTitulo.ForeColor = System.Drawing.Color.White;
            this.LabelEditarTrocaTitulo.Location = new System.Drawing.Point(3, 0);
            this.LabelEditarTrocaTitulo.Name = "LabelEditarTrocaTitulo";
            this.LabelEditarTrocaTitulo.Size = new System.Drawing.Size(478, 40);
            this.LabelEditarTrocaTitulo.TabIndex = 7;
            this.LabelEditarTrocaTitulo.Text = "Editar Troca";
            this.LabelEditarTrocaTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cadernetaLabel
            // 
            this.cadernetaLabel.AutoSize = true;
            this.cadernetaLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cadernetaLabel.Location = new System.Drawing.Point(3, 40);
            this.cadernetaLabel.Name = "cadernetaLabel";
            this.cadernetaLabel.Size = new System.Drawing.Size(478, 31);
            this.cadernetaLabel.TabIndex = 9;
            this.cadernetaLabel.Text = "Caderneta: XXXXX";
            this.cadernetaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 512);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(484, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxCromosRecebidos, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxProgresso, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxCromosEnviados, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 259);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(478, 92);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(95, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Progresso";
            // 
            // textBoxCromosRecebidos
            // 
            this.textBoxCromosRecebidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCromosRecebidos.Location = new System.Drawing.Point(155, 35);
            this.textBoxCromosRecebidos.Name = "textBoxCromosRecebidos";
            this.textBoxCromosRecebidos.Size = new System.Drawing.Size(320, 20);
            this.textBoxCromosRecebidos.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Cromos Recebidos";
            // 
            // comboBoxProgresso
            // 
            this.comboBoxProgresso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxProgresso.FormattingEnabled = true;
            this.comboBoxProgresso.Items.AddRange(new object[] {
            "Propor",
            "Enviar",
            "Concluir"});
            this.comboBoxProgresso.Location = new System.Drawing.Point(155, 4);
            this.comboBoxProgresso.Name = "comboBoxProgresso";
            this.comboBoxProgresso.Size = new System.Drawing.Size(320, 21);
            this.comboBoxProgresso.TabIndex = 6;
            this.comboBoxProgresso.Text = "Propor";
            // 
            // textBoxCromosEnviados
            // 
            this.textBoxCromosEnviados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCromosEnviados.Location = new System.Drawing.Point(155, 65);
            this.textBoxCromosEnviados.Name = "textBoxCromosEnviados";
            this.textBoxCromosEnviados.Size = new System.Drawing.Size(320, 20);
            this.textBoxCromosEnviados.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(60, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Cromos Enviados";
            // 
            // groupBoxDatas
            // 
            this.groupBoxDatas.Controls.Add(this.tableLayoutPanel4);
            this.groupBoxDatas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDatas.ForeColor = System.Drawing.Color.White;
            this.groupBoxDatas.Location = new System.Drawing.Point(3, 357);
            this.groupBoxDatas.Name = "groupBoxDatas";
            this.groupBoxDatas.Size = new System.Drawing.Size(478, 109);
            this.groupBoxDatas.TabIndex = 14;
            this.groupBoxDatas.TabStop = false;
            this.groupBoxDatas.Text = "Datas";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.dateTimePickerRececao, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.dateTimePickerEnvio, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.dateTimePickerProposta, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(472, 90);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // dateTimePickerRececao
            // 
            this.dateTimePickerRececao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerRececao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerRececao.Location = new System.Drawing.Point(152, 65);
            this.dateTimePickerRececao.Name = "dateTimePickerRececao";
            this.dateTimePickerRececao.Size = new System.Drawing.Size(317, 20);
            this.dateTimePickerRececao.TabIndex = 9;
            // 
            // dateTimePickerEnvio
            // 
            this.dateTimePickerEnvio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerEnvio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEnvio.Location = new System.Drawing.Point(152, 35);
            this.dateTimePickerEnvio.Name = "dateTimePickerEnvio";
            this.dateTimePickerEnvio.Size = new System.Drawing.Size(317, 20);
            this.dateTimePickerEnvio.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(95, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Receção";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Proposta";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Envio";
            // 
            // dateTimePickerProposta
            // 
            this.dateTimePickerProposta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerProposta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerProposta.Location = new System.Drawing.Point(152, 5);
            this.dateTimePickerProposta.Name = "dateTimePickerProposta";
            this.dateTimePickerProposta.Size = new System.Drawing.Size(317, 20);
            this.dateTimePickerProposta.TabIndex = 7;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.buttonSair, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.buttonLimpar, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.buttonSalvar, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 472);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(478, 29);
            this.tableLayoutPanel5.TabIndex = 15;
            // 
            // buttonSair
            // 
            this.buttonSair.ForeColor = System.Drawing.Color.Black;
            this.buttonSair.Location = new System.Drawing.Point(223, 3);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(104, 23);
            this.buttonSair.TabIndex = 2;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.ForeColor = System.Drawing.Color.Black;
            this.buttonLimpar.Location = new System.Drawing.Point(113, 3);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(104, 23);
            this.buttonLimpar.TabIndex = 1;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.ForeColor = System.Drawing.Color.Black;
            this.buttonSalvar.Location = new System.Drawing.Point(3, 3);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(104, 23);
            this.buttonSalvar.TabIndex = 0;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // EditarTrocaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(484, 534);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximumSize = new System.Drawing.Size(1000, 573);
            this.MinimumSize = new System.Drawing.Size(500, 573);
            this.Name = "EditarTrocaForm";
            this.Text = "NovaTrocaForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NovaTrocaForm_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBoxDestinatario.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBoxDatas.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LabelEditarTrocaTitulo;
        private System.Windows.Forms.GroupBox groupBoxDestinatario;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxIniciais;
        private System.Windows.Forms.TextBox textBoxOrigem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxReputacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMorada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label cadernetaLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBoxDatas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DateTimePicker dateTimePickerRececao;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnvio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerProposta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxCromosRecebidos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxProgresso;
        private System.Windows.Forms.TextBox textBoxCromosEnviados;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonExistentes;
    }
}