namespace CromoGest.Forms
{
    partial class TrocasForm
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
            this.components = new System.ComponentModel.Container();
            this.DataGridViewTrocas = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IdTroca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Progresso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataProposta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEnvio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataRececao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destinatario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CromosRecebidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CromosEnviados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonSair = new System.Windows.Forms.Button();
            this.StatusStripTrocas = new System.Windows.Forms.StatusStrip();
            this.ButtonAlterarSelecao = new System.Windows.Forms.Button();
            this.GroupBoxProgresso = new System.Windows.Forms.GroupBox();
            this.LabelTroca = new System.Windows.Forms.Label();
            this.ComboBoxStatus = new System.Windows.Forms.ComboBox();
            this.ButtonAlterarStatus = new System.Windows.Forms.Button();
            this.ButtonCriar = new System.Windows.Forms.Button();
            this.TrocasToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.LabelTrocaTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTrocas)).BeginInit();
            this.panel1.SuspendLayout();
            this.GroupBoxProgresso.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridViewTrocas
            // 
            this.DataGridViewTrocas.AllowUserToAddRows = false;
            this.DataGridViewTrocas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewTrocas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewTrocas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.IdTroca,
            this.Progresso,
            this.DataProposta,
            this.DataEnvio,
            this.DataRececao,
            this.Destinatario,
            this.CromosRecebidos,
            this.CromosEnviados});
            this.DataGridViewTrocas.Location = new System.Drawing.Point(10, 72);
            this.DataGridViewTrocas.Name = "DataGridViewTrocas";
            this.DataGridViewTrocas.Size = new System.Drawing.Size(941, 210);
            this.DataGridViewTrocas.TabIndex = 1;
            // 
            // Editar
            // 
            this.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Editar.Frozen = true;
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar.Width = 40;
            // 
            // IdTroca
            // 
            this.IdTroca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IdTroca.Frozen = true;
            this.IdTroca.HeaderText = "Nº Troca";
            this.IdTroca.Name = "IdTroca";
            this.IdTroca.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IdTroca.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IdTroca.Width = 70;
            // 
            // Progresso
            // 
            this.Progresso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Progresso.Frozen = true;
            this.Progresso.HeaderText = "Progresso";
            this.Progresso.Name = "Progresso";
            this.Progresso.Width = 60;
            // 
            // DataProposta
            // 
            this.DataProposta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DataProposta.Frozen = true;
            this.DataProposta.HeaderText = "Data Proposta";
            this.DataProposta.Name = "DataProposta";
            // 
            // DataEnvio
            // 
            this.DataEnvio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DataEnvio.Frozen = true;
            this.DataEnvio.HeaderText = "Data Envio";
            this.DataEnvio.Name = "DataEnvio";
            // 
            // DataRececao
            // 
            this.DataRececao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DataRececao.Frozen = true;
            this.DataRececao.HeaderText = "Data Receção";
            this.DataRececao.Name = "DataRececao";
            // 
            // Destinatario
            // 
            this.Destinatario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Destinatario.HeaderText = "Destinatário";
            this.Destinatario.Name = "Destinatario";
            this.Destinatario.Width = 88;
            // 
            // CromosRecebidos
            // 
            this.CromosRecebidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CromosRecebidos.HeaderText = "Cromos Recebidos";
            this.CromosRecebidos.Name = "CromosRecebidos";
            this.CromosRecebidos.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CromosRecebidos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CromosEnviados
            // 
            this.CromosEnviados.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CromosEnviados.HeaderText = "Cromos Enviados";
            this.CromosEnviados.Name = "CromosEnviados";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ButtonSair);
            this.panel1.Controls.Add(this.StatusStripTrocas);
            this.panel1.Controls.Add(this.ButtonAlterarSelecao);
            this.panel1.Controls.Add(this.GroupBoxProgresso);
            this.panel1.Controls.Add(this.ButtonCriar);
            this.panel1.Controls.Add(this.LabelTrocaTitulo);
            this.panel1.Controls.Add(this.DataGridViewTrocas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(961, 429);
            this.panel1.TabIndex = 2;
            // 
            // ButtonSair
            // 
            this.ButtonSair.ForeColor = System.Drawing.Color.Black;
            this.ButtonSair.Location = new System.Drawing.Point(10, 359);
            this.ButtonSair.Name = "ButtonSair";
            this.ButtonSair.Size = new System.Drawing.Size(100, 23);
            this.ButtonSair.TabIndex = 13;
            this.ButtonSair.Text = "&Sair";
            this.TrocasToolTip.SetToolTip(this.ButtonSair, "PLACEHOLDER");
            this.ButtonSair.UseVisualStyleBackColor = true;
            // 
            // StatusStripTrocas
            // 
            this.StatusStripTrocas.Location = new System.Drawing.Point(10, 397);
            this.StatusStripTrocas.Name = "StatusStripTrocas";
            this.StatusStripTrocas.Size = new System.Drawing.Size(941, 22);
            this.StatusStripTrocas.TabIndex = 12;
            this.StatusStripTrocas.Text = "statusStrip1";
            // 
            // ButtonAlterarSelecao
            // 
            this.ButtonAlterarSelecao.ForeColor = System.Drawing.Color.Black;
            this.ButtonAlterarSelecao.Location = new System.Drawing.Point(10, 330);
            this.ButtonAlterarSelecao.Name = "ButtonAlterarSelecao";
            this.ButtonAlterarSelecao.Size = new System.Drawing.Size(100, 23);
            this.ButtonAlterarSelecao.TabIndex = 8;
            this.ButtonAlterarSelecao.Text = "&Alterar Seleção";
            this.TrocasToolTip.SetToolTip(this.ButtonAlterarSelecao, "PLACEHOLDER");
            this.ButtonAlterarSelecao.UseVisualStyleBackColor = true;
            // 
            // GroupBoxProgresso
            // 
            this.GroupBoxProgresso.Controls.Add(this.LabelTroca);
            this.GroupBoxProgresso.Controls.Add(this.ComboBoxStatus);
            this.GroupBoxProgresso.Controls.Add(this.ButtonAlterarStatus);
            this.GroupBoxProgresso.Location = new System.Drawing.Point(313, 320);
            this.GroupBoxProgresso.Name = "GroupBoxProgresso";
            this.GroupBoxProgresso.Size = new System.Drawing.Size(521, 66);
            this.GroupBoxProgresso.TabIndex = 11;
            this.GroupBoxProgresso.TabStop = false;
            this.GroupBoxProgresso.Text = "Alterar Progresso";
            // 
            // LabelTroca
            // 
            this.LabelTroca.AutoSize = true;
            this.LabelTroca.Location = new System.Drawing.Point(16, 30);
            this.LabelTroca.Name = "LabelTroca";
            this.LabelTroca.Size = new System.Drawing.Size(148, 13);
            this.LabelTroca.TabIndex = 12;
            this.LabelTroca.Text = "Novo Status para o progresso";
            // 
            // ComboBoxStatus
            // 
            this.ComboBoxStatus.FormattingEnabled = true;
            this.ComboBoxStatus.Location = new System.Drawing.Point(177, 27);
            this.ComboBoxStatus.Name = "ComboBoxStatus";
            this.ComboBoxStatus.Size = new System.Drawing.Size(183, 21);
            this.ComboBoxStatus.TabIndex = 11;
            // 
            // ButtonAlterarStatus
            // 
            this.ButtonAlterarStatus.ForeColor = System.Drawing.Color.Black;
            this.ButtonAlterarStatus.Location = new System.Drawing.Point(394, 25);
            this.ButtonAlterarStatus.Name = "ButtonAlterarStatus";
            this.ButtonAlterarStatus.Size = new System.Drawing.Size(100, 23);
            this.ButtonAlterarStatus.TabIndex = 10;
            this.ButtonAlterarStatus.Text = "Alterar";
            this.ButtonAlterarStatus.UseVisualStyleBackColor = true;
            // 
            // ButtonCriar
            // 
            this.ButtonCriar.ForeColor = System.Drawing.Color.Black;
            this.ButtonCriar.Location = new System.Drawing.Point(10, 301);
            this.ButtonCriar.Name = "ButtonCriar";
            this.ButtonCriar.Size = new System.Drawing.Size(100, 23);
            this.ButtonCriar.TabIndex = 9;
            this.ButtonCriar.Text = "&Nova";
            this.TrocasToolTip.SetToolTip(this.ButtonCriar, "Criar um registo novo de Troca");
            this.ButtonCriar.UseVisualStyleBackColor = true;
            // 
            // LabelTrocaTitulo
            // 
            this.LabelTrocaTitulo.AutoSize = true;
            this.LabelTrocaTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTrocaTitulo.ForeColor = System.Drawing.Color.White;
            this.LabelTrocaTitulo.Location = new System.Drawing.Point(418, 24);
            this.LabelTrocaTitulo.Name = "LabelTrocaTitulo";
            this.LabelTrocaTitulo.Size = new System.Drawing.Size(68, 24);
            this.LabelTrocaTitulo.TabIndex = 7;
            this.LabelTrocaTitulo.Text = "Trocas";
            // 
            // Trocas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(961, 429);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximumSize = new System.Drawing.Size(2000, 468);
            this.MinimumSize = new System.Drawing.Size(860, 468);
            this.Name = "Trocas";
            this.Text = "Trocas";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTrocas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GroupBoxProgresso.ResumeLayout(false);
            this.GroupBoxProgresso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewTrocas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonCriar;
        private System.Windows.Forms.Button ButtonAlterarSelecao;
        private System.Windows.Forms.StatusStrip StatusStripTrocas;
        private System.Windows.Forms.GroupBox GroupBoxProgresso;
        private System.Windows.Forms.Label LabelTroca;
        private System.Windows.Forms.ComboBox ComboBoxStatus;
        private System.Windows.Forms.Button ButtonAlterarStatus;
        private System.Windows.Forms.ToolTip TrocasToolTip;
        private System.Windows.Forms.Button ButtonSair;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Editar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTroca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Progresso;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataProposta;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEnvio;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataRececao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destinatario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CromosRecebidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CromosEnviados;
        private System.Windows.Forms.Label LabelTrocaTitulo;
    }
}