namespace CromoGest.Forms
{
    partial class Caderneta
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.ListaRepetidoLabel = new System.Windows.Forms.Label();
            this.ListaRepetidosLabel = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.InfoButton = new System.Windows.Forms.Button();
            this.EntradasButton = new System.Windows.Forms.Button();
            this.TrocasButton = new System.Windows.Forms.Button();
            this.EditarButton = new System.Windows.Forms.Button();
            this.CadernetaComboBox = new System.Windows.Forms.ComboBox();
            this.CadernetaLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Pagina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ListaCromosLabel = new System.Windows.Forms.Label();
            this.ListaCromosText = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1000, 651);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.ListaRepetidoLabel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.ListaRepetidosLabel, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 604);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(994, 24);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // ListaRepetidoLabel
            // 
            this.ListaRepetidoLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ListaRepetidoLabel.AutoSize = true;
            this.ListaRepetidoLabel.Location = new System.Drawing.Point(3, 5);
            this.ListaRepetidoLabel.Name = "ListaRepetidoLabel";
            this.ListaRepetidoLabel.Size = new System.Drawing.Size(80, 13);
            this.ListaRepetidoLabel.TabIndex = 0;
            this.ListaRepetidoLabel.Text = "Lista Repetidos";
            // 
            // ListaRepetidosLabel
            // 
            this.ListaRepetidosLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListaRepetidosLabel.Location = new System.Drawing.Point(153, 3);
            this.ListaRepetidosLabel.Name = "ListaRepetidosLabel";
            this.ListaRepetidosLabel.ReadOnly = true;
            this.ListaRepetidosLabel.Size = new System.Drawing.Size(838, 20);
            this.ListaRepetidosLabel.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel2.Controls.Add(this.InfoButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.EntradasButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.TrocasButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.EditarButton, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.CadernetaComboBox, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.CadernetaLabel, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(994, 34);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // InfoButton
            // 
            this.InfoButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.InfoButton.Location = new System.Drawing.Point(223, 5);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(104, 23);
            this.InfoButton.TabIndex = 13;
            this.InfoButton.Text = "Info";
            this.InfoButton.UseVisualStyleBackColor = true;
            // 
            // EntradasButton
            // 
            this.EntradasButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EntradasButton.Location = new System.Drawing.Point(113, 5);
            this.EntradasButton.Name = "EntradasButton";
            this.EntradasButton.Size = new System.Drawing.Size(104, 23);
            this.EntradasButton.TabIndex = 12;
            this.EntradasButton.Text = "&Entradas";
            this.toolTip1.SetToolTip(this.EntradasButton, "Registar entrada de cromos.");
            this.EntradasButton.UseVisualStyleBackColor = true;
            // 
            // TrocasButton
            // 
            this.TrocasButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TrocasButton.Location = new System.Drawing.Point(3, 5);
            this.TrocasButton.Name = "TrocasButton";
            this.TrocasButton.Size = new System.Drawing.Size(104, 23);
            this.TrocasButton.TabIndex = 11;
            this.TrocasButton.Text = "&Trocas";
            this.toolTip1.SetToolTip(this.TrocasButton, "Aceder ao registo de trocas de cromos.");
            this.TrocasButton.UseVisualStyleBackColor = true;
            // 
            // EditarButton
            // 
            this.EditarButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EditarButton.Location = new System.Drawing.Point(887, 5);
            this.EditarButton.Name = "EditarButton";
            this.EditarButton.Size = new System.Drawing.Size(104, 23);
            this.EditarButton.TabIndex = 15;
            this.EditarButton.Text = "&Editar";
            this.toolTip1.SetToolTip(this.EditarButton, "Editar a descrição dos cromos e as paginas a que pertencem.");
            this.EditarButton.UseVisualStyleBackColor = true;
            // 
            // CadernetaComboBox
            // 
            this.CadernetaComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CadernetaComboBox.FormattingEnabled = true;
            this.CadernetaComboBox.Location = new System.Drawing.Point(443, 6);
            this.CadernetaComboBox.Name = "CadernetaComboBox";
            this.CadernetaComboBox.Size = new System.Drawing.Size(201, 21);
            this.CadernetaComboBox.TabIndex = 16;
            this.toolTip1.SetToolTip(this.CadernetaComboBox, "Selecionar caderneta.");
            // 
            // CadernetaLabel
            // 
            this.CadernetaLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CadernetaLabel.Location = new System.Drawing.Point(344, 9);
            this.CadernetaLabel.Name = "CadernetaLabel";
            this.CadernetaLabel.Size = new System.Drawing.Size(93, 16);
            this.CadernetaLabel.TabIndex = 17;
            this.CadernetaLabel.Text = "Caderneta";
            this.CadernetaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pagina});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(994, 525);
            this.dataGridView1.TabIndex = 1;
            // 
            // Pagina
            // 
            this.Pagina.Frozen = true;
            this.Pagina.HeaderText = "Pagina";
            this.Pagina.Name = "Pagina";
            this.Pagina.ReadOnly = true;
            this.Pagina.Width = 200;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 631);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1000, 20);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.ListaCromosLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.ListaCromosText, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 574);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(994, 24);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // ListaCromosLabel
            // 
            this.ListaCromosLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ListaCromosLabel.AutoSize = true;
            this.ListaCromosLabel.Location = new System.Drawing.Point(3, 5);
            this.ListaCromosLabel.Name = "ListaCromosLabel";
            this.ListaCromosLabel.Size = new System.Drawing.Size(67, 13);
            this.ListaCromosLabel.TabIndex = 0;
            this.ListaCromosLabel.Text = "Lista Cromos";
            // 
            // ListaCromosText
            // 
            this.ListaCromosText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListaCromosText.Location = new System.Drawing.Point(153, 3);
            this.ListaCromosText.Name = "ListaCromosText";
            this.ListaCromosText.ReadOnly = true;
            this.ListaCromosText.Size = new System.Drawing.Size(838, 20);
            this.ListaCromosText.TabIndex = 1;
            // 
            // Caderneta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 651);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Caderneta";
            this.Text = "Caderneta";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button InfoButton;
        private System.Windows.Forms.Button EntradasButton;
        private System.Windows.Forms.Button TrocasButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button EditarButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pagina;
        private System.Windows.Forms.ComboBox CadernetaComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label ListaRepetidoLabel;
        private System.Windows.Forms.TextBox ListaRepetidosLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label ListaCromosLabel;
        private System.Windows.Forms.TextBox ListaCromosText;
        private System.Windows.Forms.Label CadernetaLabel;
    }
}