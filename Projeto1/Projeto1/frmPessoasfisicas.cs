using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace projeto1
{
    public partial class frmPessoasfisicas : Form
    {
        public frmPessoasfisicas()
        {
            InitializeComponent();
        }

        private void btnCadastre_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text == "")
              
            
            {
                MessageBox.Show("Obrigatorio prencher tudo");
                return;
            }
            if (txtNome.Text == "Obrigatorio prencher tudo")
            {
                MessageBox.Show("Obrigatorio prencher tudo");
                return;
            }
            if (txtSenha.Text == "")
            {
                MessageBox.Show("Obrigatorio prencher tudo");
                return;
            }
          
            if (txtCpf.Text == "")
            {
                MessageBox.Show("Obrigatorio prencher tudo");
                return;
            }
            if (txtCep.Text == "")
            {
                MessageBox.Show("Obrigatorio prencher tudo");
                return;
            }
            if (txtEndereco.Text == "Obrigatorio prencher tudo")
            {
                MessageBox.Show("Obrigatorio prencher tudo");
                return;
            }
            MessageBox.Show("usuario Cadastrado");


            Form frmPlanos = new frmPlanos();
            frmPlanos.WindowState = FormWindowState.Maximized;
            frmPlanos.Show();


        }


        private void txtEmail_Validated(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            Regex regex = new Regex(@"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$");
            if (!regex.IsMatch(email))
             
            {
                MessageBox.Show("Email inválido");
                txtEmail.BackColor = Color.Red;
            }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form frmLogin = new frmLogin();
            this.Hide();
            
            
        }
    }
}

