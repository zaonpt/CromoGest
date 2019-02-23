﻿namespace CromoGest.Forms
{
    partial class FormNovaCaderneta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CadernetasComboBox = new System.Windows.Forms.ComboBox();
            this.LabelCadernetas = new System.Windows.Forms.Label();
            this.GroupBoxCaderneta = new System.Windows.Forms.GroupBox();
            this.GroupBoxCarteira = new System.Windows.Forms.GroupBox();
            this.TextQuantidadeCarteira = new System.Windows.Forms.TextBox();
            this.LabelCarteiraQuantidade = new System.Windows.Forms.Label();
            this.TextCarteiraCusto = new System.Windows.Forms.TextBox();
            this.LabelCarteiraCusto = new System.Windows.Forms.Label();
            this.TextQuantidade = new System.Windows.Forms.TextBox();
            this.LabelQuantidade = new System.Windows.Forms.Label();
            this.TextNome = new System.Windows.Forms.TextBox();
            this.LabelNome = new System.Windows.Forms.Label();
            this.ButtonCriar = new System.Windows.Forms.Button();
            this.ButtonSair = new System.Windows.Forms.Button();
            this.ButtonAlterar = new System.Windows.Forms.Button();
            this.LabelNovaCadernetaTitulo = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ButtonConcluir = new System.Windows.Forms.Button();
            this.ButtonAceitarPaginas = new System.Windows.Forms.Button();
            this.ButtonEliminar = new System.Windows.Forms.Button();
            this.TableLayoutPanelTitulo = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanelCad_Pag_Crom = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanelCaderneta_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanelButttons_Caderneta = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanelPag_Crom = new System.Windows.Forms.TableLayoutPanel();
            this.DataGridViewCromos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelPaginas = new System.Windows.Forms.Label();
            this.LabelCromos = new System.Windows.Forms.Label();
            this.DataGridViewPaginas = new System.Windows.Forms.DataGridView();
            this.Pagina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableLayoutPanelButtons_Paginas = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanelButtons_Cromos = new System.Windows.Forms.TableLayoutPanel();
            this.ToolStripNovaCaderneta = new System.Windows.Forms.ToolStrip();
            this.ToolStripLabelNovaCaderneta = new System.Windows.Forms.ToolStripLabel();
            this.ButtonLimpar = new System.Windows.Forms.Button();
            this.GroupBoxCaderneta.SuspendLayout();
            this.GroupBoxCarteira.SuspendLayout();
            this.TableLayoutPanelTitulo.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.TableLayoutPanelCad_Pag_Crom.SuspendLayout();
            this.TableLayoutPanelCaderneta_Buttons.SuspendLayout();
            this.TableLayoutPanelButttons_Caderneta.SuspendLayout();
            this.TableLayoutPanelPag_Crom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCromos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPaginas)).BeginInit();
            this.TableLayoutPanelButtons_Paginas.SuspendLayout();
            this.TableLayoutPanelButtons_Cromos.SuspendLayout();
            this.ToolStripNovaCaderneta.SuspendLayout();
            this.SuspendLayout();
            // 
            // CadernetasComboBox
            // 
            this.CadernetasComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CadernetasComboBox.ForeColor = System.Drawing.Color.Black;
            this.CadernetasComboBox.FormattingEnabled = true;
            this.CadernetasComboBox.Location = new System.Drawing.Point(152, 7);
            this.CadernetasComboBox.Name = "CadernetasComboBox";
            this.CadernetasComboBox.Size = new System.Drawing.Size(240, 21);
            this.CadernetasComboBox.TabIndex = 0;
            this.CadernetasComboBox.SelectedValueChanged += new System.EventHandler(this.CadernetasComboBox_SelectedValueChanged);
            // 
            // LabelCadernetas
            // 
            this.LabelCadernetas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelCadernetas.Location = new System.Drawing.Point(3, 11);
            this.LabelCadernetas.Name = "LabelCadernetas";
            this.LabelCadernetas.Size = new System.Drawing.Size(143, 13);
            this.LabelCadernetas.TabIndex = 1;
            this.LabelCadernetas.Text = "Cadernetas existentes";
            this.LabelCadernetas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GroupBoxCaderneta
            // 
            this.GroupBoxCaderneta.Controls.Add(this.GroupBoxCarteira);
            this.GroupBoxCaderneta.Controls.Add(this.TextQuantidade);
            this.GroupBoxCaderneta.Controls.Add(this.LabelQuantidade);
            this.GroupBoxCaderneta.Controls.Add(this.TextNome);
            this.GroupBoxCaderneta.Controls.Add(this.LabelNome);
            this.GroupBoxCaderneta.ForeColor = System.Drawing.Color.White;
            this.GroupBoxCaderneta.Location = new System.Drawing.Point(3, 3);
            this.GroupBoxCaderneta.Name = "GroupBoxCaderneta";
            this.GroupBoxCaderneta.Size = new System.Drawing.Size(306, 253);
            this.GroupBoxCaderneta.TabIndex = 2;
            this.GroupBoxCaderneta.TabStop = false;
            this.GroupBoxCaderneta.Text = "Caderneta Nova";
            // 
            // GroupBoxCarteira
            // 
            this.GroupBoxCarteira.Controls.Add(this.TextQuantidadeCarteira);
            this.GroupBoxCarteira.Controls.Add(this.LabelCarteiraQuantidade);
            this.GroupBoxCarteira.Controls.Add(this.TextCarteiraCusto);
            this.GroupBoxCarteira.Controls.Add(this.LabelCarteiraCusto);
            this.GroupBoxCarteira.ForeColor = System.Drawing.Color.White;
            this.GroupBoxCarteira.Location = new System.Drawing.Point(6, 129);
            this.GroupBoxCarteira.Name = "GroupBoxCarteira";
            this.GroupBoxCarteira.Size = new System.Drawing.Size(293, 118);
            this.GroupBoxCarteira.TabIndex = 4;
            this.GroupBoxCarteira.TabStop = false;
            this.GroupBoxCarteira.Text = "Carteira";
            // 
            // TextQuantidadeCarteira
            // 
            this.TextQuantidadeCarteira.Location = new System.Drawing.Point(100, 80);
            this.TextQuantidadeCarteira.Name = "TextQuantidadeCarteira";
            this.TextQuantidadeCarteira.Size = new System.Drawing.Size(164, 20);
            this.TextQuantidadeCarteira.TabIndex = 8;
            // 
            // LabelCarteiraQuantidade
            // 
            this.LabelCarteiraQuantidade.AutoSize = true;
            this.LabelCarteiraQuantidade.Location = new System.Drawing.Point(27, 87);
            this.LabelCarteiraQuantidade.Name = "LabelCarteiraQuantidade";
            this.LabelCarteiraQuantidade.Size = new System.Drawing.Size(62, 13);
            this.LabelCarteiraQuantidade.TabIndex = 7;
            this.LabelCarteiraQuantidade.Text = "Quantidade";
            // 
            // TextCarteiraCusto
            // 
            this.TextCarteiraCusto.Location = new System.Drawing.Point(100, 34);
            this.TextCarteiraCusto.Name = "TextCarteiraCusto";
            this.TextCarteiraCusto.Size = new System.Drawing.Size(164, 20);
            this.TextCarteiraCusto.TabIndex = 6;
            // 
            // LabelCarteiraCusto
            // 
            this.LabelCarteiraCusto.AutoSize = true;
            this.LabelCarteiraCusto.Location = new System.Drawing.Point(49, 37);
            this.LabelCarteiraCusto.Name = "LabelCarteiraCusto";
            this.LabelCarteiraCusto.Size = new System.Drawing.Size(34, 13);
            this.LabelCarteiraCusto.TabIndex = 5;
            this.LabelCarteiraCusto.Text = "Custo";
            // 
            // TextQuantidade
            // 
            this.TextQuantidade.Location = new System.Drawing.Point(106, 85);
            this.TextQuantidade.Name = "TextQuantidade";
            this.TextQuantidade.Size = new System.Drawing.Size(164, 20);
            this.TextQuantidade.TabIndex = 3;
            // 
            // LabelQuantidade
            // 
            this.LabelQuantidade.AutoSize = true;
            this.LabelQuantidade.Location = new System.Drawing.Point(33, 88);
            this.LabelQuantidade.Name = "LabelQuantidade";
            this.LabelQuantidade.Size = new System.Drawing.Size(62, 13);
            this.LabelQuantidade.TabIndex = 2;
            this.LabelQuantidade.Text = "Quantidade";
            // 
            // TextNome
            // 
            this.TextNome.Location = new System.Drawing.Point(106, 41);
            this.TextNome.Name = "TextNome";
            this.TextNome.Size = new System.Drawing.Size(164, 20);
            this.TextNome.TabIndex = 1;
            // 
            // LabelNome
            // 
            this.LabelNome.AutoSize = true;
            this.LabelNome.Location = new System.Drawing.Point(54, 44);
            this.LabelNome.Name = "LabelNome";
            this.LabelNome.Size = new System.Drawing.Size(35, 13);
            this.LabelNome.TabIndex = 0;
            this.LabelNome.Text = "Nome";
            // 
            // ButtonCriar
            // 
            this.ButtonCriar.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonCriar.ForeColor = System.Drawing.Color.Black;
            this.ButtonCriar.Location = new System.Drawing.Point(15, 13);
            this.ButtonCriar.Name = "ButtonCriar";
            this.ButtonCriar.Size = new System.Drawing.Size(100, 23);
            this.ButtonCriar.TabIndex = 3;
            this.ButtonCriar.TabStop = false;
            this.ButtonCriar.Text = "&Nova";
            this.toolTip1.SetToolTip(this.ButtonCriar, "Registar uma nova caderneta (a cima).");
            this.ButtonCriar.UseVisualStyleBackColor = false;
            this.ButtonCriar.Click += new System.EventHandler(this.ButtonCriar_Click);
            // 
            // ButtonSair
            // 
            this.ButtonSair.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonSair.ForeColor = System.Drawing.Color.Black;
            this.ButtonSair.Location = new System.Drawing.Point(15, 133);
            this.ButtonSair.Name = "ButtonSair";
            this.ButtonSair.Size = new System.Drawing.Size(100, 23);
            this.ButtonSair.TabIndex = 4;
            this.ButtonSair.Text = "&Sair";
            this.toolTip1.SetToolTip(this.ButtonSair, "Regressar ao Dashboard");
            this.ButtonSair.UseVisualStyleBackColor = false;
            // 
            // ButtonAlterar
            // 
            this.ButtonAlterar.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonAlterar.ForeColor = System.Drawing.Color.Black;
            this.ButtonAlterar.Location = new System.Drawing.Point(15, 43);
            this.ButtonAlterar.Name = "ButtonAlterar";
            this.ButtonAlterar.Size = new System.Drawing.Size(100, 23);
            this.ButtonAlterar.TabIndex = 5;
            this.ButtonAlterar.TabStop = false;
            this.ButtonAlterar.Text = "Alterar";
            this.toolTip1.SetToolTip(this.ButtonAlterar, "Registar alteração na caderneta selecionada e existente.");
            this.ButtonAlterar.UseVisualStyleBackColor = false;
            // 
            // LabelNovaCadernetaTitulo
            // 
            this.LabelNovaCadernetaTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelNovaCadernetaTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNovaCadernetaTitulo.ForeColor = System.Drawing.Color.White;
            this.LabelNovaCadernetaTitulo.Location = new System.Drawing.Point(3, 0);
            this.LabelNovaCadernetaTitulo.Name = "LabelNovaCadernetaTitulo";
            this.LabelNovaCadernetaTitulo.Size = new System.Drawing.Size(959, 40);
            this.LabelNovaCadernetaTitulo.TabIndex = 6;
            this.LabelNovaCadernetaTitulo.Text = "Caderneta Nova";
            this.LabelNovaCadernetaTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonConcluir
            // 
            this.ButtonConcluir.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonConcluir.Enabled = false;
            this.ButtonConcluir.ForeColor = System.Drawing.Color.Black;
            this.ButtonConcluir.Location = new System.Drawing.Point(3, 3);
            this.ButtonConcluir.Name = "ButtonConcluir";
            this.ButtonConcluir.Size = new System.Drawing.Size(100, 22);
            this.ButtonConcluir.TabIndex = 6;
            this.ButtonConcluir.TabStop = false;
            this.ButtonConcluir.Text = "&Concluir";
            this.toolTip1.SetToolTip(this.ButtonConcluir, "Registar uma nova caderneta.");
            this.ButtonConcluir.UseVisualStyleBackColor = false;
            this.ButtonConcluir.Click += new System.EventHandler(this.ButtonGravar_Click);
            // 
            // ButtonAceitarPaginas
            // 
            this.ButtonAceitarPaginas.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonAceitarPaginas.Enabled = false;
            this.ButtonAceitarPaginas.ForeColor = System.Drawing.Color.Black;
            this.ButtonAceitarPaginas.Location = new System.Drawing.Point(3, 3);
            this.ButtonAceitarPaginas.Name = "ButtonAceitarPaginas";
            this.ButtonAceitarPaginas.Size = new System.Drawing.Size(100, 22);
            this.ButtonAceitarPaginas.TabIndex = 7;
            this.ButtonAceitarPaginas.TabStop = false;
            this.ButtonAceitarPaginas.Text = "Aceitar";
            this.toolTip1.SetToolTip(this.ButtonAceitarPaginas, "Registar uma nova caderneta.");
            this.ButtonAceitarPaginas.UseVisualStyleBackColor = false;
            this.ButtonAceitarPaginas.Click += new System.EventHandler(this.ButtonAceitarPaginas_Click);
            // 
            // ButtonEliminar
            // 
            this.ButtonEliminar.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonEliminar.ForeColor = System.Drawing.Color.Black;
            this.ButtonEliminar.Location = new System.Drawing.Point(15, 103);
            this.ButtonEliminar.Name = "ButtonEliminar";
            this.ButtonEliminar.Size = new System.Drawing.Size(100, 23);
            this.ButtonEliminar.TabIndex = 6;
            this.ButtonEliminar.TabStop = false;
            this.ButtonEliminar.Text = "Eliminar";
            this.toolTip1.SetToolTip(this.ButtonEliminar, "Eliminar a caderneta selecionada, assim como toda a informação relativa a ela.");
            this.ButtonEliminar.UseVisualStyleBackColor = false;
            // 
            // TableLayoutPanelTitulo
            // 
            this.TableLayoutPanelTitulo.ColumnCount = 1;
            this.TableLayoutPanelTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelTitulo.Controls.Add(this.LabelNovaCadernetaTitulo, 0, 0);
            this.TableLayoutPanelTitulo.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.TableLayoutPanelTitulo.Controls.Add(this.TableLayoutPanelCad_Pag_Crom, 0, 2);
            this.TableLayoutPanelTitulo.Controls.Add(this.ToolStripNovaCaderneta, 0, 4);
            this.TableLayoutPanelTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelTitulo.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanelTitulo.Name = "TableLayoutPanelTitulo";
            this.TableLayoutPanelTitulo.RowCount = 5;
            this.TableLayoutPanelTitulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TableLayoutPanelTitulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.TableLayoutPanelTitulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelTitulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.TableLayoutPanelTitulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.TableLayoutPanelTitulo.Size = new System.Drawing.Size(965, 648);
            this.TableLayoutPanelTitulo.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 263F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.CadernetasComboBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.LabelCadernetas, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(959, 35);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // TableLayoutPanelCad_Pag_Crom
            // 
            this.TableLayoutPanelCad_Pag_Crom.ColumnCount = 2;
            this.TableLayoutPanelCad_Pag_Crom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 324F));
            this.TableLayoutPanelCad_Pag_Crom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelCad_Pag_Crom.Controls.Add(this.TableLayoutPanelCaderneta_Buttons, 0, 0);
            this.TableLayoutPanelCad_Pag_Crom.Controls.Add(this.TableLayoutPanelPag_Crom, 1, 0);
            this.TableLayoutPanelCad_Pag_Crom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelCad_Pag_Crom.Location = new System.Drawing.Point(3, 84);
            this.TableLayoutPanelCad_Pag_Crom.Name = "TableLayoutPanelCad_Pag_Crom";
            this.TableLayoutPanelCad_Pag_Crom.RowCount = 1;
            this.TableLayoutPanelCad_Pag_Crom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelCad_Pag_Crom.Size = new System.Drawing.Size(959, 529);
            this.TableLayoutPanelCad_Pag_Crom.TabIndex = 6;
            // 
            // TableLayoutPanelCaderneta_Buttons
            // 
            this.TableLayoutPanelCaderneta_Buttons.ColumnCount = 1;
            this.TableLayoutPanelCaderneta_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelCaderneta_Buttons.Controls.Add(this.GroupBoxCaderneta, 0, 0);
            this.TableLayoutPanelCaderneta_Buttons.Controls.Add(this.TableLayoutPanelButttons_Caderneta, 0, 1);
            this.TableLayoutPanelCaderneta_Buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelCaderneta_Buttons.Location = new System.Drawing.Point(3, 3);
            this.TableLayoutPanelCaderneta_Buttons.Name = "TableLayoutPanelCaderneta_Buttons";
            this.TableLayoutPanelCaderneta_Buttons.RowCount = 2;
            this.TableLayoutPanelCaderneta_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.TableLayoutPanelCaderneta_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelCaderneta_Buttons.Size = new System.Drawing.Size(318, 523);
            this.TableLayoutPanelCaderneta_Buttons.TabIndex = 3;
            // 
            // TableLayoutPanelButttons_Caderneta
            // 
            this.TableLayoutPanelButttons_Caderneta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TableLayoutPanelButttons_Caderneta.ColumnCount = 3;
            this.TableLayoutPanelButttons_Caderneta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.TableLayoutPanelButttons_Caderneta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelButttons_Caderneta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanelButttons_Caderneta.Controls.Add(this.ButtonCriar, 1, 1);
            this.TableLayoutPanelButttons_Caderneta.Controls.Add(this.ButtonAlterar, 1, 2);
            this.TableLayoutPanelButttons_Caderneta.Controls.Add(this.ButtonSair, 1, 5);
            this.TableLayoutPanelButttons_Caderneta.Controls.Add(this.ButtonEliminar, 1, 4);
            this.TableLayoutPanelButttons_Caderneta.Controls.Add(this.ButtonLimpar, 1, 3);
            this.TableLayoutPanelButttons_Caderneta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelButttons_Caderneta.Location = new System.Drawing.Point(3, 263);
            this.TableLayoutPanelButttons_Caderneta.Name = "TableLayoutPanelButttons_Caderneta";
            this.TableLayoutPanelButttons_Caderneta.RowCount = 7;
            this.TableLayoutPanelButttons_Caderneta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TableLayoutPanelButttons_Caderneta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TableLayoutPanelButttons_Caderneta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TableLayoutPanelButttons_Caderneta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TableLayoutPanelButttons_Caderneta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TableLayoutPanelButttons_Caderneta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TableLayoutPanelButttons_Caderneta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelButttons_Caderneta.Size = new System.Drawing.Size(312, 257);
            this.TableLayoutPanelButttons_Caderneta.TabIndex = 3;
            // 
            // TableLayoutPanelPag_Crom
            // 
            this.TableLayoutPanelPag_Crom.ColumnCount = 2;
            this.TableLayoutPanelPag_Crom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelPag_Crom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelPag_Crom.Controls.Add(this.DataGridViewCromos, 1, 1);
            this.TableLayoutPanelPag_Crom.Controls.Add(this.LabelPaginas, 0, 0);
            this.TableLayoutPanelPag_Crom.Controls.Add(this.LabelCromos, 1, 0);
            this.TableLayoutPanelPag_Crom.Controls.Add(this.DataGridViewPaginas, 0, 1);
            this.TableLayoutPanelPag_Crom.Controls.Add(this.TableLayoutPanelButtons_Paginas, 0, 2);
            this.TableLayoutPanelPag_Crom.Controls.Add(this.TableLayoutPanelButtons_Cromos, 1, 2);
            this.TableLayoutPanelPag_Crom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelPag_Crom.Location = new System.Drawing.Point(327, 3);
            this.TableLayoutPanelPag_Crom.Name = "TableLayoutPanelPag_Crom";
            this.TableLayoutPanelPag_Crom.RowCount = 3;
            this.TableLayoutPanelPag_Crom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TableLayoutPanelPag_Crom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelPag_Crom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.TableLayoutPanelPag_Crom.Size = new System.Drawing.Size(629, 523);
            this.TableLayoutPanelPag_Crom.TabIndex = 4;
            // 
            // DataGridViewCromos
            // 
            this.DataGridViewCromos.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewCromos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewCromos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.DataGridViewCromos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewCromos.Enabled = false;
            this.DataGridViewCromos.Location = new System.Drawing.Point(317, 33);
            this.DataGridViewCromos.Name = "DataGridViewCromos";
            this.DataGridViewCromos.Size = new System.Drawing.Size(309, 453);
            this.DataGridViewCromos.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn1.HeaderText = "Cromo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn2.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // LabelPaginas
            // 
            this.LabelPaginas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelPaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPaginas.Location = new System.Drawing.Point(3, 0);
            this.LabelPaginas.Name = "LabelPaginas";
            this.LabelPaginas.Size = new System.Drawing.Size(308, 30);
            this.LabelPaginas.TabIndex = 2;
            this.LabelPaginas.Text = "Paginas";
            this.LabelPaginas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelCromos
            // 
            this.LabelCromos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelCromos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCromos.Location = new System.Drawing.Point(317, 0);
            this.LabelCromos.Name = "LabelCromos";
            this.LabelCromos.Size = new System.Drawing.Size(309, 30);
            this.LabelCromos.TabIndex = 3;
            this.LabelCromos.Text = "Cromos";
            this.LabelCromos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataGridViewPaginas
            // 
            this.DataGridViewPaginas.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewPaginas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewPaginas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pagina,
            this.Quantidade});
            this.DataGridViewPaginas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewPaginas.Enabled = false;
            this.DataGridViewPaginas.Location = new System.Drawing.Point(3, 33);
            this.DataGridViewPaginas.Name = "DataGridViewPaginas";
            this.DataGridViewPaginas.Size = new System.Drawing.Size(308, 453);
            this.DataGridViewPaginas.TabIndex = 4;
            // 
            // Pagina
            // 
            this.Pagina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.Pagina.DefaultCellStyle = dataGridViewCellStyle3;
            this.Pagina.HeaderText = "Pagina";
            this.Pagina.Name = "Pagina";
            // 
            // Quantidade
            // 
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.Quantidade.DefaultCellStyle = dataGridViewCellStyle4;
            this.Quantidade.HeaderText = "Quantidade Cromos";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Width = 80;
            // 
            // TableLayoutPanelButtons_Paginas
            // 
            this.TableLayoutPanelButtons_Paginas.ColumnCount = 2;
            this.TableLayoutPanelButtons_Paginas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelButtons_Paginas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelButtons_Paginas.Controls.Add(this.ButtonAceitarPaginas, 0, 0);
            this.TableLayoutPanelButtons_Paginas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelButtons_Paginas.Location = new System.Drawing.Point(3, 492);
            this.TableLayoutPanelButtons_Paginas.Name = "TableLayoutPanelButtons_Paginas";
            this.TableLayoutPanelButtons_Paginas.RowCount = 1;
            this.TableLayoutPanelButtons_Paginas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelButtons_Paginas.Size = new System.Drawing.Size(308, 28);
            this.TableLayoutPanelButtons_Paginas.TabIndex = 7;
            // 
            // TableLayoutPanelButtons_Cromos
            // 
            this.TableLayoutPanelButtons_Cromos.ColumnCount = 2;
            this.TableLayoutPanelButtons_Cromos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelButtons_Cromos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelButtons_Cromos.Controls.Add(this.ButtonConcluir, 0, 0);
            this.TableLayoutPanelButtons_Cromos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelButtons_Cromos.Location = new System.Drawing.Point(317, 492);
            this.TableLayoutPanelButtons_Cromos.Name = "TableLayoutPanelButtons_Cromos";
            this.TableLayoutPanelButtons_Cromos.RowCount = 1;
            this.TableLayoutPanelButtons_Cromos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelButtons_Cromos.Size = new System.Drawing.Size(309, 28);
            this.TableLayoutPanelButtons_Cromos.TabIndex = 8;
            // 
            // ToolStripNovaCaderneta
            // 
            this.ToolStripNovaCaderneta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripLabelNovaCaderneta});
            this.ToolStripNovaCaderneta.Location = new System.Drawing.Point(0, 624);
            this.ToolStripNovaCaderneta.Name = "ToolStripNovaCaderneta";
            this.ToolStripNovaCaderneta.Size = new System.Drawing.Size(965, 24);
            this.ToolStripNovaCaderneta.TabIndex = 9;
            this.ToolStripNovaCaderneta.Text = "toolStrip1";
            // 
            // ToolStripLabelNovaCaderneta
            // 
            this.ToolStripLabelNovaCaderneta.Name = "ToolStripLabelNovaCaderneta";
            this.ToolStripLabelNovaCaderneta.Size = new System.Drawing.Size(823, 21);
            this.ToolStripLabelNovaCaderneta.Text = "Preencher a informação da caderneta (Esq). Depois preenche a informação de cada p" +
    "agina (centro). For fim e facultativamente, customizar os cromos (dir).";
            this.ToolStripLabelNovaCaderneta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ButtonLimpar
            // 
            this.ButtonLimpar.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonLimpar.ForeColor = System.Drawing.Color.Black;
            this.ButtonLimpar.Location = new System.Drawing.Point(15, 73);
            this.ButtonLimpar.Name = "ButtonLimpar";
            this.ButtonLimpar.Size = new System.Drawing.Size(100, 23);
            this.ButtonLimpar.TabIndex = 7;
            this.ButtonLimpar.TabStop = false;
            this.ButtonLimpar.Text = "Limpar";
            this.toolTip1.SetToolTip(this.ButtonLimpar, "Limpa campos para se introduzirem novos dados.");
            this.ButtonLimpar.UseVisualStyleBackColor = false;
            // 
            // FormNovaCaderneta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(965, 648);
            this.Controls.Add(this.TableLayoutPanelTitulo);
            this.ForeColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(857, 687);
            this.Name = "FormNovaCaderneta";
            this.Text = "CromoGest";
            this.GroupBoxCaderneta.ResumeLayout(false);
            this.GroupBoxCaderneta.PerformLayout();
            this.GroupBoxCarteira.ResumeLayout(false);
            this.GroupBoxCarteira.PerformLayout();
            this.TableLayoutPanelTitulo.ResumeLayout(false);
            this.TableLayoutPanelTitulo.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.TableLayoutPanelCad_Pag_Crom.ResumeLayout(false);
            this.TableLayoutPanelCaderneta_Buttons.ResumeLayout(false);
            this.TableLayoutPanelButttons_Caderneta.ResumeLayout(false);
            this.TableLayoutPanelPag_Crom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCromos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPaginas)).EndInit();
            this.TableLayoutPanelButtons_Paginas.ResumeLayout(false);
            this.TableLayoutPanelButtons_Cromos.ResumeLayout(false);
            this.ToolStripNovaCaderneta.ResumeLayout(false);
            this.ToolStripNovaCaderneta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CadernetasComboBox;
        private System.Windows.Forms.Label LabelCadernetas;
        private System.Windows.Forms.GroupBox GroupBoxCaderneta;
        private System.Windows.Forms.TextBox TextQuantidade;
        private System.Windows.Forms.Label LabelQuantidade;
        private System.Windows.Forms.TextBox TextNome;
        private System.Windows.Forms.Label LabelNome;
        private System.Windows.Forms.GroupBox GroupBoxCarteira;
        private System.Windows.Forms.TextBox TextCarteiraCusto;
        private System.Windows.Forms.Label LabelCarteiraCusto;
        private System.Windows.Forms.TextBox TextQuantidadeCarteira;
        private System.Windows.Forms.Label LabelCarteiraQuantidade;
        private System.Windows.Forms.Button ButtonCriar;
        private System.Windows.Forms.Button ButtonSair;
        private System.Windows.Forms.Button ButtonAlterar;
        private System.Windows.Forms.Label LabelNovaCadernetaTitulo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelTitulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelCad_Pag_Crom;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelCaderneta_Buttons;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelPag_Crom;
        private System.Windows.Forms.Label LabelPaginas;
        private System.Windows.Forms.Label LabelCromos;
        private System.Windows.Forms.DataGridView DataGridViewCromos;
        private System.Windows.Forms.DataGridView DataGridViewPaginas;
        private System.Windows.Forms.ToolStrip ToolStripNovaCaderneta;
        private System.Windows.Forms.ToolStripLabel ToolStripLabelNovaCaderneta;
        private System.Windows.Forms.Button ButtonAceitarPaginas;
        private System.Windows.Forms.Button ButtonConcluir;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelButttons_Caderneta;
        private System.Windows.Forms.Button ButtonEliminar;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelButtons_Paginas;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelButtons_Cromos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pagina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button ButtonLimpar;
    }
}

