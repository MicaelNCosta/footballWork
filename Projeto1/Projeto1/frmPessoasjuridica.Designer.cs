
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblUf = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtRazão = new System.Windows.Forms.TextBox();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnVoltar1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mskCnpj = new System.Windows.Forms.MaskedTextBox();
            this.mskCep = new System.Windows.Forms.MaskedTextBox();
            this.pbSenha = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSenha)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnpj.Location = new System.Drawing.Point(131, 237);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(68, 24);
            this.lblCnpj.TabIndex = 0;
            this.lblCnpj.Text = "CNPJ:";
            // 
            // lblRazãosocial
            // 
            this.lblRazãosocial.AutoSize = true;
            this.lblRazãosocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazãosocial.Location = new System.Drawing.Point(62, 186);
            this.lblRazãosocial.Name = "lblRazãosocial";
            this.lblRazãosocial.Size = new System.Drawing.Size(137, 24);
            this.lblRazãosocial.TabIndex = 1;
            this.lblRazãosocial.Text = "Razão Social:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(127, 135);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(72, 24);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(113, 337);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(82, 24);
            this.lblCidade.TabIndex = 5;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUf.Location = new System.Drawing.Point(156, 384);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(43, 24);
            this.lblUf.TabIndex = 7;
            this.lblUf.Text = "UF:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(243, 342);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(167, 20);
            this.txtCidade.TabIndex = 10;
            // 
            // txtRazão
            // 
            this.txtRazão.Location = new System.Drawing.Point(243, 135);
            this.txtRazão.Name = "txtRazão";
            this.txtRazão.Size = new System.Drawing.Size(263, 20);
            this.txtRazão.TabIndex = 11;
            this.txtRazão.TextChanged += new System.EventHandler(this.txtRazão_TextChanged);
            // 
            // txtUf
            // 
            this.txtUf.Location = new System.Drawing.Point(243, 384);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(53, 20);
            this.txtUf.TabIndex = 12;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(243, 186);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(263, 20);
            this.txtNome.TabIndex = 16;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Red;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCadastrar.Location = new System.Drawing.Point(757, 460);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(172, 48);
            this.btnCadastrar.TabIndex = 17;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnVoltar1
            // 
            this.btnVoltar1.BackColor = System.Drawing.Color.Red;
            this.btnVoltar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVoltar1.Location = new System.Drawing.Point(57, 460);
            this.btnVoltar1.Name = "btnVoltar1";
            this.btnVoltar1.Size = new System.Drawing.Size(172, 48);
            this.btnVoltar1.TabIndex = 18;
            this.btnVoltar1.Text = "VOLTAR";
            this.btnVoltar1.UseVisualStyleBackColor = false;
            this.btnVoltar1.Click += new System.EventHandler(this.btnVoltar1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::projeto1.Properties.Resources.Chart_Talk_logo_template_Financial_growth_talk_logo__removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(521, -61);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(507, 654);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.Location = new System.Drawing.Point(142, 291);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(57, 24);
            this.lblCep.TabIndex = 20;
            this.lblCep.Text = "CEP:";
            this.lblCep.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(127, 35);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(68, 24);
            this.lblEmail.TabIndex = 22;
            this.lblEmail.Text = "Email:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(119, 80);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(76, 24);
            this.lblSenha.TabIndex = 23;
            this.lblSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(243, 80);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(167, 20);
            this.txtSenha.TabIndex = 24;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(243, 35);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(263, 20);
            this.txtEmail.TabIndex = 25;
            this.txtEmail.Validated += new System.EventHandler(this.txtEmail_Validated);
            // 
            // mskCnpj
            // 
            this.mskCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCnpj.Location = new System.Drawing.Point(243, 235);
            this.mskCnpj.Mask = "00.000.000/0000-00";
            this.mskCnpj.Name = "mskCnpj";
            this.mskCnpj.Size = new System.Drawing.Size(167, 26);
            this.mskCnpj.TabIndex = 26;
            // 
            // mskCep
            // 
            this.mskCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCep.Location = new System.Drawing.Point(243, 291);
            this.mskCep.Mask = "00000-000";
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(167, 26);
            this.mskCep.TabIndex = 27;
            // 
            // pbSenha
            // 
            this.pbSenha.Image = global::projeto1.Properties.Resources.olho__2__certo;
            this.pbSenha.Location = new System.Drawing.Point(428, 80);
            this.pbSenha.Name = "pbSenha";
            this.pbSenha.Size = new System.Drawing.Size(30, 30);
            this.pbSenha.TabIndex = 28;
            this.pbSenha.TabStop = false;
            this.pbSenha.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmPessoasjuridica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 571);
            this.Controls.Add(this.pbSenha);
            this.Controls.Add(this.mskCep);
            this.Controls.Add(this.mskCnpj);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.btnVoltar1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtUf);
            this.Controls.Add(this.txtRazão);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblUf);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblRazãosocial);
            this.Controls.Add(this.lblCnpj);
            this.Controls.Add(this.pictureBox2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmPessoasjuridica";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSenha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.Label lblRazãosocial;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtRazão;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnVoltar1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mskCnpj;
        private System.Windows.Forms.MaskedTextBox mskCep;
        private System.Windows.Forms.PictureBox pbSenha;
    }
}