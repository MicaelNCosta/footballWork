
namespace projeto1
{
    partial class frmCartaoPixBoleto
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
            this.rbCartao = new System.Windows.Forms.RadioButton();
            this.rbBoleto = new System.Windows.Forms.RadioButton();
            this.rbPix = new System.Windows.Forms.RadioButton();
            this.picBox3 = new System.Windows.Forms.PictureBox();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbCartao
            // 
            this.rbCartao.AutoSize = true;
            this.rbCartao.Location = new System.Drawing.Point(670, 382);
            this.rbCartao.Name = "rbCartao";
            this.rbCartao.Size = new System.Drawing.Size(14, 13);
            this.rbCartao.TabIndex = 0;
            this.rbCartao.TabStop = true;
            this.rbCartao.UseVisualStyleBackColor = true;
            // 
            // rbBoleto
            // 
            this.rbBoleto.AutoSize = true;
            this.rbBoleto.Location = new System.Drawing.Point(268, 382);
            this.rbBoleto.Name = "rbBoleto";
            this.rbBoleto.Size = new System.Drawing.Size(14, 13);
            this.rbBoleto.TabIndex = 1;
            this.rbBoleto.TabStop = true;
            this.rbBoleto.UseVisualStyleBackColor = true;
            // 
            // rbPix
            // 
            this.rbPix.AutoSize = true;
            this.rbPix.Location = new System.Drawing.Point(1073, 382);
            this.rbPix.Name = "rbPix";
            this.rbPix.Size = new System.Drawing.Size(14, 13);
            this.rbPix.TabIndex = 2;
            this.rbPix.TabStop = true;
            this.rbPix.UseVisualStyleBackColor = true;
            // 
            // picBox3
            // 
            this.picBox3.Image = global::projeto1.Properties.Resources.logo_pix_icone_512;
            this.picBox3.Location = new System.Drawing.Point(930, 186);
            this.picBox3.Name = "picBox3";
            this.picBox3.Size = new System.Drawing.Size(281, 151);
            this.picBox3.TabIndex = 5;
            this.picBox3.TabStop = false;
            // 
            // picBox2
            // 
            this.picBox2.Image = global::projeto1.Properties.Resources.cartao_black__6_;
            this.picBox2.Location = new System.Drawing.Point(527, 186);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(291, 151);
            this.picBox2.TabIndex = 4;
            this.picBox2.TabStop = false;
            // 
            // picBox1
            // 
            this.picBox1.Image = global::projeto1.Properties.Resources.boleto;
            this.picBox1.Location = new System.Drawing.Point(133, 202);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(302, 135);
            this.picBox1.TabIndex = 3;
            this.picBox1.TabStop = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Red;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpar.Location = new System.Drawing.Point(60, 694);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(173, 43);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "VOLTAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(1191, 694);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 43);
            this.button1.TabIndex = 12;
            this.button1.Text = "FINALIZAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmCartaoPixBoleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 773);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.picBox3);
            this.Controls.Add(this.picBox2);
            this.Controls.Add(this.picBox1);
            this.Controls.Add(this.rbPix);
            this.Controls.Add(this.rbBoleto);
            this.Controls.Add(this.rbCartao);
            this.Name = "frmCartaoPixBoleto";
            this.Text = "PAGAMENTOS";
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbCartao;
        private System.Windows.Forms.RadioButton rbBoleto;
        private System.Windows.Forms.RadioButton rbPix;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.PictureBox picBox2;
        private System.Windows.Forms.PictureBox picBox3;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button button1;
    }
}