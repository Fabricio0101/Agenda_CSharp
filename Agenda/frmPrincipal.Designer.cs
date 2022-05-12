namespace Agenda
{
    partial class frmPrincipal
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
            this.btContatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btContatos
            // 
            this.btContatos.Location = new System.Drawing.Point(12, 12);
            this.btContatos.Name = "btContatos";
            this.btContatos.Size = new System.Drawing.Size(147, 70);
            this.btContatos.TabIndex = 0;
            this.btContatos.Text = "Contatos";
            this.btContatos.UseVisualStyleBackColor = true;
            this.btContatos.Click += new System.EventHandler(this.btContatos_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.btContatos);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda2022";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btContatos;
    }
}

