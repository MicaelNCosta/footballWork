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
using System.Data.Entity;

using System.Data.Entity.ModelConfiguration.Conventions;

using MySql.Data.MySqlClient;


namespace projeto1
{
    public partial class frmPessoasfisicas : Form
    {
        int formulario_id;
        public frmPessoasfisicas(int formulario_id)
        {
            this.formulario_id = formulario_id;
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

            if (txtTelefone.Text == "Obrigatorio prencher tudo")
            {
                MessageBox.Show("Obrigatorio prencher tudo");
                return;
            }
            MessageBox.Show("usuario Cadastrado");

            string cep = txtCep.Text;
            string Endereco = txtEndereco.Text;
            string Cpf = txtCpf.Text;
            string Senha = txtSenha.Text;
            string Nome = txtNome.Text;
            string Email = txtEmail.Text;
            string Telefone = txtTelefone.Text;
            string data_de_nacimento = dtp_data_de_nacimento.Text;



            using (MyDbContext db = new MyDbContext())

            {

                string query = @"INSERT INTO usuarios (nome, endereco, telefone, email, senha, formulario_id ) VALUES (@pnome, @pendereco, @ptelefone, @pemail, @psenha, @pformulario_id); SELECT LAST_INSERT_ID();";

                var parameters = new[]

                {

                    new MySqlParameter("@pnome", Nome),


                    new MySqlParameter("@pendereco", Endereco),

                    new MySqlParameter("@ptelefone", Telefone),

                    new MySqlParameter("@pemail", Email),

                    new MySqlParameter("@psenha", Senha),

                    new MySqlParameter("@pformulario_id", this.formulario_id),

                };

                int batatinha = db.Database.SqlQuery<int>(query, parameters).Single();



                query = @"INSERT INTO Pessoas_fisicas (cpf, data_de_nacimento, cep, endereco, usuario_id) VALUES (@pCpf, @pdata_de_nacimento, @pcep, @pendereco, @pUsuario_id);";

                parameters = new[]

                {

                    new MySqlParameter("@pcpf", Cpf),

                    new MySqlParameter("@pdata_de_nacimento", data_de_nacimento),

                    new MySqlParameter("@pcep",cep) ,

                    new MySqlParameter("@pendereco", Endereco),

                    new MySqlParameter("@pusuario_id", batatinha),

                };



                int nRowAfetted = db.Database.ExecuteSqlCommand(query, parameters);


            }



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

