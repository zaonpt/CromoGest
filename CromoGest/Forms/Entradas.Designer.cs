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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewCromos = new System.Windows.Forms.DataGridView();
            this.Cromos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ButtonIntroduzir = new System.Windows.Forms.Button();
            this.ButtonVerificar = new System.Windows.Forms.Button();
            this.ButtonSair = new System.Windows.Forms.Button();
            this.GroupBoxResultados = new System.Windows.Forms.GroupBox();
            this.LabelRepetidos = new System.Windows.Forms.Label();
            this.LabelNovos = new System.Windows.Forms.Label();
            this.ListBoxRepetidos = new System.Windows.Forms.ListBox();
            this.ListBoxNovos = new System.Windows.Forms.ListBox();
            this.LabelEntradasTitulo = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCromos)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.GroupBoxResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCromos
            // 
            this.dataGridViewCromos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCromos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cromos});
            this.dataGridViewCromos.Location = new System.Drawing.Point(21, 52);
            this.dataGridViewCromos.Name = "dataGridViewCromos";
            this.dataGridViewCromos.Size = new System.Drawing.Size(294, 150);
            this.dataGridViewCromos.TabIndex = 0;
            // 
            // Cromos
            // 
            this.Cromos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cromos.HeaderText = "Cromos a dar entrada";
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
            // ButtonIntroduzir
            // 
            this.ButtonIntroduzir.Location = new System.Drawing.Point(352, 88);
            this.ButtonIntroduzir.Name = "ButtonIntroduzir";
            this.ButtonIntroduzir.Size = new System.Drawing.Size(100, 23);
            this.ButtonIntroduzir.TabIndex = 2;
            this.ButtonIntroduzir.Text = "Introduzir";
            this.toolTip1.SetToolTip(this.ButtonIntroduzir, "Registar cromos na tabela");
            this.ButtonIntroduzir.UseVisualStyleBackColor = true;
            // 
            // ButtonVerificar
            // 
            this.ButtonVerificar.Location = new System.Drawing.Point(352, 117);
            this.ButtonVerificar.Name = "ButtonVerificar";
            this.ButtonVerificar.Size = new System.Drawing.Size(100, 23);
            this.ButtonVerificar.TabIndex = 3;
            this.ButtonVerificar.Text = "&Verificar";
            this.toolTip1.SetToolTip(this.ButtonVerificar, "Verificar cromos sem os alterar.");
            this.ButtonVerificar.UseVisualStyleBackColor = true;
            // 
            // ButtonSair
            // 
            this.ButtonSair.Location = new System.Drawing.Point(352, 146);
            this.ButtonSair.Name = "ButtonSair";
            this.ButtonSair.Size = new System.Drawing.Size(100, 23);
            this.ButtonSair.TabIndex = 4;
            this.ButtonSair.Text = "&Sair";
            this.toolTip1.SetToolTip(this.ButtonSair, "Sair");
            this.ButtonSair.UseVisualStyleBackColor = true;
            // 
            // GroupBoxResultados
            // 
            this.GroupBoxResultados.Controls.Add(this.LabelRepetidos);
            this.GroupBoxResultados.Controls.Add(this.LabelNovos);
            this.GroupBoxResultados.Controls.Add(this.ListBoxRepetidos);
            this.GroupBoxResultados.Controls.Add(this.ListBoxNovos);
            this.GroupBoxResultados.Location = new System.Drawing.Point(12, 212);
            this.GroupBoxResultados.Name = "GroupBoxResultados";
            this.GroupBoxResultados.Size = new System.Drawing.Size(446, 234);
            this.GroupBoxResultados.TabIndex = 5;
            this.GroupBoxResultados.TabStop = false;
            this.GroupBoxResultados.Text = "Resultados";
            // 
            // LabelRepetidos
            // 
            this.LabelRepetidos.AutoSize = true;
            this.LabelRepetidos.Location = new System.Drawing.Point(229, 31);
            this.LabelRepetidos.Name = "LabelRepetidos";
            this.LabelRepetidos.Size = new System.Drawing.Size(93, 13);
            this.LabelRepetidos.TabIndex = 3;
            this.LabelRepetidos.Text = "Cromos Repetidos";
            // 
            // LabelNovos
            // 
            this.LabelNovos.AutoSize = true;
            this.LabelNovos.Location = new System.Drawing.Point(6, 31);
            this.LabelNovos.Name = "LabelNovos";
            this.LabelNovos.Size = new System.Drawing.Size(74, 13);
            this.LabelNovos.TabIndex = 2;
            this.LabelNovos.Text = "Cromos novos";
            // 
            // ListBoxRepetidos
            // 
            this.ListBoxRepetidos.FormattingEnabled = true;
            this.ListBoxRepetidos.Location = new System.Drawing.Point(232, 47);
            this.ListBoxRepetidos.Name = "ListBoxRepetidos";
            this.ListBoxRepetidos.Size = new System.Drawing.Size(208, 173);
            this.ListBoxRepetidos.TabIndex = 1;
            // 
            // ListBoxNovos
            // 
            this.ListBoxNovos.FormattingEnabled = true;
            this.ListBoxNovos.Location = new System.Drawing.Point(6, 47);
            this.ListBoxNovos.Name = "ListBoxNovos";
            this.ListBoxNovos.Size = new System.Drawing.Size(208, 173);
            this.ListBoxNovos.TabIndex = 0;
            // 
            // LabelEntradasTitulo
            // 
            this.LabelEntradasTitulo.AutoSize = true;
            this.LabelEntradasTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEntradasTitulo.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.LabelEntradasTitulo.Location = new System.Drawing.Point(207, 9);
            this.LabelEntradasTitulo.Name = "LabelEntradasTitulo";
            this.LabelEntradasTitulo.Size = new System.Drawing.Size(84, 24);
            this.LabelEntradasTitulo.TabIndex = 6;
            this.LabelEntradasTitulo.Text = "Entradas";
            // 
            // Entradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 471);
            this.Controls.Add(this.LabelEntradasTitulo);
            this.Controls.Add(this.GroupBoxResultados);
            this.Controls.Add(this.ButtonSair);
            this.Controls.Add(this.ButtonVerificar);
            this.Controls.Add(this.ButtonIntroduzir);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridViewCromos);
            this.Name = "Entradas";
            this.Text = "Entradas";
            this.Load += new System.EventHandler(this.Entradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCromos)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.GroupBoxResultados.ResumeLayout(false);
            this.GroupBoxResultados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCromos;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button ButtonIntroduzir;
        private System.Windows.Forms.Button ButtonVerificar;
        private System.Windows.Forms.Button ButtonSair;
        private System.Windows.Forms.GroupBox GroupBoxResultados;
        private System.Windows.Forms.ListBox ListBoxRepetidos;
        private System.Windows.Forms.ListBox ListBoxNovos;
        private System.Windows.Forms.Label LabelRepetidos;
        private System.Windows.Forms.Label LabelNovos;
        private System.Windows.Forms.Label LabelEntradasTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cromos;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}