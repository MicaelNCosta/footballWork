
namespace projeto1
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label4 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEsqueceuSenha = new System.Windows.Forms.Button();
            this.btnCadastroF = new System.Windows.Forms.Button();
            this.btnCadastroJ = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pbSenhas = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSenhas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(76, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 55);
            this.label4.TabIndex = 5;
            this.label4.Text = "SENHA";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(69, 299);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(599, 40);
            this.txtSenha.TabIndex = 6;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(69, 147);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(599, 40);
            this.txtEmail.TabIndex = 7;            
            this.txtEmail.Validated += new System.EventHandler(this.txtEmail_Validated);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Black;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(69, 425);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(642, 56);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(34, 675);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(594, 33);
            this.label5.TabIndex = 9;
            this.label5.Text = "PRIMEIRO ACESSO? CADASTRE-SE AQUI";
            // 
            // btnEsqueceuSenha
            // 
            this.btnEsqueceuSenha.BackColor = System.Drawing.Color.White;
            this.btnEsqueceuSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsqueceuSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEsqueceuSenha.ForeColor = System.Drawing.Color.Black;
            this.btnEsqueceuSenha.Location = new System.Drawing.Point(86, 506);
            this.btnEsqueceuSenha.Name = "btnEsqueceuSenha";
            this.btnEsqueceuSenha.Size = new System.Drawing.Size(320, 34);
            this.btnEsqueceuSenha.TabIndex = 10;
            this.btnEsqueceuSenha.Text = "ESQUECEU A SENHA?";
            this.btnEsqueceuSenha.UseVisualStyleBackColor = false;
            this.btnEsqueceuSenha.Click += new System.EventHandler(this.btnEsqueceuSenha_Click);
            // 
            // btnCadastroF
            // 
            this.btnCadastroF.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastroF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroF.ForeColor = System.Drawing.Color.Black;
            this.btnCadastroF.Location = new System.Drawing.Point(1074, 841);
            this.btnCadastroF.Name = "btnCadastroF";
            this.btnCadastroF.Size = new System.Drawing.Size(366, 63);
            this.btnCadastroF.TabIndex = 11;
            this.btnCadastroF.Text = "PESSOA FISICA";
            this.btnCadastroF.UseVisualStyleBackColor = false;
            this.btnCadastroF.Click += new System.EventHandler(this.btnCadastroF_Click);
            // 
            // btnCadastroJ
            // 
            this.btnCadastroJ.BackColor = System.Drawing.Color.White;
            this.btnCadastroJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroJ.ForeColor = System.Drawing.Color.Black;
            this.btnCadastroJ.Location = new System.Drawing.Point(1446, 841);
            this.btnCadastroJ.Name = "btnCadastroJ";
            this.btnCadastroJ.Size = new System.Drawing.Size(337, 63);
            this.btnCadastroJ.TabIndex = 16;
            this.btnCadastroJ.Text = "PESSOA JURIDICA";
            this.btnCadastroJ.UseVisualStyleBackColor = false;
            this.btnCadastroJ.Click += new System.EventHandler(this.btnCadastroJ_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.pbSenhas);
            this.panel2.Controls.Add(this.btnEsqueceuSenha);
            this.panel2.Controls.Add(this.txtSenha);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(1034, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(788, 853);
            this.panel2.TabIndex = 22;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(76, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 55);
            this.label3.TabIndex = 23;
            this.label3.Text = "EMAIL";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pbSenhas
            // 
            this.pbSenhas.BackColor = System.Drawing.Color.Transparent;
            this.pbSenhas.Image = global::projeto1.Properties.Resources.Design_sem_nome_PhotoRoom_png_PhotoRoom;
            this.pbSenhas.Location = new System.Drawing.Point(674, 299);
            this.pbSenhas.Name = "pbSenhas";
            this.pbSenhas.Size = new System.Drawing.Size(41, 44);
            this.pbSenhas.TabIndex = 13;
            this.pbSenhas.TabStop = false;
            this.pbSenhas.Click += new System.EventHandler(this.pbSenhas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projeto1.Properties.Resources.FUT;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(550, 110);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::projeto1.Properties.Resources.seja_bem_vindo_para_culto__Post_para_Instagram___1_;
            this.pictureBox2.Location = new System.Drawing.Point(-45, -22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(976, 818);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCadastroJ);
            this.Controls.Add(this.btnCadastroF);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Name = "frmLogin";
            this.Text = resources.GetString("$this.Text");
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSenhas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEsqueceuSenha;
        private System.Windows.Forms.Button btnCadastroF;
        private System.Windows.Forms.PictureBox pbSenhas;
        private System.Windows.Forms.Button btnCadastroJ;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}