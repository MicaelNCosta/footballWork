
namespace projeto1
{
    partial class frmCadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.bntFinalizar = new System.Windows.Forms.Button();
            this.cbLigas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSIM = new System.Windows.Forms.CheckBox();
            this.cbNao = new System.Windows.Forms.CheckBox();
            this.cbSim3 = new System.Windows.Forms.CheckBox();
            this.cbNão3 = new System.Windows.Forms.CheckBox();
            this.cbIni = new System.Windows.Forms.CheckBox();
            this.cbInter = new System.Windows.Forms.CheckBox();
            this.cbAva = new System.Windows.Forms.CheckBox();
            this.cbSim2 = new System.Windows.Forms.CheckBox();
            this.cbNao2 = new System.Windows.Forms.CheckBox();
            this.txtVoce = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formulário ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Trabalha com futebol ?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(495, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(441, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Qual seu nivel de conhecimento em futebol ?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Selecione uma liga :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(464, 22);
            this.label7.TabIndex = 9;
            this.label7.Text = "Pretende usar para venda ou cosumo prorpio ?";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(1209, 576);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // bntFinalizar
            // 
            this.bntFinalizar.Location = new System.Drawing.Point(1305, 576);
            this.bntFinalizar.Name = "bntFinalizar";
            this.bntFinalizar.Size = new System.Drawing.Size(109, 23);
            this.bntFinalizar.TabIndex = 11;
            this.bntFinalizar.Text = "Finalizar formulário";
            this.bntFinalizar.UseVisualStyleBackColor = true;
            this.bntFinalizar.Click += new System.EventHandler(this.bntFinalizar_Click);
            // 
            // cbLigas
            // 
            this.cbLigas.FormattingEnabled = true;
            this.cbLigas.Items.AddRange(new object[] {
            "Liga Espanhola",
            "Liga Francesa",
            "Liga Italiana",
            "Liga Inglesa",
            "Liga Portuguesa",
            ""});
            this.cbLigas.Location = new System.Drawing.Point(32, 167);
            this.cbLigas.Name = "cbLigas";
            this.cbLigas.Size = new System.Drawing.Size(121, 21);
            this.cbLigas.TabIndex = 12;
            this.cbLigas.Text = "Ligas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(628, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Escreva sobre você :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(589, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(310, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Você indicaria o FootbolWork ?";
            // 
            // cbSIM
            // 
            this.cbSIM.AutoSize = true;
            this.cbSIM.Location = new System.Drawing.Point(32, 323);
            this.cbSIM.Name = "cbSIM";
            this.cbSIM.Size = new System.Drawing.Size(45, 17);
            this.cbSIM.TabIndex = 15;
            this.cbSIM.Text = "SIM";
            this.cbSIM.UseVisualStyleBackColor = true;
            // 
            // cbNao
            // 
            this.cbNao.AutoSize = true;
            this.cbNao.Location = new System.Drawing.Point(147, 323);
            this.cbNao.Name = "cbNao";
            this.cbNao.Size = new System.Drawing.Size(49, 17);
            this.cbNao.TabIndex = 16;
            this.cbNao.Text = "NÃO";
            this.cbNao.UseVisualStyleBackColor = true;
            // 
            // cbSim3
            // 
            this.cbSim3.AutoSize = true;
            this.cbSim3.Location = new System.Drawing.Point(593, 323);
            this.cbSim3.Name = "cbSim3";
            this.cbSim3.Size = new System.Drawing.Size(45, 17);
            this.cbSim3.TabIndex = 17;
            this.cbSim3.Text = "SIM";
            this.cbSim3.UseVisualStyleBackColor = true;
            // 
            // cbNão3
            // 
            this.cbNão3.AutoSize = true;
            this.cbNão3.Location = new System.Drawing.Point(664, 323);
            this.cbNão3.Name = "cbNão3";
            this.cbNão3.Size = new System.Drawing.Size(49, 17);
            this.cbNão3.TabIndex = 18;
            this.cbNão3.Text = "NÃO";
            this.cbNão3.UseVisualStyleBackColor = true;
            // 
            // cbIni
            // 
            this.cbIni.AutoSize = true;
            this.cbIni.Location = new System.Drawing.Point(589, 171);
            this.cbIni.Name = "cbIni";
            this.cbIni.Size = new System.Drawing.Size(79, 17);
            this.cbIni.TabIndex = 19;
            this.cbIni.Text = "INICIANTE";
            this.cbIni.UseVisualStyleBackColor = true;
            // 
            // cbInter
            // 
            this.cbInter.AutoSize = true;
            this.cbInter.Location = new System.Drawing.Point(674, 171);
            this.cbInter.Name = "cbInter";
            this.cbInter.Size = new System.Drawing.Size(112, 17);
            this.cbInter.TabIndex = 20;
            this.cbInter.Text = "INTERMEDIARIO";
            this.cbInter.UseVisualStyleBackColor = true;
            // 
            // cbAva
            // 
            this.cbAva.AutoSize = true;
            this.cbAva.Location = new System.Drawing.Point(792, 171);
            this.cbAva.Name = "cbAva";
            this.cbAva.Size = new System.Drawing.Size(85, 17);
            this.cbAva.TabIndex = 21;
            this.cbAva.Text = "AVANÇADO";
            this.cbAva.UseVisualStyleBackColor = true;
            // 
            // cbSim2
            // 
            this.cbSim2.AutoSize = true;
            this.cbSim2.Location = new System.Drawing.Point(32, 481);
            this.cbSim2.Name = "cbSim2";
            this.cbSim2.Size = new System.Drawing.Size(45, 17);
            this.cbSim2.TabIndex = 24;
            this.cbSim2.Text = "SIM";
            this.cbSim2.UseVisualStyleBackColor = true;
            // 
            // cbNao2
            // 
            this.cbNao2.AutoSize = true;
            this.cbNao2.Location = new System.Drawing.Point(147, 481);
            this.cbNao2.Name = "cbNao2";
            this.cbNao2.Size = new System.Drawing.Size(49, 17);
            this.cbNao2.TabIndex = 25;
            this.cbNao2.Text = "NÃO";
            this.cbNao2.UseVisualStyleBackColor = true;
            // 
            // txtVoce
            // 
            this.txtVoce.Location = new System.Drawing.Point(632, 465);
            this.txtVoce.Name = "txtVoce";
            this.txtVoce.Size = new System.Drawing.Size(100, 20);
            this.txtVoce.TabIndex = 26;
            this.txtVoce.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 640);
            this.Controls.Add(this.txtVoce);
            this.Controls.Add(this.cbNao2);
            this.Controls.Add(this.cbSim2);
            this.Controls.Add(this.cbAva);
            this.Controls.Add(this.cbInter);
            this.Controls.Add(this.cbIni);
            this.Controls.Add(this.cbNão3);
            this.Controls.Add(this.cbSim3);
            this.Controls.Add(this.cbNao);
            this.Controls.Add(this.cbSIM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbLigas);
            this.Controls.Add(this.bntFinalizar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "frmCadastro";
            this.Text = "Formulário para usuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button bntFinalizar;
        private System.Windows.Forms.ComboBox cbLigas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbSIM;
        private System.Windows.Forms.CheckBox cbNao;
        private System.Windows.Forms.CheckBox cbSim3;
        private System.Windows.Forms.CheckBox cbNão3;
        private System.Windows.Forms.CheckBox cbIni;
        private System.Windows.Forms.CheckBox cbInter;
        private System.Windows.Forms.CheckBox cbAva;
        private System.Windows.Forms.CheckBox cbSim2;
        private System.Windows.Forms.CheckBox cbNao2;
        private System.Windows.Forms.TextBox txtVoce;
    }
}