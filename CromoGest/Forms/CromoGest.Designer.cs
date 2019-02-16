namespace CromoGest
{
    partial class CromoGest
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
            this.CadernetasButton = new System.Windows.Forms.Button();
            this.TrocasButton = new System.Windows.Forms.Button();
            this.EntradasButton = new System.Windows.Forms.Button();
            this.HistoricoButton = new System.Windows.Forms.Button();
            this.EntradasGroupBox = new System.Windows.Forms.GroupBox();
            this.ConfigButton = new System.Windows.Forms.Button();
            this.DashboardTituloLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CadernetasButton
            // 
            this.CadernetasButton.Location = new System.Drawing.Point(12, 12);
            this.CadernetasButton.Name = "CadernetasButton";
            this.CadernetasButton.Size = new System.Drawing.Size(100, 23);
            this.CadernetasButton.TabIndex = 0;
            this.CadernetasButton.Text = "Cadernetas";
            this.CadernetasButton.UseVisualStyleBackColor = true;
            // 
            // TrocasButton
            // 
            this.TrocasButton.Location = new System.Drawing.Point(12, 70);
            this.TrocasButton.Name = "TrocasButton";
            this.TrocasButton.Size = new System.Drawing.Size(100, 23);
            this.TrocasButton.TabIndex = 2;
            this.TrocasButton.Text = "Trocas";
            this.TrocasButton.UseVisualStyleBackColor = true;
            // 
            // EntradasButton
            // 
            this.EntradasButton.Location = new System.Drawing.Point(12, 41);
            this.EntradasButton.Name = "EntradasButton";
            this.EntradasButton.Size = new System.Drawing.Size(100, 23);
            this.EntradasButton.TabIndex = 3;
            this.EntradasButton.Text = "Entradas";
            this.EntradasButton.UseVisualStyleBackColor = true;
            // 
            // HistoricoButton
            // 
            this.HistoricoButton.Location = new System.Drawing.Point(12, 99);
            this.HistoricoButton.Name = "HistoricoButton";
            this.HistoricoButton.Size = new System.Drawing.Size(100, 23);
            this.HistoricoButton.TabIndex = 4;
            this.HistoricoButton.Text = "Histórico";
            this.HistoricoButton.UseVisualStyleBackColor = true;
            // 
            // EntradasGroupBox
            // 
            this.EntradasGroupBox.Location = new System.Drawing.Point(226, 99);
            this.EntradasGroupBox.Name = "EntradasGroupBox";
            this.EntradasGroupBox.Size = new System.Drawing.Size(272, 296);
            this.EntradasGroupBox.TabIndex = 5;
            this.EntradasGroupBox.TabStop = false;
            this.EntradasGroupBox.Text = "Entradas";
            // 
            // ConfigButton
            // 
            this.ConfigButton.Location = new System.Drawing.Point(12, 128);
            this.ConfigButton.Name = "ConfigButton";
            this.ConfigButton.Size = new System.Drawing.Size(100, 23);
            this.ConfigButton.TabIndex = 6;
            this.ConfigButton.Text = "Configurações";
            this.ConfigButton.UseVisualStyleBackColor = true;
            // 
            // DashboardTituloLabel
            // 
            this.DashboardTituloLabel.AutoSize = true;
            this.DashboardTituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardTituloLabel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.DashboardTituloLabel.Location = new System.Drawing.Point(351, 12);
            this.DashboardTituloLabel.Name = "DashboardTituloLabel";
            this.DashboardTituloLabel.Size = new System.Drawing.Size(102, 24);
            this.DashboardTituloLabel.TabIndex = 7;
            this.DashboardTituloLabel.Text = "Dashboard";
            // 
            // CromoGest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DashboardTituloLabel);
            this.Controls.Add(this.ConfigButton);
            this.Controls.Add(this.EntradasGroupBox);
            this.Controls.Add(this.HistoricoButton);
            this.Controls.Add(this.EntradasButton);
            this.Controls.Add(this.TrocasButton);
            this.Controls.Add(this.CadernetasButton);
            this.Name = "CromoGest";
            this.Text = "Cromo Gest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CadernetasButton;
        private System.Windows.Forms.Button TrocasButton;
        private System.Windows.Forms.Button EntradasButton;
        private System.Windows.Forms.Button HistoricoButton;
        private System.Windows.Forms.GroupBox EntradasGroupBox;
        private System.Windows.Forms.Button ConfigButton;
        private System.Windows.Forms.Label DashboardTituloLabel;
    }
}