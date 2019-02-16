namespace CromoGest
{
    partial class Entradas
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
            this.Cromos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.IntroduzirButton = new System.Windows.Forms.Button();
            this.VerificarButton = new System.Windows.Forms.Button();
            this.SairButton = new System.Windows.Forms.Button();
            this.ResultadosGroupBox = new System.Windows.Forms.GroupBox();
            this.RepetidosLabel = new System.Windows.Forms.Label();
            this.NovosLabel = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.EntradasTituloLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.ResultadosGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cromos});
            this.dataGridView1.Location = new System.Drawing.Point(71, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(179, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Cromos
            // 
            this.Cromos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cromos.HeaderText = "Cromos";
            this.Cromos.Name = "Cromos";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 449);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(470, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(315, 17);
            this.toolStripStatusLabel1.Text = "Escrever os cromos um por linha, ou separados por virgula";
            // 
            // IntroduzirButton
            // 
            this.IntroduzirButton.Location = new System.Drawing.Point(329, 52);
            this.IntroduzirButton.Name = "IntroduzirButton";
            this.IntroduzirButton.Size = new System.Drawing.Size(75, 23);
            this.IntroduzirButton.TabIndex = 2;
            this.IntroduzirButton.Text = "Introduzir";
            this.IntroduzirButton.UseVisualStyleBackColor = true;
            // 
            // VerificarButton
            // 
            this.VerificarButton.Location = new System.Drawing.Point(329, 115);
            this.VerificarButton.Name = "VerificarButton";
            this.VerificarButton.Size = new System.Drawing.Size(75, 23);
            this.VerificarButton.TabIndex = 3;
            this.VerificarButton.Text = "Verificar";
            this.VerificarButton.UseVisualStyleBackColor = true;
            // 
            // SairButton
            // 
            this.SairButton.Location = new System.Drawing.Point(329, 179);
            this.SairButton.Name = "SairButton";
            this.SairButton.Size = new System.Drawing.Size(75, 23);
            this.SairButton.TabIndex = 4;
            this.SairButton.Text = "Sair";
            this.SairButton.UseVisualStyleBackColor = true;
            // 
            // ResultadosGroupBox
            // 
            this.ResultadosGroupBox.Controls.Add(this.RepetidosLabel);
            this.ResultadosGroupBox.Controls.Add(this.NovosLabel);
            this.ResultadosGroupBox.Controls.Add(this.listBox2);
            this.ResultadosGroupBox.Controls.Add(this.listBox1);
            this.ResultadosGroupBox.Location = new System.Drawing.Point(12, 212);
            this.ResultadosGroupBox.Name = "ResultadosGroupBox";
            this.ResultadosGroupBox.Size = new System.Drawing.Size(446, 234);
            this.ResultadosGroupBox.TabIndex = 5;
            this.ResultadosGroupBox.TabStop = false;
            this.ResultadosGroupBox.Text = "Resultados";
            // 
            // RepetidosLabel
            // 
            this.RepetidosLabel.AutoSize = true;
            this.RepetidosLabel.Location = new System.Drawing.Point(229, 31);
            this.RepetidosLabel.Name = "RepetidosLabel";
            this.RepetidosLabel.Size = new System.Drawing.Size(93, 13);
            this.RepetidosLabel.TabIndex = 3;
            this.RepetidosLabel.Text = "Cromos Repetidos";
            // 
            // NovosLabel
            // 
            this.NovosLabel.AutoSize = true;
            this.NovosLabel.Location = new System.Drawing.Point(6, 31);
            this.NovosLabel.Name = "NovosLabel";
            this.NovosLabel.Size = new System.Drawing.Size(74, 13);
            this.NovosLabel.TabIndex = 2;
            this.NovosLabel.Text = "Cromos novos";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(232, 47);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(208, 173);
            this.listBox2.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(208, 173);
            this.listBox1.TabIndex = 0;
            // 
            // EntradasTituloLabel
            // 
            this.EntradasTituloLabel.AutoSize = true;
            this.EntradasTituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntradasTituloLabel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.EntradasTituloLabel.Location = new System.Drawing.Point(207, 9);
            this.EntradasTituloLabel.Name = "EntradasTituloLabel";
            this.EntradasTituloLabel.Size = new System.Drawing.Size(84, 24);
            this.EntradasTituloLabel.TabIndex = 6;
            this.EntradasTituloLabel.Text = "Entradas";
            this.EntradasTituloLabel.Click += new System.EventHandler(this.TrocasTituloLabel_Click);
            // 
            // Entradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 471);
            this.Controls.Add(this.EntradasTituloLabel);
            this.Controls.Add(this.ResultadosGroupBox);
            this.Controls.Add(this.SairButton);
            this.Controls.Add(this.VerificarButton);
            this.Controls.Add(this.IntroduzirButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Entradas";
            this.Text = "Entradas";
            this.Load += new System.EventHandler(this.Entradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResultadosGroupBox.ResumeLayout(false);
            this.ResultadosGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cromos;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button IntroduzirButton;
        private System.Windows.Forms.Button VerificarButton;
        private System.Windows.Forms.Button SairButton;
        private System.Windows.Forms.GroupBox ResultadosGroupBox;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label RepetidosLabel;
        private System.Windows.Forms.Label NovosLabel;
        private System.Windows.Forms.Label EntradasTituloLabel;
    }
}