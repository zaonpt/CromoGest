namespace CromoGest.Forms
{
    partial class NovaCaderneta
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
            this.ButtonGravar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.DataGridViewCromos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelPaginas = new System.Windows.Forms.Label();
            this.LabelCromos = new System.Windows.Forms.Label();
            this.DataGridViewPaginas = new System.Windows.Forms.DataGridView();
            this.Pagina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolStripNovaCaderneta = new System.Windows.Forms.ToolStrip();
            this.ToolStripLabelNovaCaderneta = new System.Windows.Forms.ToolStripLabel();
            this.GroupBoxCaderneta.SuspendLayout();
            this.GroupBoxCarteira.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCromos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPaginas)).BeginInit();
            this.ToolStripNovaCaderneta.SuspendLayout();
            this.SuspendLayout();
            // 
            // CadernetasComboBox
            // 
            this.CadernetasComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CadernetasComboBox.FormattingEnabled = true;
            this.CadernetasComboBox.Location = new System.Drawing.Point(103, 7);
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
            this.LabelCadernetas.Size = new System.Drawing.Size(94, 13);
            this.LabelCadernetas.TabIndex = 1;
            this.LabelCadernetas.Text = "Caderneta";
            this.LabelCadernetas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GroupBoxCaderneta
            // 
            this.GroupBoxCaderneta.Controls.Add(this.GroupBoxCarteira);
            this.GroupBoxCaderneta.Controls.Add(this.TextQuantidade);
            this.GroupBoxCaderneta.Controls.Add(this.LabelQuantidade);
            this.GroupBoxCaderneta.Controls.Add(this.TextNome);
            this.GroupBoxCaderneta.Controls.Add(this.LabelNome);
            this.GroupBoxCaderneta.Location = new System.Drawing.Point(3, 3);
            this.GroupBoxCaderneta.Name = "GroupBoxCaderneta";
            this.GroupBoxCaderneta.Size = new System.Drawing.Size(306, 253);
            this.GroupBoxCaderneta.TabIndex = 2;
            this.GroupBoxCaderneta.TabStop = false;
            this.GroupBoxCaderneta.Text = "Caderneta";
            // 
            // GroupBoxCarteira
            // 
            this.GroupBoxCarteira.Controls.Add(this.TextQuantidadeCarteira);
            this.GroupBoxCarteira.Controls.Add(this.LabelCarteiraQuantidade);
            this.GroupBoxCarteira.Controls.Add(this.TextCarteiraCusto);
            this.GroupBoxCarteira.Controls.Add(this.LabelCarteiraCusto);
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
            this.ButtonCriar.Location = new System.Drawing.Point(43, 3);
            this.ButtonCriar.Name = "ButtonCriar";
            this.ButtonCriar.Size = new System.Drawing.Size(100, 23);
            this.ButtonCriar.TabIndex = 3;
            this.ButtonCriar.TabStop = false;
            this.ButtonCriar.Text = "&Nova";
            this.toolTip1.SetToolTip(this.ButtonCriar, "Registar uma nova caderneta.");
            this.ButtonCriar.UseVisualStyleBackColor = true;
            this.ButtonCriar.Click += new System.EventHandler(this.ButtonCriar_Click);
            // 
            // ButtonSair
            // 
            this.ButtonSair.Location = new System.Drawing.Point(263, 3);
            this.ButtonSair.Name = "ButtonSair";
            this.ButtonSair.Size = new System.Drawing.Size(100, 23);
            this.ButtonSair.TabIndex = 4;
            this.ButtonSair.Text = "&Sair";
            this.toolTip1.SetToolTip(this.ButtonSair, "Regressar ao Dashboard");
            this.ButtonSair.UseVisualStyleBackColor = true;
            // 
            // ButtonAlterar
            // 
            this.ButtonAlterar.Location = new System.Drawing.Point(153, 3);
            this.ButtonAlterar.Name = "ButtonAlterar";
            this.ButtonAlterar.Size = new System.Drawing.Size(100, 23);
            this.ButtonAlterar.TabIndex = 5;
            this.ButtonAlterar.TabStop = false;
            this.ButtonAlterar.Text = "Alterar";
            this.toolTip1.SetToolTip(this.ButtonAlterar, "Registar alteração na caderneta selecionada.");
            this.ButtonAlterar.UseVisualStyleBackColor = true;
            // 
            // LabelNovaCadernetaTitulo
            // 
            this.LabelNovaCadernetaTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelNovaCadernetaTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNovaCadernetaTitulo.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.LabelNovaCadernetaTitulo.Location = new System.Drawing.Point(3, 0);
            this.LabelNovaCadernetaTitulo.Name = "LabelNovaCadernetaTitulo";
            this.LabelNovaCadernetaTitulo.Size = new System.Drawing.Size(959, 40);
            this.LabelNovaCadernetaTitulo.TabIndex = 6;
            this.LabelNovaCadernetaTitulo.Text = "Nova Caderneta";
            this.LabelNovaCadernetaTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonGravar
            // 
            this.ButtonGravar.Location = new System.Drawing.Point(317, 461);
            this.ButtonGravar.Name = "ButtonGravar";
            this.ButtonGravar.Size = new System.Drawing.Size(100, 23);
            this.ButtonGravar.TabIndex = 6;
            this.ButtonGravar.TabStop = false;
            this.ButtonGravar.Text = "&Gravar";
            this.toolTip1.SetToolTip(this.ButtonGravar, "Registar uma nova caderneta.");
            this.ButtonGravar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 7;
            this.button1.TabStop = false;
            this.button1.Text = "&Criar";
            this.toolTip1.SetToolTip(this.button1, "Registar uma nova caderneta.");
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.LabelNovaCadernetaTitulo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ToolStripNovaCaderneta, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(965, 648);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 312F));
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
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.ButtonSair, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.ButtonAlterar, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.ButtonCriar, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 584);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(959, 31);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 324F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 84);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(959, 494);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.GroupBoxCaderneta, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(318, 488);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.ButtonGravar, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.DataGridViewCromos, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.LabelPaginas, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.LabelCromos, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.DataGridViewPaginas, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(327, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(629, 488);
            this.tableLayoutPanel6.TabIndex = 4;
            // 
            // DataGridViewCromos
            // 
            this.DataGridViewCromos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewCromos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.DataGridViewCromos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewCromos.Location = new System.Drawing.Point(317, 33);
            this.DataGridViewCromos.Name = "DataGridViewCromos";
            this.DataGridViewCromos.Size = new System.Drawing.Size(309, 422);
            this.DataGridViewCromos.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.HeaderText = "Cromo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // LabelPaginas
            // 
            this.LabelPaginas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelPaginas.Location = new System.Drawing.Point(3, 8);
            this.LabelPaginas.Name = "LabelPaginas";
            this.LabelPaginas.Size = new System.Drawing.Size(308, 13);
            this.LabelPaginas.TabIndex = 2;
            this.LabelPaginas.Text = "Paginas";
            this.LabelPaginas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelCromos
            // 
            this.LabelCromos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelCromos.Location = new System.Drawing.Point(317, 8);
            this.LabelCromos.Name = "LabelCromos";
            this.LabelCromos.Size = new System.Drawing.Size(309, 13);
            this.LabelCromos.TabIndex = 3;
            this.LabelCromos.Text = "Cromos";
            this.LabelCromos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataGridViewPaginas
            // 
            this.DataGridViewPaginas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewPaginas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pagina,
            this.Quantidade});
            this.DataGridViewPaginas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewPaginas.Location = new System.Drawing.Point(3, 33);
            this.DataGridViewPaginas.Name = "DataGridViewPaginas";
            this.DataGridViewPaginas.Size = new System.Drawing.Size(308, 422);
            this.DataGridViewPaginas.TabIndex = 4;
            // 
            // Pagina
            // 
            this.Pagina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pagina.HeaderText = "Pagina";
            this.Pagina.Name = "Pagina";
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Width = 80;
            // 
            // ToolStripNovaCaderneta
            // 
            this.ToolStripNovaCaderneta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripLabelNovaCaderneta});
            this.ToolStripNovaCaderneta.Location = new System.Drawing.Point(0, 618);
            this.ToolStripNovaCaderneta.Name = "ToolStripNovaCaderneta";
            this.ToolStripNovaCaderneta.Size = new System.Drawing.Size(965, 25);
            this.ToolStripNovaCaderneta.TabIndex = 9;
            this.ToolStripNovaCaderneta.Text = "toolStrip1";
            // 
            // ToolStripLabelNovaCaderneta
            // 
            this.ToolStripLabelNovaCaderneta.Name = "ToolStripLabelNovaCaderneta";
            this.ToolStripLabelNovaCaderneta.Size = new System.Drawing.Size(73, 22);
            this.ToolStripLabelNovaCaderneta.Text = "Notificações";
            // 
            // NovaCaderneta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 648);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(857, 687);
            this.Name = "NovaCaderneta";
            this.Text = "CromoGest";
            this.GroupBoxCaderneta.ResumeLayout(false);
            this.GroupBoxCaderneta.PerformLayout();
            this.GroupBoxCarteira.ResumeLayout(false);
            this.GroupBoxCarteira.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCromos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPaginas)).EndInit();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label LabelPaginas;
        private System.Windows.Forms.Label LabelCromos;
        private System.Windows.Forms.DataGridView DataGridViewCromos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView DataGridViewPaginas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pagina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.ToolStrip ToolStripNovaCaderneta;
        private System.Windows.Forms.ToolStripLabel ToolStripLabelNovaCaderneta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ButtonGravar;
    }
}

