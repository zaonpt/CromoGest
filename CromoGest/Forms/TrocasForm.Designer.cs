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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TrocasToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewTrocas = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonNova = new System.Windows.Forms.Button();
            this.CadernetasLabel = new System.Windows.Forms.Label();
            this.ComboBoxCadernetas = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.labelTrocas = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrocas)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewTrocas, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelTrocas, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1073, 657);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // dataGridViewTrocas
            // 
            this.dataGridViewTrocas.AllowUserToAddRows = false;
            this.dataGridViewTrocas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTrocas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTrocas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrocas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTrocas.Location = new System.Drawing.Point(3, 73);
            this.dataGridViewTrocas.Name = "dataGridViewTrocas";
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTrocas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTrocas.Size = new System.Drawing.Size(1067, 556);
            this.dataGridViewTrocas.TabIndex = 1;
            this.dataGridViewTrocas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewTrocas_CellContentDoubleClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 635);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1073, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.ButtonNova, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.CadernetasLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ComboBoxCadernetas, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.button2, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 33);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1067, 34);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // ButtonNova
            // 
            this.ButtonNova.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ButtonNova.ForeColor = System.Drawing.Color.Black;
            this.ButtonNova.Location = new System.Drawing.Point(3, 5);
            this.ButtonNova.Name = "ButtonNova";
            this.ButtonNova.Size = new System.Drawing.Size(104, 23);
            this.ButtonNova.TabIndex = 12;
            this.ButtonNova.Text = "&Nova";
            this.ButtonNova.UseVisualStyleBackColor = true;
            this.ButtonNova.Click += new System.EventHandler(this.ButtonNova_Click);
            // 
            // CadernetasLabel
            // 
            this.CadernetasLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CadernetasLabel.AutoSize = true;
            this.CadernetasLabel.Location = new System.Drawing.Point(156, 10);
            this.CadernetasLabel.Name = "CadernetasLabel";
            this.CadernetasLabel.Size = new System.Drawing.Size(61, 13);
            this.CadernetasLabel.TabIndex = 0;
            this.CadernetasLabel.Text = "Cadernetas";
            // 
            // ComboBoxCadernetas
            // 
            this.ComboBoxCadernetas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxCadernetas.FormattingEnabled = true;
            this.ComboBoxCadernetas.Location = new System.Drawing.Point(223, 6);
            this.ComboBoxCadernetas.Name = "ComboBoxCadernetas";
            this.ComboBoxCadernetas.Size = new System.Drawing.Size(711, 21);
            this.ComboBoxCadernetas.TabIndex = 1;
            this.ComboBoxCadernetas.SelectedIndexChanged += new System.EventHandler(this.CadernetasComboBox_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(960, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "&Trocas";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // labelTrocas
            // 
            this.labelTrocas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTrocas.AutoSize = true;
            this.labelTrocas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrocas.Location = new System.Drawing.Point(3, 0);
            this.labelTrocas.Name = "labelTrocas";
            this.labelTrocas.Size = new System.Drawing.Size(1067, 30);
            this.labelTrocas.TabIndex = 4;
            this.labelTrocas.Text = "Trocas";
            this.labelTrocas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TrocasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1073, 657);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(860, 468);
            this.Name = "TrocasForm";
            this.Text = "Trocas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrocasForm_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.TrocasForm_VisibleChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrocas)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip TrocasToolTip;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewTrocas;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label CadernetasLabel;
        private System.Windows.Forms.ComboBox ComboBoxCadernetas;
        private System.Windows.Forms.Button ButtonNova;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelTrocas;
    }
}