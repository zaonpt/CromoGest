namespace CromoGest.Forms
{
    partial class ConfigForm
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
            this.Labellixo = new System.Windows.Forms.Label();
            this.LabelLinguagem = new System.Windows.Forms.Label();
            this.ComboBoxLimguagem = new System.Windows.Forms.ComboBox();
            this.LabelCaracter = new System.Windows.Forms.Label();
            this.TextSeparador = new System.Windows.Forms.TextBox();
            this.ConfigToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Labellixo
            // 
            this.Labellixo.AutoSize = true;
            this.Labellixo.Location = new System.Drawing.Point(219, 53);
            this.Labellixo.Name = "Labellixo";
            this.Labellixo.Size = new System.Drawing.Size(236, 13);
            this.Labellixo.TabIndex = 0;
            this.Labellixo.Text = "PRELIMINAR.So ideias para implementar depois";
            // 
            // LabelLinguagem
            // 
            this.LabelLinguagem.Location = new System.Drawing.Point(31, 114);
            this.LabelLinguagem.Name = "LabelLinguagem";
            this.LabelLinguagem.Size = new System.Drawing.Size(95, 18);
            this.LabelLinguagem.TabIndex = 1;
            this.LabelLinguagem.Text = "Lingua";
            this.LabelLinguagem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ComboBoxLimguagem
            // 
            this.ComboBoxLimguagem.FormattingEnabled = true;
            this.ComboBoxLimguagem.Items.AddRange(new object[] {
            "Português",
            "English",
            "Franch",
            "Dutch"});
            this.ComboBoxLimguagem.Location = new System.Drawing.Point(132, 114);
            this.ComboBoxLimguagem.Name = "ComboBoxLimguagem";
            this.ComboBoxLimguagem.Size = new System.Drawing.Size(186, 21);
            this.ComboBoxLimguagem.TabIndex = 2;
            this.ComboBoxLimguagem.Text = "Português";
            this.ConfigToolTip.SetToolTip(this.ComboBoxLimguagem, "Lingua usada em toda a aplicação.");
            // 
            // LabelCaracter
            // 
            this.LabelCaracter.Location = new System.Drawing.Point(34, 184);
            this.LabelCaracter.Name = "LabelCaracter";
            this.LabelCaracter.Size = new System.Drawing.Size(92, 13);
            this.LabelCaracter.TabIndex = 3;
            this.LabelCaracter.Text = "Separador";
            this.LabelCaracter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextSeparador
            // 
            this.TextSeparador.Location = new System.Drawing.Point(132, 181);
            this.TextSeparador.MaxLength = 1;
            this.TextSeparador.Name = "TextSeparador";
            this.TextSeparador.Size = new System.Drawing.Size(29, 20);
            this.TextSeparador.TabIndex = 4;
            this.TextSeparador.Text = ",";
            this.ConfigToolTip.SetToolTip(this.TextSeparador, "Caracter separador para usar nas listas de cromos (default é virgula).");
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Escuro",
            "Claro"});
            this.comboBox1.Location = new System.Drawing.Point(132, 249);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "Escuro";
            this.ConfigToolTip.SetToolTip(this.comboBox1, "Lingua usada em toda a aplicação.");
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(31, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "theme";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextSeparador);
            this.Controls.Add(this.LabelCaracter);
            this.Controls.Add(this.ComboBoxLimguagem);
            this.Controls.Add(this.LabelLinguagem);
            this.Controls.Add(this.Labellixo);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Config";
            this.Text = "Config";
            this.Load += new System.EventHandler(this.Config_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Labellixo;
        private System.Windows.Forms.Label LabelLinguagem;
        private System.Windows.Forms.ComboBox ComboBoxLimguagem;
        private System.Windows.Forms.ToolTip ConfigToolTip;
        private System.Windows.Forms.Label LabelCaracter;
        private System.Windows.Forms.TextBox TextSeparador;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}