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

namespace projeto1
{
    public partial class frmPagamento : Form
    {
        public frmPagamento()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
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
            btnProsseguir.Enabled = false;
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtSenha.Enabled)
            {
                btnProsseguir.Enabled = true;
            }
        }

        private void btnProsseguir_Click(object sender, EventArgs e)
        {
            char[] cleanchar = { '.', '/', '-', ' ' };
            string nome = txtTitular.Text;
            string confrimar = btnProsseguir.Text;
            string senha = txtSenha.Text;
            string  CPF = mskCpf.Text.Trim(cleanchar);
            string CNPJ = mskCnpj.Text.Trim(cleanchar);
            string CVC = mskCvc.Text.Trim(cleanchar);
            string Cartao = mskCartao.Text.Trim();
            if (txtTitular.Text == "")
            {
                txtTitular.Focus();


                MessageBox.Show("digite o nome do titular do cartão");
            }

            if (txtSenha.Text != "jef123")                   
            {
                        txtSenha.Focus();
                        MessageBox.Show("Senha incorreta");
                
            }
            if (txtSenha.Text == "jef123")
            {
                MessageBox.Show("Parabens você concluiu o pagamento , agradecemos a preferencia,atenciosamente footballWork.");
            }
            if (rbCpf.Checked && CPF.Length<11)
                {
                    mskCpf.Focus();
                    MessageBox.Show("preencha o CPF com 11 caracteres");
                    mskCpf.BackColor = Color.Red;
                }
            
            if (rbCnpj.Checked && CNPJ.Length<14)
            {
                mskCnpj.Focus();
                MessageBox.Show("preencha o CNPJ com 14 caracteres");
                mskCnpj.BackColor = Color.Red;
            }

            if (CVC.Length<3)
            { 
                    mskCvc.Focus();
                    MessageBox.Show("preencha CVC com 3 caracteres");
                    mskCvc.BackColor = Color.Red;
                    
            }
            if (Cartao.Length<16)
            {
                mskCartao.Focus();
                MessageBox.Show("preencha o numero do cartãp com 16 caracteres");
                mskCartao.BackColor = Color.Red;
            }
            MessageBox.Show("CPF :" + mskCpf.Text + "\n" +
                "CNPJ :" + mskCnpj.Text +"\n" +
                "CVC :"+ mskCvc.Text +"\n" +
                "Data de validade :" + dtpValidade.Text + "\n" +
                "Titular do cartão:"+ txtTitular.Text + "\n" +
                "Senha:"+txtSenha.Text + "\n" +
                "Numero do cartão"+mskCartao.Text );

            this.Hide();
            Form frmligas = new frmligas();
            frmligas.WindowState = FormWindowState.Maximized;
            frmligas.Show();
            



        }

        private void mskCvc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            string email = mskCvc.Text;
            if ("" != mskCvc.Text) 
            {
                mskCvc.Focus();
                MessageBox.Show("quantidade de numero insuficiente");
                mskCvc.BackColor = Color.Red;
                return;
            }
        }

        private void mskCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            string CPF = mskCpf.Text;  
            if(""== mskCpf.Text)
            {
                mskCpf.Focus();
                MessageBox.Show("digite a quantidade certa de caracteres");
                mskCpf.BackColor = Color.Red;
                return;
            }
        }

        private void mskCnpj_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            string CPF = mskCnpj.Text;
            if (mskCnpj.Text == "") 

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
            txtSenha.Text = "";
            txtTitular.Text = "";
            mskCartao.Text = "";
            mskCpf.Text = "";
            mskCnpj.Text = "";
            dtpValidade.Text = "";
            }

        private void pbOlho1_Click(object sender, EventArgs e)
        {
            if (txtSenha.PasswordChar == '*')
            {
                txtSenha.PasswordChar = '\0'; // Mostrar a senha
                pbOlho1.Image = Image.FromFile(@"..\..\Imagem\olho (2) certo.png");
            }
            else
            {
                txtSenha.PasswordChar = '*'; // Ocultar a senha
                pbOlho1.Image = Image.FromFile(@"..\..\Imagem\olho (3) certo.png");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form frmPlanos = new frmPlanos();
            frmPlanos.Show();
        }
    }
}
