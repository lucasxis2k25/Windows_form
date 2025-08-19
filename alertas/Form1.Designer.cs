namespace alertas
{
    partial class Alertas
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAlertaSimples = new System.Windows.Forms.Button();
            this.BtnAlertaRobusto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(144, 92);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(285, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "teste os alertas abaixo";
            // 
            // btnAlertaSimples
            // 
            this.btnAlertaSimples.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(103)))), ((int)(((byte)(86)))));
            this.btnAlertaSimples.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlertaSimples.ForeColor = System.Drawing.Color.White;
            this.btnAlertaSimples.Location = new System.Drawing.Point(217, 136);
            this.btnAlertaSimples.Name = "btnAlertaSimples";
            this.btnAlertaSimples.Size = new System.Drawing.Size(142, 34);
            this.btnAlertaSimples.TabIndex = 1;
            this.btnAlertaSimples.Text = "Alerta Simples";
            this.btnAlertaSimples.UseVisualStyleBackColor = false;
            this.btnAlertaSimples.Click += new System.EventHandler(this.btnAlertaSimples_Click);
            // 
            // BtnAlertaRobusto
            // 
            this.BtnAlertaRobusto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnAlertaRobusto.FlatAppearance.BorderSize = 0;
            this.BtnAlertaRobusto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlertaRobusto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnAlertaRobusto.Location = new System.Drawing.Point(208, 176);
            this.BtnAlertaRobusto.Name = "BtnAlertaRobusto";
            this.BtnAlertaRobusto.Size = new System.Drawing.Size(160, 38);
            this.BtnAlertaRobusto.TabIndex = 2;
            this.BtnAlertaRobusto.Text = "Alerta Robusto";
            this.BtnAlertaRobusto.UseVisualStyleBackColor = false;
            this.BtnAlertaRobusto.Click += new System.EventHandler(this.BtnAlertaRobusto_Click);
            // 
            // Alertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 301);
            this.Controls.Add(this.BtnAlertaRobusto);
            this.Controls.Add(this.btnAlertaSimples);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Alertas";
            this.Text = "Alertas";
            this.Click += new System.EventHandler(this.Alertas_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAlertaSimples;
        private System.Windows.Forms.Button BtnAlertaRobusto;
    }
}

