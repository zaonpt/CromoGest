﻿namespace CromoGest.Forms
{
    partial class CadernetaForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.LabelListaRepetido = new System.Windows.Forms.Label();
            this.TextListaRepetidos = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonInfo = new System.Windows.Forms.Button();
            this.ButtonEntradas = new System.Windows.Forms.Button();
            this.ButtonTrocas = new System.Windows.Forms.Button();
            this.ComboBoxCadernetas = new System.Windows.Forms.ComboBox();
            this.LabelCaderneta = new System.Windows.Forms.Label();
            this.ButtonNova = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.LabelListaCromos = new System.Windows.Forms.Label();
            this.TextListaCromos = new System.Windows.Forms.TextBox();
            this.dataGridViewCaderneta = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCaderneta)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewCaderneta, 0, 1);
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
            this.tableLayoutPanel4.Controls.Add(this.LabelListaRepetido, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.TextListaRepetidos, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 604);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(994, 24);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // LabelListaRepetido
            // 
            this.LabelListaRepetido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LabelListaRepetido.AutoSize = true;
            this.LabelListaRepetido.Location = new System.Drawing.Point(3, 5);
            this.LabelListaRepetido.Name = "LabelListaRepetido";
            this.LabelListaRepetido.Size = new System.Drawing.Size(80, 13);
            this.LabelListaRepetido.TabIndex = 0;
            this.LabelListaRepetido.Text = "Lista Repetidos";
            // 
            // TextListaRepetidos
            // 
            this.TextListaRepetidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextListaRepetidos.Location = new System.Drawing.Point(153, 3);
            this.TextListaRepetidos.Name = "TextListaRepetidos";
            this.TextListaRepetidos.ReadOnly = true;
            this.TextListaRepetidos.Size = new System.Drawing.Size(838, 20);
            this.TextListaRepetidos.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel2.Controls.Add(this.ButtonInfo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ButtonEntradas, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ButtonTrocas, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ComboBoxCadernetas, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.LabelCaderneta, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.ButtonNova, 6, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(994, 34);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // ButtonInfo
            // 
            this.ButtonInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ButtonInfo.ForeColor = System.Drawing.Color.Black;
            this.ButtonInfo.Location = new System.Drawing.Point(223, 5);
            this.ButtonInfo.Name = "ButtonInfo";
            this.ButtonInfo.Size = new System.Drawing.Size(104, 23);
            this.ButtonInfo.TabIndex = 13;
            this.ButtonInfo.Text = "Info";
            this.ButtonInfo.UseVisualStyleBackColor = true;
            // 
            // ButtonEntradas
            // 
            this.ButtonEntradas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ButtonEntradas.ForeColor = System.Drawing.Color.Black;
            this.ButtonEntradas.Location = new System.Drawing.Point(113, 5);
            this.ButtonEntradas.Name = "ButtonEntradas";
            this.ButtonEntradas.Size = new System.Drawing.Size(104, 23);
            this.ButtonEntradas.TabIndex = 12;
            this.ButtonEntradas.Text = "&Entradas";
            this.toolTip1.SetToolTip(this.ButtonEntradas, "Registar entrada de cromos.");
            this.ButtonEntradas.UseVisualStyleBackColor = true;
            this.ButtonEntradas.Click += new System.EventHandler(this.ButtonEntradas_Click);
            // 
            // ButtonTrocas
            // 
            this.ButtonTrocas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ButtonTrocas.ForeColor = System.Drawing.Color.Black;
            this.ButtonTrocas.Location = new System.Drawing.Point(3, 5);
            this.ButtonTrocas.Name = "ButtonTrocas";
            this.ButtonTrocas.Size = new System.Drawing.Size(104, 23);
            this.ButtonTrocas.TabIndex = 11;
            this.ButtonTrocas.Text = "&Trocas";
            this.toolTip1.SetToolTip(this.ButtonTrocas, "Aceder ao registo de trocas de cromos.");
            this.ButtonTrocas.UseVisualStyleBackColor = true;
            // 
            // ComboBoxCadernetas
            // 
            this.ComboBoxCadernetas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ComboBoxCadernetas.FormattingEnabled = true;
            this.ComboBoxCadernetas.Location = new System.Drawing.Point(443, 6);
            this.ComboBoxCadernetas.Name = "ComboBoxCadernetas";
            this.ComboBoxCadernetas.Size = new System.Drawing.Size(201, 21);
            this.ComboBoxCadernetas.TabIndex = 16;
            this.toolTip1.SetToolTip(this.ComboBoxCadernetas, "Selecionar caderneta.");
            this.ComboBoxCadernetas.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCadernetas_SelectedIndexChanged);
            // 
            // LabelCaderneta
            // 
            this.LabelCaderneta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelCaderneta.Location = new System.Drawing.Point(344, 9);
            this.LabelCaderneta.Name = "LabelCaderneta";
            this.LabelCaderneta.Size = new System.Drawing.Size(93, 16);
            this.LabelCaderneta.TabIndex = 17;
            this.LabelCaderneta.Text = "Caderneta";
            this.LabelCaderneta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ButtonNova
            // 
            this.ButtonNova.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ButtonNova.ForeColor = System.Drawing.Color.Black;
            this.ButtonNova.Location = new System.Drawing.Point(887, 5);
            this.ButtonNova.Name = "ButtonNova";
            this.ButtonNova.Size = new System.Drawing.Size(104, 23);
            this.ButtonNova.TabIndex = 15;
            this.ButtonNova.Text = "&Nova Caderneta";
            this.toolTip1.SetToolTip(this.ButtonNova, "Editar a descrição dos cromos e as paginas a que pertencem.");
            this.ButtonNova.UseVisualStyleBackColor = true;
            this.ButtonNova.Click += new System.EventHandler(this.ButtonNova_Click);
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
            this.tableLayoutPanel3.Controls.Add(this.LabelListaCromos, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.TextListaCromos, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 574);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(994, 24);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // LabelListaCromos
            // 
            this.LabelListaCromos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LabelListaCromos.AutoSize = true;
            this.LabelListaCromos.Location = new System.Drawing.Point(3, 5);
            this.LabelListaCromos.Name = "LabelListaCromos";
            this.LabelListaCromos.Size = new System.Drawing.Size(67, 13);
            this.LabelListaCromos.TabIndex = 0;
            this.LabelListaCromos.Text = "Lista Cromos";
            // 
            // TextListaCromos
            // 
            this.TextListaCromos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextListaCromos.Location = new System.Drawing.Point(153, 3);
            this.TextListaCromos.Name = "TextListaCromos";
            this.TextListaCromos.ReadOnly = true;
            this.TextListaCromos.Size = new System.Drawing.Size(838, 20);
            this.TextListaCromos.TabIndex = 1;
            // 
            // dataGridViewCaderneta
            // 
            this.dataGridViewCaderneta.AllowUserToAddRows = false;
            this.dataGridViewCaderneta.AllowUserToDeleteRows = false;
            this.dataGridViewCaderneta.AllowUserToResizeColumns = false;
            this.dataGridViewCaderneta.AllowUserToResizeRows = false;
            this.dataGridViewCaderneta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCaderneta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCaderneta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCaderneta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCaderneta.Location = new System.Drawing.Point(3, 43);
            this.dataGridViewCaderneta.Name = "dataGridViewCaderneta";
            this.dataGridViewCaderneta.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewCaderneta.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCaderneta.Size = new System.Drawing.Size(994, 525);
            this.dataGridViewCaderneta.TabIndex = 5;
            this.dataGridViewCaderneta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCaderneta_CellContentClick);
            this.dataGridViewCaderneta.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridViewCaderneta_ColumnAdded);
            // 
            // CadernetaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1000, 651);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "CadernetaForm";
            this.Text = "Caderneta";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCaderneta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button ButtonInfo;
        private System.Windows.Forms.Button ButtonEntradas;
        private System.Windows.Forms.Button ButtonTrocas;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button ButtonNova;
        private System.Windows.Forms.ComboBox ComboBoxCadernetas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label LabelListaRepetido;
        private System.Windows.Forms.TextBox TextListaRepetidos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label LabelListaCromos;
        private System.Windows.Forms.TextBox TextListaCromos;
        private System.Windows.Forms.Label LabelCaderneta;
        private System.Windows.Forms.DataGridView dataGridViewCaderneta;
    }
}