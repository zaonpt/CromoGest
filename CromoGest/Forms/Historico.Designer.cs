namespace CromoGest.Forms
{
    partial class Historico
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
            this.DataGridViewHistorico = new System.Windows.Forms.DataGridView();
            this.IdTroca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Progresso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataProposta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEnvio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataRececao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destinatario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CromosRecebidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CromosEnviados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelHistoricoTitulo = new System.Windows.Forms.Label();
            this.ButtonSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewHistorico
            // 
            this.DataGridViewHistorico.AllowUserToAddRows = false;
            this.DataGridViewHistorico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewHistorico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTroca,
            this.Progresso,
            this.DataProposta,
            this.DataEnvio,
            this.DataRececao,
            this.Destinatario,
            this.CromosRecebidos,
            this.CromosEnviados});
            this.DataGridViewHistorico.Location = new System.Drawing.Point(-1, 91);
            this.DataGridViewHistorico.Name = "DataGridViewHistorico";
            this.DataGridViewHistorico.Size = new System.Drawing.Size(952, 210);
            this.DataGridViewHistorico.TabIndex = 2;
            // 
            // IdTroca
            // 
            this.IdTroca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.IdTroca.Frozen = true;
            this.IdTroca.HeaderText = "Nº Troca";
            this.IdTroca.Name = "IdTroca";
            this.IdTroca.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IdTroca.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IdTroca.Width = 50;
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
            // LabelHistoricoTitulo
            // 
            this.LabelHistoricoTitulo.AutoSize = true;
            this.LabelHistoricoTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHistoricoTitulo.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.LabelHistoricoTitulo.Location = new System.Drawing.Point(354, 24);
            this.LabelHistoricoTitulo.Name = "LabelHistoricoTitulo";
            this.LabelHistoricoTitulo.Size = new System.Drawing.Size(83, 24);
            this.LabelHistoricoTitulo.TabIndex = 8;
            this.LabelHistoricoTitulo.Text = "Historico";
            // 
            // ButtonSair
            // 
            this.ButtonSair.Location = new System.Drawing.Point(12, 395);
            this.ButtonSair.Name = "ButtonSair";
            this.ButtonSair.Size = new System.Drawing.Size(100, 23);
            this.ButtonSair.TabIndex = 14;
            this.ButtonSair.Text = "&Sair";
            this.ButtonSair.UseVisualStyleBackColor = true;
            // 
            // Historico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 450);
            this.Controls.Add(this.ButtonSair);
            this.Controls.Add(this.LabelHistoricoTitulo);
            this.Controls.Add(this.DataGridViewHistorico);
            this.MaximumSize = new System.Drawing.Size(1500, 489);
            this.MinimumSize = new System.Drawing.Size(887, 489);
            this.Name = "Historico";
            this.Text = "Historico";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewHistorico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewHistorico;
        private System.Windows.Forms.Label LabelHistoricoTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTroca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Progresso;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataProposta;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEnvio;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataRececao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destinatario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CromosRecebidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CromosEnviados;
        private System.Windows.Forms.Button ButtonSair;
    }
}