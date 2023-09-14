using MySql.Data.MySqlClient;
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
    public partial class frmEsqueceuSenha : Form
    {
        public frmEsqueceuSenha()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formVoltar = new frmLogin();
            formVoltar.WindowState = FormWindowState.Maximized;
            formVoltar.Show();            
            this.Hide();

        }

        bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return System.Text.RegularExpressions.Regex.IsMatch(email, pattern);
        }

        private void btnRedefinir_Click(object sender, EventArgs e)
        {
            string emailrec = txtEmailRecapSenha.Text;
            string senhanova = txtSenhaNova.Text;
            string confirmsenha = txtSenhaConfirmeSenh.Text;

            using (MyDbContext db = new MyDbContext())
            {
                string query = @"UPDATE usuarios SET senha = @psenhanova WHERE email = @pemail";
                var parameters = new[]
                {
                     new MySqlParameter("@pemail", emailrec),
                     new MySqlParameter("@psenhanova", senhanova),
                    
                };

                int nRowAfetted = db.Database.ExecuteSqlCommand(query, parameters);

                if(senhanova == confirmsenha)
                {
                    Form formVoltar = new frmLogin();
                    formVoltar.WindowState = FormWindowState.Maximized;
                    formVoltar.Show();
                    
                }
                else
                {
                    MessageBox.Show("A SENHA NÃO SÃO IGUAIS, POR FAVOR VERIFIQUE-AS", "Erro de Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                


            }
            
            this.Hide();
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pbSenhas_Click(object sender, EventArgs e)
        {
            if (txtSenhaNova.PasswordChar == '*')
            {
                txtSenhaNova.PasswordChar = '\0'; // Mostrar a senha
                txtSenhaConfirmeSenh.PasswordChar = '\0'; // Mostrar a senha
                pbSenhas.Image = Image.FromFile(@"..\..\Resources\Design sem nome-PhotoRoom.png-PhotoRoom.png");
            }
            else
            {
                txtSenhaNova.PasswordChar = '*'; // Ocultar a senha
                txtSenhaConfirmeSenh.PasswordChar = '*'; // Ocultar a senha
                pbSenhas.Image = Image.FromFile(@"..\..\Resources\Design sem nome (1)-PhotoRoom.png-PhotoRoom1.png");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
