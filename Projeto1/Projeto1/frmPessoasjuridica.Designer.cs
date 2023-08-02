
namespace projeto1
{
    partial class frmPessoasjuridica
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
            this.lblCnpj = new System.Windows.Forms.Label();
            this.lblRazãosocial = new System.Windows.Forms.Label();
            this.lblNomefantasia = new System.Windows.Forms.Label();
            this.lblTipopessoajurídica = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblNaturalidade = new System.Windows.Forms.Label();
            this.lblUf = new System.Windows.Forms.Label();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtRazão = new System.Windows.Forms.TextBox();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPessoa = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnVoltar1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnpj.Location = new System.Drawing.Point(130, 41);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(68, 24);
            this.lblCnpj.TabIndex = 0;
            this.lblCnpj.Text = "CNPJ:";
            // 
            // lblRazãosocial
            // 
            this.lblRazãosocial.AutoSize = true;
            this.lblRazãosocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazãosocial.Location = new System.Drawing.Point(68, 106);
            this.lblRazãosocial.Name = "lblRazãosocial";
            this.lblRazãosocial.Size = new System.Drawing.Size(137, 24);
            this.lblRazãosocial.TabIndex = 1;
            this.lblRazãosocial.Text = "Razão Social:";
            // 
            // lblNomefantasia
            // 
            this.lblNomefantasia.AutoSize = true;
            this.lblNomefantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomefantasia.Location = new System.Drawing.Point(49, 168);
            this.lblNomefantasia.Name = "lblNomefantasia";
            this.lblNomefantasia.Size = new System.Drawing.Size(156, 24);
            this.lblNomefantasia.TabIndex = 2;
            this.lblNomefantasia.Text = "Nome Fantasia:";
            // 
            // lblTipopessoajurídica
            // 
            this.lblTipopessoajurídica.AutoSize = true;
            this.lblTipopessoajurídica.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipopessoajurídica.Location = new System.Drawing.Point(12, 229);
            this.lblTipopessoajurídica.Name = "lblTipopessoajurídica";
            this.lblTipopessoajurídica.Size = new System.Drawing.Size(211, 24);
            this.lblTipopessoajurídica.TabIndex = 3;
            this.lblTipopessoajurídica.Text = "Tipo Pessoa Jurídica:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(130, 290);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(75, 24);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(346, 427);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(82, 24);
            this.lblCidade.TabIndex = 5;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblNaturalidade
            // 
            this.lblNaturalidade.AutoSize = true;
            this.lblNaturalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaturalidade.Location = new System.Drawing.Point(28, 375);
            this.lblNaturalidade.Name = "lblNaturalidade";
            this.lblNaturalidade.Size = new System.Drawing.Size(90, 18);
            this.lblNaturalidade.TabIndex = 6;
            this.lblNaturalidade.Text = "Naturalidade";
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUf.Location = new System.Drawing.Point(27, 422);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(43, 24);
            this.lblUf.TabIndex = 7;
            this.lblUf.Text = "UF:";
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(223, 46);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(226, 20);
            this.txtCnpj.TabIndex = 8;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(434, 432);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(354, 20);
            this.txtCidade.TabIndex = 10;
            // 
            // txtRazão
            // 
            this.txtRazão.Location = new System.Drawing.Point(223, 111);
            this.txtRazão.Name = "txtRazão";
            this.txtRazão.Size = new System.Drawing.Size(422, 20);
            this.txtRazão.TabIndex = 11;
            // 
            // txtUf
            // 
            this.txtUf.Location = new System.Drawing.Point(76, 427);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(176, 20);
            this.txtUf.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(223, 295);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(279, 20);
            this.txtEmail.TabIndex = 14;
            // 
            // txtPessoa
            // 
            this.txtPessoa.Location = new System.Drawing.Point(223, 229);
            this.txtPessoa.Name = "txtPessoa";
            this.txtPessoa.Size = new System.Drawing.Size(334, 20);
            this.txtPessoa.TabIndex = 15;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(223, 172);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(422, 20);
            this.txtNome.TabIndex = 16;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Red;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCadastrar.Location = new System.Drawing.Point(892, 511);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(172, 48);
            this.btnCadastrar.TabIndex = 17;
            this.btnCadastrar.Text = "CADASTRA-SE";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnVoltar1
            // 
            this.btnVoltar1.BackColor = System.Drawing.Color.Red;
            this.btnVoltar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVoltar1.Location = new System.Drawing.Point(12, 511);
            this.btnVoltar1.Name = "btnVoltar1";
            this.btnVoltar1.Size = new System.Drawing.Size(172, 48);
            this.btnVoltar1.TabIndex = 18;
            this.btnVoltar1.Text = "VOLTAR";
            this.btnVoltar1.UseVisualStyleBackColor = false;
            this.btnVoltar1.Click += new System.EventHandler(this.btnVoltar1_Click);
            // 
            // frmPessoasjuridica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 571);
            this.Controls.Add(this.btnVoltar1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtPessoa);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUf);
            this.Controls.Add(this.txtRazão);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.lblUf);
            this.Controls.Add(this.lblNaturalidade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTipopessoajurídica);
            this.Controls.Add(this.lblNomefantasia);
            this.Controls.Add(this.lblRazãosocial);
            this.Controls.Add(this.lblCnpj);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmPessoasjuridica";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.Label lblRazãosocial;
        private System.Windows.Forms.Label lblNomefantasia;
        private System.Windows.Forms.Label lblTipopessoajurídica;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblNaturalidade;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtRazão;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPessoa;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnVoltar1;
    }
}