namespace CromoGest.Forms
{
    partial class DestinatarioPickerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewContatos = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.cadernetasBDDataSet = new CromoGest.CadernetasBDDataSet();
            this.destinatarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.destinatarioTableAdapter = new CromoGest.CadernetasBDDataSetTableAdapters.DestinatarioTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iniciaisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reputaçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContatos)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cadernetasBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinatarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewContatos, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridViewContatos
            // 
            this.dataGridViewContatos.AutoGenerateColumns = false;
            this.dataGridViewContatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.iniciaisDataGridViewTextBoxColumn,
            this.origemDataGridViewTextBoxColumn,
            this.reputaçãoDataGridViewTextBoxColumn,
            this.moradaDataGridViewTextBoxColumn});
            this.dataGridViewContatos.DataSource = this.destinatarioBindingSource;
            this.dataGridViewContatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewContatos.Location = new System.Drawing.Point(3, 37);
            this.dataGridViewContatos.Name = "dataGridViewContatos";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewContatos.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewContatos.Size = new System.Drawing.Size(794, 410);
            this.dataGridViewContatos.TabIndex = 0;
            this.dataGridViewContatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewContatos_CellContentClick);

            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonSair, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 28);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(113, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 22);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonSair
            // 
            this.buttonSair.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSair.ForeColor = System.Drawing.Color.Black;
            this.buttonSair.Location = new System.Drawing.Point(3, 3);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(104, 22);
            this.buttonSair.TabIndex = 0;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // cadernetasBDDataSet
            // 
            this.cadernetasBDDataSet.DataSetName = "CadernetasBDDataSet";
            this.cadernetasBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // destinatarioBindingSource
            // 
            this.destinatarioBindingSource.DataMember = "Destinatario";
            this.destinatarioBindingSource.DataSource = this.cadernetasBDDataSet;
            // 
            // destinatarioTableAdapter
            // 
            this.destinatarioTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 41;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Width = 60;
            // 
            // iniciaisDataGridViewTextBoxColumn
            // 
            this.iniciaisDataGridViewTextBoxColumn.DataPropertyName = "Iniciais";
            this.iniciaisDataGridViewTextBoxColumn.HeaderText = "Iniciais";
            this.iniciaisDataGridViewTextBoxColumn.Name = "iniciaisDataGridViewTextBoxColumn";
            this.iniciaisDataGridViewTextBoxColumn.Width = 64;
            // 
            // origemDataGridViewTextBoxColumn
            // 
            this.origemDataGridViewTextBoxColumn.DataPropertyName = "Origem";
            this.origemDataGridViewTextBoxColumn.HeaderText = "Origem";
            this.origemDataGridViewTextBoxColumn.Name = "origemDataGridViewTextBoxColumn";
            this.origemDataGridViewTextBoxColumn.Width = 65;
            // 
            // reputaçãoDataGridViewTextBoxColumn
            // 
            this.reputaçãoDataGridViewTextBoxColumn.DataPropertyName = "Reputação";
            this.reputaçãoDataGridViewTextBoxColumn.HeaderText = "Reputação";
            this.reputaçãoDataGridViewTextBoxColumn.Name = "reputaçãoDataGridViewTextBoxColumn";
            this.reputaçãoDataGridViewTextBoxColumn.Width = 85;
            // 
            // moradaDataGridViewTextBoxColumn
            // 
            this.moradaDataGridViewTextBoxColumn.DataPropertyName = "Morada";
            this.moradaDataGridViewTextBoxColumn.HeaderText = "Morada";
            this.moradaDataGridViewTextBoxColumn.Name = "moradaDataGridViewTextBoxColumn";
            this.moradaDataGridViewTextBoxColumn.Width = 68;
            // 
            // DestinatarioPickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "DestinatarioPickerForm";
            this.Text = "DistinatarioPickerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DestinatarioPickerForm_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContatos)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cadernetasBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinatarioBindingSource)).EndInit();
            this.destinatarioTableAdapter.Fill(this.cadernetasBDDataSet.Destinatario);

            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewContatos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonSair;
        private CadernetasBDDataSet cadernetasBDDataSet;
        private System.Windows.Forms.BindingSource destinatarioBindingSource;
        private CadernetasBDDataSetTableAdapters.DestinatarioTableAdapter destinatarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iniciaisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn origemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reputaçãoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moradaDataGridViewTextBoxColumn;
    }
}