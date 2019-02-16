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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.HistoricoTituloLabel = new System.Windows.Forms.Label();
            this.SairButton = new System.Windows.Forms.Button();
            this.IdTroca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Progresso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataProposta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEnvio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataRececao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destinatario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CromosRecebidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CromosEnviados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTroca,
            this.Progresso,
            this.DataProposta,
            this.DataEnvio,
            this.DataRececao,
            this.Destinatario,
            this.CromosRecebidos,
            this.CromosEnviados});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(952, 210);
            this.dataGridView1.TabIndex = 2;
            // 
            // HistoricoTituloLabel
            // 
            this.HistoricoTituloLabel.AutoSize = true;
            this.HistoricoTituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoricoTituloLabel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.HistoricoTituloLabel.Location = new System.Drawing.Point(354, 24);
            this.HistoricoTituloLabel.Name = "HistoricoTituloLabel";
            this.HistoricoTituloLabel.Size = new System.Drawing.Size(83, 24);
            this.HistoricoTituloLabel.TabIndex = 8;
            this.HistoricoTituloLabel.Text = "Historico";
            // 
            // SairButton
            // 
            this.SairButton.Location = new System.Drawing.Point(12, 395);
            this.SairButton.Name = "SairButton";
            this.SairButton.Size = new System.Drawing.Size(100, 23);
            this.SairButton.TabIndex = 14;
            this.SairButton.Text = "&Sair";
            this.SairButton.UseVisualStyleBackColor = true;
            // 
            // IdTroca
            // 
            this.IdTroca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.IdTroca.Frozen = true;
            this.IdTroca.HeaderText = "Nº Troca";
            this.IdTroca.Name = "IdTroca";
            this.IdTroca.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IdTroca.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IdTroca.Width = 56;
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
            // Historico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 450);
            this.Controls.Add(this.SairButton);
            this.Controls.Add(this.HistoricoTituloLabel);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(1500, 489);
            this.MinimumSize = new System.Drawing.Size(887, 489);
            this.Name = "Historico";
            this.Text = "Historico";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label HistoricoTituloLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTroca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Progresso;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataProposta;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEnvio;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataRececao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destinatario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CromosRecebidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CromosEnviados;
        private System.Windows.Forms.Button SairButton;
    }
}