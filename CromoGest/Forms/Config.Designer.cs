namespace CromoGest.Forms
{
    partial class Config
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
            this.label1 = new System.Windows.Forms.Label();
            this.LinguagemLabel = new System.Windows.Forms.Label();
            this.LimguagemComboBox = new System.Windows.Forms.ComboBox();
            this.CaracterLabel = new System.Windows.Forms.Label();
            this.SeparadorText = new System.Windows.Forms.TextBox();
            this.ConfigToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRELIMINAR.So ideias para implementar depois";
            // 
            // LinguagemLabel
            // 
            this.LinguagemLabel.AutoSize = true;
            this.LinguagemLabel.Location = new System.Drawing.Point(67, 117);
            this.LinguagemLabel.Name = "LinguagemLabel";
            this.LinguagemLabel.Size = new System.Drawing.Size(59, 13);
            this.LinguagemLabel.TabIndex = 1;
            this.LinguagemLabel.Text = "Linguagem";
            // 
            // LimguagemComboBox
            // 
            this.LimguagemComboBox.FormattingEnabled = true;
            this.LimguagemComboBox.Location = new System.Drawing.Point(132, 114);
            this.LimguagemComboBox.Name = "LimguagemComboBox";
            this.LimguagemComboBox.Size = new System.Drawing.Size(186, 21);
            this.LimguagemComboBox.TabIndex = 2;
            this.ConfigToolTip.SetToolTip(this.LimguagemComboBox, "Lingua usada em toda a aplicação.");
            // 
            // CaracterLabel
            // 
            this.CaracterLabel.AutoSize = true;
            this.CaracterLabel.Location = new System.Drawing.Point(70, 184);
            this.CaracterLabel.Name = "CaracterLabel";
            this.CaracterLabel.Size = new System.Drawing.Size(56, 13);
            this.CaracterLabel.TabIndex = 3;
            this.CaracterLabel.Text = "Separador";
            // 
            // SeparadorText
            // 
            this.SeparadorText.Location = new System.Drawing.Point(132, 181);
            this.SeparadorText.Name = "SeparadorText";
            this.SeparadorText.Size = new System.Drawing.Size(76, 20);
            this.SeparadorText.TabIndex = 4;
            this.ConfigToolTip.SetToolTip(this.SeparadorText, "Caracter separador para usar nas listas de cromos (default é virgula).");
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SeparadorText);
            this.Controls.Add(this.CaracterLabel);
            this.Controls.Add(this.LimguagemComboBox);
            this.Controls.Add(this.LinguagemLabel);
            this.Controls.Add(this.label1);
            this.Name = "Config";
            this.Text = "Config";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LinguagemLabel;
        private System.Windows.Forms.ComboBox LimguagemComboBox;
        private System.Windows.Forms.ToolTip ConfigToolTip;
        private System.Windows.Forms.Label CaracterLabel;
        private System.Windows.Forms.TextBox SeparadorText;
    }
}