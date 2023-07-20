
namespace Projeto1
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
            this.lblSistema = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblForca = new System.Windows.Forms.Label();
            this.lblAmeacas = new System.Windows.Forms.Label();
            this.lblOportunidades = new System.Windows.Forms.Label();
            this.lblFraqueza = new System.Windows.Forms.Label();
            this.lblApi1 = new System.Windows.Forms.Label();
            this.lblVerificar = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.lblDados = new System.Windows.Forms.Label();
            this.lblAnos = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSistema
            // 
            this.lblSistema.AutoSize = true;
            this.lblSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistema.Location = new System.Drawing.Point(21, 22);
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.Size = new System.Drawing.Size(394, 29);
            this.lblSistema.TabIndex = 0;
            this.lblSistema.Text = "Definição do objetivo do sistema";
            this.lblSistema.Click += new System.EventHandler(this.lblSistema_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(393, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(22, 415);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(394, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Definição do objetivo do sistema";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(187, 239);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(440, 21);
            this.panel2.TabIndex = 2;
            // 
            // lblForca
            // 
            this.lblForca.AutoSize = true;
            this.lblForca.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblForca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForca.Location = new System.Drawing.Point(126, 92);
            this.lblForca.Name = "lblForca";
            this.lblForca.Size = new System.Drawing.Size(43, 15);
            this.lblForca.TabIndex = 3;
            this.lblForca.Text = "Força";
            // 
            // lblAmeacas
            // 
            this.lblAmeacas.AutoSize = true;
            this.lblAmeacas.BackColor = System.Drawing.Color.Transparent;
            this.lblAmeacas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmeacas.Location = new System.Drawing.Point(497, 277);
            this.lblAmeacas.Name = "lblAmeacas";
            this.lblAmeacas.Size = new System.Drawing.Size(65, 15);
            this.lblAmeacas.TabIndex = 4;
            this.lblAmeacas.Text = "Ameaças";
            // 
            // lblOportunidades
            // 
            this.lblOportunidades.AutoSize = true;
            this.lblOportunidades.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblOportunidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOportunidades.Location = new System.Drawing.Point(97, 277);
            this.lblOportunidades.Name = "lblOportunidades";
            this.lblOportunidades.Size = new System.Drawing.Size(101, 15);
            this.lblOportunidades.TabIndex = 5;
            this.lblOportunidades.Text = "Oportunidades";
            // 
            // lblFraqueza
            // 
            this.lblFraqueza.AutoSize = true;
            this.lblFraqueza.BackColor = System.Drawing.Color.Transparent;
            this.lblFraqueza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFraqueza.Location = new System.Drawing.Point(479, 77);
            this.lblFraqueza.Name = "lblFraqueza";
            this.lblFraqueza.Size = new System.Drawing.Size(74, 15);
            this.lblFraqueza.TabIndex = 6;
            this.lblFraqueza.Text = "Fraquezas";
            // 
            // lblApi1
            // 
            this.lblApi1.AutoSize = true;
            this.lblApi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApi1.Location = new System.Drawing.Point(895, 22);
            this.lblApi1.Name = "lblApi1";
            this.lblApi1.Size = new System.Drawing.Size(141, 25);
            this.lblApi1.TabIndex = 7;
            this.lblApi1.Text = "Lista de APIS";
            // 
            // lblVerificar
            // 
            this.lblVerificar.AutoSize = true;
            this.lblVerificar.Location = new System.Drawing.Point(897, 537);
            this.lblVerificar.Name = "lblVerificar";
            this.lblVerificar.Size = new System.Drawing.Size(35, 13);
            this.lblVerificar.TabIndex = 8;
            this.lblVerificar.Text = "label1";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(850, 401);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(129, 23);
            this.btn1.TabIndex = 10;
            this.btn1.Text = "Resultado";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Location = new System.Drawing.Point(815, 247);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(194, 13);
            this.lblDados.TabIndex = 14;
            this.lblDados.Text = "A compra de dados é para investimento";
            // 
            // lblAnos
            // 
            this.lblAnos.AutoSize = true;
            this.lblAnos.Location = new System.Drawing.Point(832, 320);
            this.lblAnos.Name = "lblAnos";
            this.lblAnos.Size = new System.Drawing.Size(153, 13);
            this.lblAnos.TabIndex = 15;
            this.lblAnos.Text = "você possui de 18 a 70 anos ?";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(869, 271);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 17;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(869, 355);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 19;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 703);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lblAnos);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lblVerificar);
            this.Controls.Add(this.lblApi1);
            this.Controls.Add(this.lblFraqueza);
            this.Controls.Add(this.lblOportunidades);
            this.Controls.Add(this.lblAmeacas);
            this.Controls.Add(this.lblForca);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSistema);
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.lblApi);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSistema;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblForca;
        private System.Windows.Forms.Label lblAmeacas;
        private System.Windows.Forms.Label lblOportunidades;
        private System.Windows.Forms.Label lblFraqueza;
        private System.Windows.Forms.Label lblApi1;
        private System.Windows.Forms.Label lblVerificar;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.Label lblAnos;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
    }
}

