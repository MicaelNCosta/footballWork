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
            string senhaatual = txtSenhaAtual.Text;

            using (MyDbContext db = new MyDbContext())
            {
                string query = @"UPDATE usuarios SET senha = @psenhanova WHERE email = @pemail AND senha = @psenhaatual;";
                var parameters = new[]
                {
                     new MySqlParameter("@pemail", emailrec),
                     new MySqlParameter("@psenhanova", senhanova),
                     new MySqlParameter("@psenhaatual", senhaatual)
                };

                int nRowAfetted = db.Database.ExecuteSqlCommand(query, parameters);


                Form formVoltar = new frmLogin();
                this.Hide();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
