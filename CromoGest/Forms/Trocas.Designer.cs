namespace CromoGest.Forms
{
    partial class Trocas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.TrocasStatusStrip = new System.Windows.Forms.StatusStrip();
            this.AlterarButton = new System.Windows.Forms.Button();
            this.ProgressoGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CriarButton = new System.Windows.Forms.Button();
            this.TrocaTituloLabel = new System.Windows.Forms.Label();
            this.TrocasToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SairButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.ProgressoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.IdTroca,
            this.Progresso,
            this.DataProposta,
            this.DataEnvio,
            this.DataRececao,
            this.Destinatario,
            this.CromosRecebidos,
            this.CromosEnviados});
            this.dataGridView1.Location = new System.Drawing.Point(10, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(828, 210);
            this.dataGridView1.TabIndex = 1;
            // 
            // Editar
            // 
            this.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Editar.Frozen = true;
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar.Width = 40;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.SairButton);
            this.panel1.Controls.Add(this.TrocasStatusStrip);
            this.panel1.Controls.Add(this.AlterarButton);
            this.panel1.Controls.Add(this.ProgressoGroupBox);
            this.panel1.Controls.Add(this.CriarButton);
            this.panel1.Controls.Add(this.TrocaTituloLabel);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(848, 429);
            this.panel1.TabIndex = 2;
            // 
            // TrocasStatusStrip
            // 
            this.TrocasStatusStrip.Location = new System.Drawing.Point(10, 397);
            this.TrocasStatusStrip.Name = "TrocasStatusStrip";
            this.TrocasStatusStrip.Size = new System.Drawing.Size(828, 22);
            this.TrocasStatusStrip.TabIndex = 12;
            this.TrocasStatusStrip.Text = "statusStrip1";
            // 
            // AlterarButton
            // 
            this.AlterarButton.Location = new System.Drawing.Point(10, 330);
            this.AlterarButton.Name = "AlterarButton";
            this.AlterarButton.Size = new System.Drawing.Size(100, 23);
            this.AlterarButton.TabIndex = 8;
            this.AlterarButton.Text = "&Alterar Seleção";
            this.TrocasToolTip.SetToolTip(this.AlterarButton, "PLACEHOLDER");
            this.AlterarButton.UseVisualStyleBackColor = true;
            // 
            // ProgressoGroupBox
            // 
            this.ProgressoGroupBox.Controls.Add(this.label1);
            this.ProgressoGroupBox.Controls.Add(this.comboBox1);
            this.ProgressoGroupBox.Controls.Add(this.button1);
            this.ProgressoGroupBox.Location = new System.Drawing.Point(313, 320);
            this.ProgressoGroupBox.Name = "ProgressoGroupBox";
            this.ProgressoGroupBox.Size = new System.Drawing.Size(521, 66);
            this.ProgressoGroupBox.TabIndex = 11;
            this.ProgressoGroupBox.TabStop = false;
            this.ProgressoGroupBox.Text = "Alterar Progresso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Novo Status para o progresso";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(177, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(183, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Alterar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CriarButton
            // 
            this.CriarButton.Location = new System.Drawing.Point(10, 301);
            this.CriarButton.Name = "CriarButton";
            this.CriarButton.Size = new System.Drawing.Size(100, 23);
            this.CriarButton.TabIndex = 9;
            this.CriarButton.Text = "&Nova";
            this.TrocasToolTip.SetToolTip(this.CriarButton, "Criar um registo novo de Troca");
            this.CriarButton.UseVisualStyleBackColor = true;
            // 
            // TrocaTituloLabel
            // 
            this.TrocaTituloLabel.AutoSize = true;
            this.TrocaTituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrocaTituloLabel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.TrocaTituloLabel.Location = new System.Drawing.Point(418, 34);
            this.TrocaTituloLabel.Name = "TrocaTituloLabel";
            this.TrocaTituloLabel.Size = new System.Drawing.Size(59, 24);
            this.TrocaTituloLabel.TabIndex = 7;
            this.TrocaTituloLabel.Text = "Troca";
            // 
            // SairButton
            // 
            this.SairButton.Location = new System.Drawing.Point(10, 359);
            this.SairButton.Name = "SairButton";
            this.SairButton.Size = new System.Drawing.Size(100, 23);
            this.SairButton.TabIndex = 13;
            this.SairButton.Text = "&Sair";
            this.TrocasToolTip.SetToolTip(this.SairButton, "PLACEHOLDER");
            this.SairButton.UseVisualStyleBackColor = true;
            // 
            // Trocas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 429);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(2000, 468);
            this.MinimumSize = new System.Drawing.Size(860, 468);
            this.Name = "Trocas";
            this.Text = "Trocas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ProgressoGroupBox.ResumeLayout(false);
            this.ProgressoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TrocaTituloLabel;
        private System.Windows.Forms.Button CriarButton;
        private System.Windows.Forms.Button AlterarButton;
        private System.Windows.Forms.StatusStrip TrocasStatusStrip;
        private System.Windows.Forms.GroupBox ProgressoGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Editar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTroca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Progresso;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataProposta;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEnvio;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataRececao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destinatario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CromosRecebidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CromosEnviados;
        private System.Windows.Forms.ToolTip TrocasToolTip;
        private System.Windows.Forms.Button SairButton;
    }
}