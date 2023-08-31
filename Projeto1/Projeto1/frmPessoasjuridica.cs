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
using projeto1.Models2;

namespace projeto1
{
    public partial class frmPessoasjuridica : Form
    {
        int formulario_id; 
        public frmPessoasjuridica(int formulario_id)
        {
            this.formulario_id = formulario_id; 
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string Cnpj = txtCnpj.Text;
            string Cep = txtCep.Text;
            string Razao_social = txtRazão.Text;
            string Nome = txtNome.Text;
            string Uf = txtUf.Text;
            string Cidade = txtCidade.Text;
            string Email = txtEmail.Text;
            string Senha = txtSenha.Text;




            if (txtCnpj.Text == "")

            {
                MessageBox.Show(" Obrigatorio preencher tudo ");
                return;
            }
            if (txtRazão.Text == "")
            {
                MessageBox.Show(" Obrigatorio preencher tudo ");
                return;
            }
            if (txtNome.Text == "")
            {
                MessageBox.Show(" Obrigatorio preencher tudo ");
                return;
            }
            if (txtCep.Text == "")
            {
                MessageBox.Show(" Obrigatorio preencher tudo  ");
                return;
            }
            if (txtUf.Text == "")
            {
                MessageBox.Show("Obrigatorio preencher tudo ");
                return;
            }
            if (txtCidade.Text == "")
            {
                MessageBox.Show("Obrigatorio preencher tudo");
                return;
            }
            if ( txtEmail.Text == "")
            {
                MessageBox.Show("Obrigatorio preencher tudo ");
                return;
            }
            if (txtSenha.Text == "")
            {
                MessageBox.Show("Obrigatorio preencher tudo ");
                return;
            
        }
        MessageBox.Show(" Usuario cadrastrado");



            using (MyDbContext db = new MyDbContext())

            {
                string query = @"INSERT INTO usuarios(nome , email, senha, formulario_id) VALUES (@pnome, @pemail, @psenha, @pformulario_id); SELECT LAST_INSERT_ID();";

                var parameters = new[]

                {

                    new MySqlParameter("@pnome",Nome),
                    new MySqlParameter("@pemail",Email),
                    new MySqlParameter("@psenha",Senha),
                    new MySqlParameter("@pformulario_id", this.formulario_id),

                };

                int batatinha = db.Database.SqlQuery<int>(query, parameters).Single();

            

                 query = @"INSERT INTO pessoas_juridicas (senha,email,cnpj,cep,razao_social,nome,uf,cidade,usuario_id) VALUES (@senha,@email,@cnpj,@cep,@razao_social,@nome_fantasia,@uf,@cidade,@usuario_id)";

                parameters = new[]

                {
            new MySqlParameter("@senha", txtSenha),

            new MySqlParameter("@email",txtEmail),

            new MySqlParameter("@cnpj",txtCnpj ),

            new MySqlParameter("@cep",txtCep),

            new MySqlParameter("@razao_social",txtRazão),

            new MySqlParameter("@nome",txtNome),

            new MySqlParameter("@uf",txtUf),

            new MySqlParameter("@cidade",txtCidade),

            new MySqlParameter("@usuario_id", batatinha),



            };



                int rowsAffected = db.Database.ExecuteSqlCommand(query, parameters);

            }








            Form frmPlanos = new frmPlanos();
            frmPlanos.WindowState = FormWindowState.Maximized;
            frmPlanos.Show();

        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {


        }
        private void btnVoltar1_Click(object sender, EventArgs e)
        {
            Form frmVoltar = new frmLogin();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRazão_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


