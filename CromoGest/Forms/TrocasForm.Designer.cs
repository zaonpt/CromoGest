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
            this.TrocasToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonTrocas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTrocas)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.DataGridViewTrocas, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(953, 610);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // DataGridViewTrocas
            // 
            this.DataGridViewTrocas.AllowUserToAddRows = false;
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
            this.DataGridViewTrocas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewTrocas.Location = new System.Drawing.Point(3, 43);
            this.DataGridViewTrocas.Name = "DataGridViewTrocas";
            this.DataGridViewTrocas.Size = new System.Drawing.Size(947, 459);
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
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 588);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(953, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(443, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(281, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel2.Controls.Add(this.button3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ButtonTrocas, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBox1, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.button2, 6, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(947, 34);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // ButtonTrocas
            // 
            this.ButtonTrocas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ButtonTrocas.ForeColor = System.Drawing.Color.Black;
            this.ButtonTrocas.Location = new System.Drawing.Point(3, 5);
            this.ButtonTrocas.Name = "ButtonTrocas";
            this.ButtonTrocas.Size = new System.Drawing.Size(104, 23);
            this.ButtonTrocas.TabIndex = 12;
            this.ButtonTrocas.Text = "&Trocas";
            this.ButtonTrocas.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(113, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "&Trocas";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(840, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "&Trocas";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(223, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "&Trocas";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // TrocasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(953, 610);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(860, 468);
            this.Name = "TrocasForm";
            this.Text = "Trocas";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTrocas)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip TrocasToolTip;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView DataGridViewTrocas;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Editar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTroca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Progresso;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataProposta;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEnvio;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataRececao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destinatario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CromosRecebidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CromosEnviados;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ButtonTrocas;
        private System.Windows.Forms.Button button2;
    }
}