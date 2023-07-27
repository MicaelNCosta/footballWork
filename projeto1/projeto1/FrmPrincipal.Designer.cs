
namespace projeto1
{
    partial class FrmPrincipal
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
            this.btnPlanos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlanos
            // 
            this.btnPlanos.Location = new System.Drawing.Point(1026, 64);
            this.btnPlanos.Name = "btnPlanos";
            this.btnPlanos.Size = new System.Drawing.Size(118, 40);
            this.btnPlanos.TabIndex = 0;
            this.btnPlanos.Text = "Planos";
            this.btnPlanos.UseVisualStyleBackColor = true;
            this.btnPlanos.Click += new System.EventHandler(this.btnPlanos_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 822);
            this.Controls.Add(this.btnPlanos);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlanos;
    }
}

