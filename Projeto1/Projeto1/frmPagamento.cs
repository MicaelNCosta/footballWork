using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using projeto1.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using MySql.Data.MySqlClient;

namespace projeto1
{
    public partial class frmPagamento : Form
    {
        int usuario_id;
        public frmPagamento(int usuario_id)
        {
            this.usuario_id = usuario_id;
            InitializeComponent();
            using (MyDbContext db = new MyDbContext())
            {
                string query = "SELECT * FROM pagamentos WHERE  usuario_id = @pusuario_id AND YEAR(data_pagamento) = YEAR(CURRENT_DATE) AND MONTH(data_pagamento) = MONTH(CURRENT_DATE) LIMIT 1;";

                var paramenters2 = new[]
                {
                    new MySqlParameter("@pusuario_id", this.usuario_id)
                };


                Pagamento pagamento = db.Database.SqlQuery<Pagamento>(query, paramenters2).SingleOrDefault();
                if (pagamento != null)
                {
                    MessageBox.Show("Você ja efetouo o pagamento ");
                    Form frmPlanos = new frmPlanos();
                    frmPlanos.Show();
                }
            } 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtTitular.Text == "")
            {
                txtTitular.Focus();


                MessageBox.Show("digite o nome do titular do cartão");
            }

        }     
        private void rbCpf_CheckedChanged(object sender, EventArgs e)
        {
            lblCpf.Visible = true;
            lblCnpj.Visible = false;



            mskCpf.Visible = true;



            mskCnpj.Visible = false;
        }

        private void lblCnpj_Click(object sender, EventArgs e)
        {

        }

        private void rbCnpj_CheckedChanged(object sender, EventArgs e)
        {
            lblCpf.Visible = false;
            lblCnpj.Visible = true;



            mskCnpj.Visible = true;



            mskCpf.Visible = false;
        }

        private void frmPagamento_Load(object sender, EventArgs e)
        {
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnProsseguir_Click(object sender, EventArgs e)
        {
            char[] cleanchar = { '.', '/', '-', ' ' };
            string nome = txtTitular.Text;
            string confrimar = btnProsseguir.Text;            
            string CPF = mskCpf.Text.Trim(cleanchar);
            string CNPJ = mskCnpj.Text.Trim(cleanchar);
            string CVV = mskCvc.Text.Trim(cleanchar);
            string Cartao = mskCartao.Text.Trim();
            string VALIDADE = dtpValidade.Text.Trim();
            string USUARIO = label2.Text;





            if (txtTitular.Text == "")
            {
                txtTitular.Focus();


                MessageBox.Show("digite o nome do titular do cartão");
            }
            else if (rbCpf.Checked && CPF.Length < 11)
            {
                mskCpf.Focus();
                MessageBox.Show("preencha o CPF com 11 caracteres");
                
            }
            else if (rbCnpj.Checked && CNPJ.Length < 14)
            {
                mskCnpj.Focus();
                MessageBox.Show("preencha o CNPJ com 14 caracteres");
                
            }
            else if (CVV.Length < 3)
            {
                mskCvc.Focus();
                MessageBox.Show("quantidade de numero insuficiente", "CVV", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else if (Cartao.Length < 16)
            {
                mskCartao.Focus();
                MessageBox.Show("preencha o numero do cartãp com 16 caracteres");
            }
            else if (mskCartao.Text == " " || mskCnpj.Text == "" || mskCpf.Text == " " || mskCvc.Text == " " || txtTitular.Text == " " || dtpValidade.Text == " " || (!rbCnpj.Checked && !rbCpf.Checked))
            {
                MessageBox.Show("Obrigatorio preencher todos os campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("CPF :" + mskCpf.Text + "\n" +
               "CNPJ :" + mskCnpj.Text + "\n" +
               "CVV :" + mskCvc.Text + "\n" +
               "Data de validade :" + dtpValidade.Text + "\n" +
               "Titular do cartão:" + txtTitular.Text + "\n" +
               "Numero do cartão" + mskCartao.Text);


                Form ligas = new frmligas(true);
                ligas.WindowState = FormWindowState.Maximized;
                ligas.Show();
            }

                                    
            string hoje = DateTime.Now.ToString("yyyy-MM-dd");

            
            using (MyDbContext db = new MyDbContext())
            {
                
                



               string query = @"INSERT INTO pagamentos(cpf_pagamento,cnpj_pagamento,numero_cartao,data_validade,cvv,nome_titular,usuario_id,data_pagamento) 
                                        VALUES (@pcpf_pagamento, @pcnpj_pagamento, @pnumero_cartao, @pdata_validade, @pcvv,@pnome_titular,@pusuario_id,@pdata_pagamento );
                                        SELECT LAST_INSERT_ID();";  
                var paramenters = new[]
                {
                    
                    new MySqlParameter("@pcpf_pagamento", CPF),
                    new MySqlParameter("@pcnpj_pagamento",CNPJ),
                    new MySqlParameter("@Pnumero_cartao",Cartao),                    
                    new MySqlParameter("@pdata_validade",VALIDADE),
                    new MySqlParameter("@pcvv",CVV),
                    new MySqlParameter("@pnome_titular",nome),
                    new MySqlParameter("@pusuario_id", this.usuario_id),
                    new MySqlParameter("@pdata_pagamento",hoje)
                };

                int newUserId = db.Database.SqlQuery<int>(query, paramenters).Single();
                

                

            }
       

            this.Hide();
        }

        private void mskCvc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //string email = mskCvc.Text;
            string CVV = mskCvc.Text;
            if (CVV.Length < 3)
            {
                mskCvc.Focus();
                MessageBox.Show("quantidade de numero insuficiente", "CVV", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void mskCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            string CPF = mskCpf.Text;  
            if(CPF.Length < 11)
            {
                mskCpf.Focus();
                MessageBox.Show("digite a quantidade certa de caracteres");
                mskCpf.BackColor = Color.Red;
                return;
            }
        }

        private void mskCnpj_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            string cnpj = mskCnpj.Text;
            if (cnpj.Length <14) 

            {
                mskCnpj.Focus();
                MessageBox.Show("digite a quantidade certa de caracteres");
                mskCpf.BackColor = Color.Red;
                return;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rbCnpj.Checked= false;  
            rbCpf.Checked= false;
            mskCvc.Text = "";            
            txtTitular.Text = "";
            mskCartao.Text = "";
            mskCpf.Text = "";
            mskCnpj.Text = "";
            dtpValidade.Text = "";
        }

        

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form planos = new frmPlanos();
            planos.WindowState = FormWindowState.Maximized;
            planos.Show();            
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void gbSelecione_Enter(object sender, EventArgs e)
        {

        }

        private void mskCartao_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            string Cartao = mskCartao.Text;
            if (Cartao.Length < 16)
            {
                mskCartao.Focus();
                MessageBox.Show("preencha o numero do cartão com 16 caracteres");
               


            }
        }

        private void dtpValidade_ValueChanged(object sender, EventArgs e)
        {
            string hoje = DateTime.Now.ToString("yyyy-MM-dd");
        }
    }
}
