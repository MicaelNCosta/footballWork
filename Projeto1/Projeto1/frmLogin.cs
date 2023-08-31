using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using MySql.Data.MySqlClient;
using projeto1.Models;
using System.Data.SqlClient;

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
            Form frmEsqueceuSenhaa = new frmEsqueceuSenha();
            frmEsqueceuSenhaa.WindowState = FormWindowState.Maximized;
            frmEsqueceuSenhaa.Show();


        }

        bool IsValidEmail(string emailLog)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return System.Text.RegularExpressions.Regex.IsMatch(emailLog, pattern);
        }

        private void btnLogin_Click(object sender, EventArgs e, object senha)
        {

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


            private void btnCadastroF_Click(object sender, EventArgs e)
            {
                Form frmPessoasFisicas = new frmPessoasfisicas();
                frmPessoasFisicas.WindowState = FormWindowState.Maximized;
                frmPessoasFisicas.Show();
            }

            private void btnCadastroJ_Click(object sender, EventArgs e)
            {
                Form frmPessoasJuridicas = new frmPessoasjuridica();
                frmPessoasJuridicas.WindowState = FormWindowState.Maximized;
                frmPessoasJuridicas.Show();
            }

            private void btnForm_Click(object sender, EventArgs e)
            {
                Form frmFormulario = new frmCadastro();
                frmFormulario.WindowState = FormWindowState.Maximized;
                frmFormulario.Show();

                btnCadastroF.Visible = true;
                btnCadastroJ.Visible = true;
            }

            private void pbSenhas_Click(object sender, EventArgs e)
            {
                if (txtSenha.PasswordChar == '*')
                {
                    txtSenha.PasswordChar = '\0'; // Mostrar a senha
                    pbSenhas.Image = Image.FromFile(@"..\..\Imagem\olho (3) certo.png");
                }
                else
                {
                    txtSenha.PasswordChar = '*'; // Ocultar a senha
                    pbSenhas.Image = Image.FromFile(@"..\..\Imagem\olho (2) certo.png");
                }
            }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string email = txtEmail.Text;
            string senha = txtSenha.Text;

            using (MyDbContext db = new MyDbContext())
            {
                string query = @"SELECT COUNT(*) FROM usuarios WHERE email = @pemail AND senha = @psenha;";
                var parameters = new[]
                {
                     new MySqlParameter("@pemail", email),
                     new MySqlParameter("@psenha", senha)
                };

                int resul = db.Database.SqlQuery<int>(query, parameters).SingleOrDefault();

                if (resul > 0)
                {
                    Form frmTelaInicial1 = new frmTelaInicial1(resul);
                    frmTelaInicial1.WindowState = FormWindowState.Maximized;
                    frmTelaInicial1.Show();
                }
                else
                {
                    MessageBox.Show("EMAIL OU SENHA INCORRETOS, TENTE NOVAMENTE", "Erro de Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

