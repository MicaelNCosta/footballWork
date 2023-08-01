using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEsqueceuSenha_Click(object sender, EventArgs e)
        {
             Form formEsqueceuSenha = new frmEsqueceuSenha();
             formEsqueceuSenha.Show();
        }

        bool IsValidEmail(string emailLog)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return System.Text.RegularExpressions.Regex.IsMatch(emailLog, pattern);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string senhacorrect = txtSenha.Text;
            int n = 1234;

            if (int.TryParse(senhacorrect, out int login) && login == n)
            {
                MessageBox.Show("Obrigado por Se juntar a Nós ", " BEM VINDO ", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("SENHA INCORRETA,POR FAVOR TENTE NOVAMENTE");
            }
         }


        private void txtEmail_Validated(object sender, EventArgs e)
        {
            string email = txtEmail.Text;

            if (IsValidEmail(email))
            {
                // MessageBox.Show("Um Email foi enviado para o destinatario para fazer a alterção de senha");
            }
            else
            {
                MessageBox.Show("Endereço de e-mail inválido!");
            }
        }

        private void pbSenhas_Click_1(object sender, EventArgs e)
        {
            if (txtSenha.PasswordChar == '*')
            {
                txtSenha.PasswordChar = '\0'; // Mostrar a senha
                pbSenhas.Image = Image.FromFile(@"..\..\ImagensBrian\MostrarSenha.png");
            }
            else
            {
                txtSenha.PasswordChar = '*'; // Ocultar a senha
                pbSenhas.Image = Image.FromFile(@"..\..\ImagensBrian\Ocultarsenha.png");
            }
        }

    }
}
