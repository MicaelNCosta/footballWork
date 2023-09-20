namespace projeto1
{
    partial class frmPagamento
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
            this.mskCnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.mskCvc = new System.Windows.Forms.MaskedTextBox();
            this.dtpValidade = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnProsseguir = new System.Windows.Forms.Button();
            this.gbSelecione = new System.Windows.Forms.GroupBox();
            this.rbCnpj = new System.Windows.Forms.RadioButton();
            this.rbCpf = new System.Windows.Forms.RadioButton();
            this.lblCpf = new System.Windows.Forms.Label();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.mskCartao = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gbSelecione.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // mskCnpj
            // 
            this.mskCnpj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mskCnpj.Location = new System.Drawing.Point(1012, 311);
            this.mskCnpj.Mask = "00.000.000/0000-00";
            this.mskCnpj.Name = "mskCnpj";
            this.mskCnpj.Size = new System.Drawing.Size(124, 20);
            this.mskCnpj.TabIndex = 0;
            this.mskCnpj.Visible = false;
            this.mskCnpj.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskCnpj_MaskInputRejected);
            // 
            // txtTitular
            // 
            this.txtTitular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtTitular.Location = new System.Drawing.Point(1012, 376);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(210, 20);
            this.txtTitular.TabIndex = 1;
            this.txtTitular.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // mskCvc
            // 
            this.mskCvc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCvc.Location = new System.Drawing.Point(1012, 512);
            this.mskCvc.Mask = "0/0/0";
            this.mskCvc.Name = "mskCvc";
            this.mskCvc.Size = new System.Drawing.Size(51, 29);
            this.mskCvc.TabIndex = 2;
            this.mskCvc.UseWaitCursor = true;
            this.mskCvc.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskCvc_MaskInputRejected);
            // 
            // dtpValidade
            // 
            this.dtpValidade.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.dtpValidade.CustomFormat = "MM/yy";
            this.dtpValidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpValidade.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpValidade.Location = new System.Drawing.Point(1012, 580);
            this.dtpValidade.Name = "dtpValidade";
            this.dtpValidade.Size = new System.Drawing.Size(93, 29);
            this.dtpValidade.TabIndex = 3;
            this.dtpValidade.UseWaitCursor = true;
            this.dtpValidade.ValueChanged += new System.EventHandler(this.dtpValidade_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(590, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome do  titular do cartão";
            this.label1.UseWaitCursor = true;
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnpj.Location = new System.Drawing.Point(590, 311);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(80, 29);
            this.lblCnpj.TabIndex = 6;
            this.lblCnpj.Text = "CNPJ";
            this.lblCnpj.Visible = false;
            this.lblCnpj.Click += new System.EventHandler(this.lblCnpj_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(590, 580);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data de Validade";
            this.label3.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(590, 511);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "CVV";
            this.label4.UseWaitCursor = true;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(590, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Numero do Cartão";
            this.label5.UseWaitCursor = true;
            // 
            // btnProsseguir
            // 
            this.btnProsseguir.BackColor = System.Drawing.Color.Red;
            this.btnProsseguir.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnProsseguir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProsseguir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProsseguir.Location = new System.Drawing.Point(1511, 912);
            this.btnProsseguir.Name = "btnProsseguir";
            this.btnProsseguir.Size = new System.Drawing.Size(276, 46);
            this.btnProsseguir.TabIndex = 12;
            this.btnProsseguir.Text = "Efetuar pagamento";
            this.btnProsseguir.UseVisualStyleBackColor = false;
            this.btnProsseguir.UseWaitCursor = true;
            this.btnProsseguir.Click += new System.EventHandler(this.btnProsseguir_Click);
            // 
            // gbSelecione
            // 
            this.gbSelecione.Controls.Add(this.rbCnpj);
            this.gbSelecione.Controls.Add(this.rbCpf);
            this.gbSelecione.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.gbSelecione.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSelecione.ForeColor = System.Drawing.Color.Black;
            this.gbSelecione.Location = new System.Drawing.Point(578, 220);
            this.gbSelecione.Name = "gbSelecione";
            this.gbSelecione.Size = new System.Drawing.Size(284, 61);
            this.gbSelecione.TabIndex = 13;
            this.gbSelecione.TabStop = false;
            this.gbSelecione.Text = "Selecione";
            this.gbSelecione.Enter += new System.EventHandler(this.gbSelecione_Enter);
            // 
            // rbCnpj
            // 
            this.rbCnpj.AutoSize = true;
            this.rbCnpj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCnpj.ForeColor = System.Drawing.Color.Black;
            this.rbCnpj.Location = new System.Drawing.Point(141, 22);
            this.rbCnpj.Name = "rbCnpj";
            this.rbCnpj.Size = new System.Drawing.Size(98, 33);
            this.rbCnpj.TabIndex = 1;
            this.rbCnpj.TabStop = true;
            this.rbCnpj.Text = "CNPJ";
            this.rbCnpj.UseVisualStyleBackColor = true;
            this.rbCnpj.CheckedChanged += new System.EventHandler(this.rbCnpj_CheckedChanged);
            // 
            // rbCpf
            // 
            this.rbCpf.AutoSize = true;
            this.rbCpf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCpf.ForeColor = System.Drawing.Color.Black;
            this.rbCpf.Location = new System.Drawing.Point(17, 22);
            this.rbCpf.Name = "rbCpf";
            this.rbCpf.Size = new System.Drawing.Size(82, 33);
            this.rbCpf.TabIndex = 0;
            this.rbCpf.TabStop = true;
            this.rbCpf.Text = "CPF";
            this.rbCpf.UseVisualStyleBackColor = true;
            this.rbCpf.CheckedChanged += new System.EventHandler(this.rbCpf_CheckedChanged);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(589, 311);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(64, 29);
            this.lblCpf.TabIndex = 14;
            this.lblCpf.Text = "CPF";
            this.lblCpf.Visible = false;
            // 
            // mskCpf
            // 
            this.mskCpf.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.mskCpf.Location = new System.Drawing.Point(1012, 311);
            this.mskCpf.Mask = "000.000.000-00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(91, 20);
            this.mskCpf.TabIndex = 15;
            this.mskCpf.UseWaitCursor = true;
            this.mskCpf.Visible = false;
            this.mskCpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskCpf_MaskInputRejected);
            // 
            // mskCartao
            // 
            this.mskCartao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mskCartao.Location = new System.Drawing.Point(1012, 441);
            this.mskCartao.Mask = "0000/0000/0000/0000";
            this.mskCartao.Name = "mskCartao";
            this.mskCartao.Size = new System.Drawing.Size(186, 20);
            this.mskCartao.TabIndex = 16;
            this.mskCartao.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskCartao_MaskInputRejected);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.panel1.Location = new System.Drawing.Point(452, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 1074);
            this.panel1.TabIndex = 17;
            this.panel1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(557, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 40);
            this.label2.TabIndex = 18;
            this.label2.Text = "Preencha seus dados";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(557, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(705, 39);
            this.label7.TabIndex = 19;
            this.label7.Text = "Parabéns você selecionou nosso plano premiun";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1250, 596);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 20;
            this.label8.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(1187, 912);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 46);
            this.button1.TabIndex = 21;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVoltar.Location = new System.Drawing.Point(541, 912);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(276, 46);
            this.btnVoltar.TabIndex = 23;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.UseWaitCursor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.panel2.Location = new System.Drawing.Point(488, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 1074);
            this.panel2.TabIndex = 18;
            this.panel2.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projeto1.Properties.Resources.Meios_de_pagamento_analise_financeira_fintechs__1__removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(12, 265);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(419, 594);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::projeto1.Properties.Resources.FUT_PhotoRoom_png_PhotoRoom;
            this.pictureBox2.Location = new System.Drawing.Point(1431, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(447, 117);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.UseWaitCursor = true;
            // 
            // frmPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mskCartao);
            this.Controls.Add(this.mskCpf);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.gbSelecione);
            this.Controls.Add(this.btnProsseguir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCnpj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpValidade);
            this.Controls.Add(this.mskCvc);
            this.Controls.Add(this.txtTitular);
            this.Controls.Add(this.mskCnpj);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "frmPagamento";
            this.Text = "Pagamento";
            this.Load += new System.EventHandler(this.frmPagamento_Load);
            this.gbSelecione.ResumeLayout(false);
            this.gbSelecione.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskCnpj;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.MaskedTextBox mskCvc;
        private System.Windows.Forms.DateTimePicker dtpValidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnProsseguir;
        private System.Windows.Forms.GroupBox gbSelecione;
        private System.Windows.Forms.RadioButton rbCnpj;
        private System.Windows.Forms.RadioButton rbCpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.MaskedTextBox mskCartao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVoltar;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
    }
}