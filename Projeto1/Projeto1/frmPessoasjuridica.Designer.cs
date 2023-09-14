
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
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtRazão = new System.Windows.Forms.TextBox();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnVoltar1 = new System.Windows.Forms.Button();
            this.lblCep = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnpj.Location = new System.Drawing.Point(646, 420);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(68, 24);
            this.lblCnpj.TabIndex = 0;
            this.lblCnpj.Text = "CNPJ:";
            // 
            // lblRazãosocial
            // 
            this.lblRazãosocial.AutoSize = true;
            this.lblRazãosocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazãosocial.Location = new System.Drawing.Point(581, 577);
            this.lblRazãosocial.Name = "lblRazãosocial";
            this.lblRazãosocial.Size = new System.Drawing.Size(137, 24);
            this.lblRazãosocial.TabIndex = 1;
            this.lblRazãosocial.Text = "Razão Social:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(642, 524);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(72, 24);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(869, 655);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(82, 24);
            this.lblCidade.TabIndex = 5;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUf.Location = new System.Drawing.Point(598, 656);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(43, 24);
            this.lblUf.TabIndex = 7;
            this.lblUf.Text = "UF:";
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(745, 425);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(324, 20);
            this.txtCnpj.TabIndex = 8;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(977, 655);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(176, 20);
            this.txtCidade.TabIndex = 10;
            // 
            // txtRazão
            // 
            this.txtRazão.Location = new System.Drawing.Point(745, 528);
            this.txtRazão.Name = "txtRazão";
            this.txtRazão.Size = new System.Drawing.Size(324, 20);
            this.txtRazão.TabIndex = 11;
            this.txtRazão.TextChanged += new System.EventHandler(this.txtRazão_TextChanged);
            // 
            // txtUf
            // 
            this.txtUf.Location = new System.Drawing.Point(650, 660);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(139, 20);
            this.txtUf.TabIndex = 12;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(745, 577);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(324, 20);
            this.txtNome.TabIndex = 16;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Red;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCadastrar.Location = new System.Drawing.Point(1390, 753);
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
            this.btnVoltar1.Location = new System.Drawing.Point(617, 753);
            this.btnVoltar1.Name = "btnVoltar1";
            this.btnVoltar1.Size = new System.Drawing.Size(172, 48);
            this.btnVoltar1.TabIndex = 18;
            this.btnVoltar1.Text = "VOLTAR";
            this.btnVoltar1.UseVisualStyleBackColor = false;
            this.btnVoltar1.Click += new System.EventHandler(this.btnVoltar1_Click);
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.Location = new System.Drawing.Point(657, 476);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(57, 24);
            this.lblCep.TabIndex = 20;
            this.lblCep.Text = "CEP:";
            this.lblCep.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(745, 481);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(324, 20);
            this.txtCep.TabIndex = 21;
            this.txtCep.TextChanged += new System.EventHandler(this.txtCep_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(652, 313);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(62, 24);
            this.lblEmail.TabIndex = 22;
            this.lblEmail.Text = "Email:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(648, 368);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(70, 24);
            this.lblSenha.TabIndex = 23;
            this.lblSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(745, 373);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(324, 20);
            this.txtSenha.TabIndex = 24;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(745, 317);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(324, 20);
            this.txtEmail.TabIndex = 25;
            this.txtEmail.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projeto1.Properties.Resources.FUT_PhotoRoom_png_PhotoRoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(441, 127);
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // frmPessoasjuridica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1653, 842);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.btnVoltar1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtUf);
            this.Controls.Add(this.txtRazão);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.lblUf);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblRazãosocial);
            this.Controls.Add(this.lblCnpj);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmPessoasjuridica";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.Label lblRazãosocial;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtRazão;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnVoltar1;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}