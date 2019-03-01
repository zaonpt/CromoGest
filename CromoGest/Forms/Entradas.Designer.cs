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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ButtonIntroduzir = new System.Windows.Forms.Button();
            this.ButtonVerificar = new System.Windows.Forms.Button();
            this.ButtonSair = new System.Windows.Forms.Button();
            this.GroupBoxResultados = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.LabelNovos = new System.Windows.Forms.Label();
            this.ListBoxRepetidos = new System.Windows.Forms.ListBox();
            this.LabelRepetidos = new System.Windows.Forms.Label();
            this.ListBoxNovos = new System.Windows.Forms.ListBox();
            this.LabelEntradasTitulo = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ButtonLimpar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LabelCadernetas = new System.Windows.Forms.Label();
            this.ComboBoxCadernetas = new System.Windows.Forms.ComboBox();
            this.Cromos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCromos)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.GroupBoxResultados.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCromos
            // 
            this.dataGridViewCromos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCromos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cromos});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridViewCromos, 2);
            this.dataGridViewCromos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCromos.Location = new System.Drawing.Point(3, 63);
            this.dataGridViewCromos.Name = "dataGridViewCromos";
            this.dataGridViewCromos.Size = new System.Drawing.Size(386, 234);
            this.dataGridViewCromos.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 540);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(504, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Black;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(315, 17);
            this.toolStripStatusLabel1.Text = "Escrever os cromos um por linha, ou separados por virgula";
            // 
            // ButtonIntroduzir
            // 
            this.ButtonIntroduzir.ForeColor = System.Drawing.Color.Black;
            this.ButtonIntroduzir.Location = new System.Drawing.Point(3, 3);
            this.ButtonIntroduzir.Name = "ButtonIntroduzir";
            this.ButtonIntroduzir.Size = new System.Drawing.Size(99, 23);
            this.ButtonIntroduzir.TabIndex = 2;
            this.ButtonIntroduzir.Text = "Introduzir";
            this.toolTip1.SetToolTip(this.ButtonIntroduzir, "Registar cromos na caderneta.");
            this.ButtonIntroduzir.UseVisualStyleBackColor = true;
            this.ButtonIntroduzir.Click += new System.EventHandler(this.ButtonIntroduzir_Click);
            // 
            // ButtonVerificar
            // 
            this.ButtonVerificar.ForeColor = System.Drawing.Color.Black;
            this.ButtonVerificar.Location = new System.Drawing.Point(3, 33);
            this.ButtonVerificar.Name = "ButtonVerificar";
            this.ButtonVerificar.Size = new System.Drawing.Size(99, 23);
            this.ButtonVerificar.TabIndex = 3;
            this.ButtonVerificar.Text = "&Verificar";
            this.toolTip1.SetToolTip(this.ButtonVerificar, "Verificar cromos sem os alterar.");
            this.ButtonVerificar.UseVisualStyleBackColor = true;
            // 
            // ButtonSair
            // 
            this.ButtonSair.ForeColor = System.Drawing.Color.Black;
            this.ButtonSair.Location = new System.Drawing.Point(3, 93);
            this.ButtonSair.Name = "ButtonSair";
            this.ButtonSair.Size = new System.Drawing.Size(99, 23);
            this.ButtonSair.TabIndex = 4;
            this.ButtonSair.Text = "&Sair";
            this.toolTip1.SetToolTip(this.ButtonSair, "Sair.");
            this.ButtonSair.UseVisualStyleBackColor = true;
            this.ButtonSair.Click += new System.EventHandler(this.ButtonSair_Click);
            // 
            // GroupBoxResultados
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.GroupBoxResultados, 3);
            this.GroupBoxResultados.Controls.Add(this.tableLayoutPanel3);
            this.GroupBoxResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBoxResultados.Location = new System.Drawing.Point(3, 303);
            this.GroupBoxResultados.Name = "GroupBoxResultados";
            this.GroupBoxResultados.Size = new System.Drawing.Size(498, 234);
            this.GroupBoxResultados.TabIndex = 5;
            this.GroupBoxResultados.TabStop = false;
            this.GroupBoxResultados.Text = "Resultados";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.LabelNovos, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.ListBoxRepetidos, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.LabelRepetidos, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.ListBoxNovos, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(492, 215);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // LabelNovos
            // 
            this.LabelNovos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LabelNovos.AutoSize = true;
            this.LabelNovos.Location = new System.Drawing.Point(3, 8);
            this.LabelNovos.Name = "LabelNovos";
            this.LabelNovos.Size = new System.Drawing.Size(74, 13);
            this.LabelNovos.TabIndex = 2;
            this.LabelNovos.Text = "Cromos novos";
            // 
            // ListBoxRepetidos
            // 
            this.ListBoxRepetidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxRepetidos.FormattingEnabled = true;
            this.ListBoxRepetidos.Location = new System.Drawing.Point(249, 33);
            this.ListBoxRepetidos.Name = "ListBoxRepetidos";
            this.ListBoxRepetidos.Size = new System.Drawing.Size(240, 179);
            this.ListBoxRepetidos.TabIndex = 1;
            // 
            // LabelRepetidos
            // 
            this.LabelRepetidos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LabelRepetidos.AutoSize = true;
            this.LabelRepetidos.Location = new System.Drawing.Point(249, 8);
            this.LabelRepetidos.Name = "LabelRepetidos";
            this.LabelRepetidos.Size = new System.Drawing.Size(93, 13);
            this.LabelRepetidos.TabIndex = 3;
            this.LabelRepetidos.Text = "Cromos Repetidos";
            // 
            // ListBoxNovos
            // 
            this.ListBoxNovos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxNovos.FormattingEnabled = true;
            this.ListBoxNovos.Location = new System.Drawing.Point(3, 33);
            this.ListBoxNovos.Name = "ListBoxNovos";
            this.ListBoxNovos.Size = new System.Drawing.Size(240, 179);
            this.ListBoxNovos.TabIndex = 0;
            // 
            // LabelEntradasTitulo
            // 
            this.LabelEntradasTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelEntradasTitulo.AutoSize = true;
            this.LabelEntradasTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEntradasTitulo.ForeColor = System.Drawing.Color.White;
            this.LabelEntradasTitulo.Location = new System.Drawing.Point(252, 3);
            this.LabelEntradasTitulo.Name = "LabelEntradasTitulo";
            this.LabelEntradasTitulo.Size = new System.Drawing.Size(84, 24);
            this.LabelEntradasTitulo.TabIndex = 6;
            this.LabelEntradasTitulo.Text = "Entradas";
            this.LabelEntradasTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonLimpar
            // 
            this.ButtonLimpar.ForeColor = System.Drawing.Color.Black;
            this.ButtonLimpar.Location = new System.Drawing.Point(3, 63);
            this.ButtonLimpar.Name = "ButtonLimpar";
            this.ButtonLimpar.Size = new System.Drawing.Size(99, 23);
            this.ButtonLimpar.TabIndex = 7;
            this.ButtonLimpar.Text = "&Limpar";
            this.toolTip1.SetToolTip(this.ButtonLimpar, "Limpar tabelas para introduzir mais cromos.");
            this.ButtonLimpar.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewCromos, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LabelCadernetas, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LabelEntradasTitulo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ComboBoxCadernetas, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.GroupBoxResultados, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(504, 540);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.ButtonIntroduzir, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ButtonLimpar, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.ButtonVerificar, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.ButtonSair, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(395, 63);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(106, 234);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // LabelCadernetas
            // 
            this.LabelCadernetas.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelCadernetas.AutoSize = true;
            this.LabelCadernetas.Location = new System.Drawing.Point(132, 38);
            this.LabelCadernetas.Name = "LabelCadernetas";
            this.LabelCadernetas.Size = new System.Drawing.Size(61, 13);
            this.LabelCadernetas.TabIndex = 7;
            this.LabelCadernetas.Text = "Cadernetas";
            // 
            // ComboBoxCadernetas
            // 
            this.ComboBoxCadernetas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxCadernetas.FormattingEnabled = true;
            this.ComboBoxCadernetas.Location = new System.Drawing.Point(199, 34);
            this.ComboBoxCadernetas.Name = "ComboBoxCadernetas";
            this.ComboBoxCadernetas.Size = new System.Drawing.Size(190, 21);
            this.ComboBoxCadernetas.TabIndex = 8;
            // 
            // Cromos
            // 
            this.Cromos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cromos.DataPropertyName = "Cromos";
            this.Cromos.HeaderText = "Lista de Cromos";
            this.Cromos.Name = "Cromos";
            // 
            // Entradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(504, 562);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(520, 601);
            this.Name = "Entradas";
            this.Text = "Entradas";
            this.Load += new System.EventHandler(this.Entradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCromos)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.GroupBoxResultados.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
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
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button ButtonLimpar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label LabelCadernetas;
        private System.Windows.Forms.ComboBox ComboBoxCadernetas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cromos;
    }
}