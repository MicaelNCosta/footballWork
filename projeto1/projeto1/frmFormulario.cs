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
using MySql.Data.MySqlClient;
using projeto1.Models;
using System.ComponentModel.DataAnnotations.Schema; 
using System.Data.Entity; 
using System.Data.Entity.ModelConfiguration.Conventions; 

namespace projeto1
{
    public partial class frmCadastro : Form
    {
        string acesso;
        string acesso2;
        int formulario_id;
       /* public frmPessoasjuridica(int formulario_id)
        {
            this.formulario_id = formulario_id;
            InitializeComponent();
        }*/

        public frmCadastro(string acesso, string acesso2)

        {
            this.acesso = acesso;
            this.acesso2 = acesso2;

            InitializeComponent();

        }
        
           // string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            
        

        private void bntFinalizar_Click(object sender, EventArgs e)
        {

            string iniciante = "";            
            string frequencia = "";
            string consumo = "";
            string emailtelefone = "";            
            string indica = "";
            string trabalha = "";
            string ligas = cbLigas.Text;
            string voce = txtVoce.Text;




            if (rb1.Checked)
            {
                trabalha = "SIM";
            }
            else if (rb2.Checked)
            {
                trabalha = "NÃO";
            }

            if (rb3.Checked)
            {
                frequencia = "SIM";
            }
            else if (rb4.Checked)
            {
                frequencia = "NÃO";
            }

            if (rb5.Checked)
            {
                consumo = "CONSUMO";
            }
            else if (rb6.Checked)
            {
                consumo = "VENDA";
            }


            if (rbEmail.Checked)
            {
                emailtelefone = "EMAIL : " + txtEmail.Text;
            }
            else if (rbTelefone.Checked)
            {
                emailtelefone = "TELEFONE : " + mskNumero.Text;
            }



            if (rbFinalS.Checked)
            {
                indica = "SIM";
            }
            else if (rbFinalN.Checked)
            {
                indica = "NÃO";
            }



            if (rb7.Checked)
            {
                iniciante = "Iniciante";
                    
            }
            else if (rb8.Checked)
            {
                iniciante = "Intermediario";                
            }
            else if (rb9.Checked)
            {
                iniciante = "Avançado";
            }




            MessageBox.Show("RESPOSTAS SELECIONADAS\n" +
                "\n"+
                "liga selecionada : " + ligas + "\n" +                
                "\n" +
                "Trabalha com futebol ? = " + trabalha + "\n" +
                "\n" +
                "Qual seu nivel de conhecimento em futebol ? = " + iniciante + "\n" +
                "\n" + 
                "Você acompanha futebol com frequencia ? = " + frequencia + "\n" +
                "\n" +
                "Pretende usar para venda ou cosumo proprio ? = " + consumo + "\n" +
                "\n" +
                "Deseja receber notificações por e - mail ou por telefone ? =\n" +
                emailtelefone + "\n" +
                "\n" +
                "Você indicaria o FootbolWork ? = " + indica + "\n" +
                "\n" + 
                "Sobre você : " + voce + "\n" +
                "\n" + 
                "\n" +
                "Obrigado por responder o formulário.", "Fomulário finalizado", MessageBoxButtons.OK);//MessageBoxIcon.Information);

            //LAST_INSERT_ID())
            using (MyDbContext db = new MyDbContext())

            {
                bool csim = rb1.Checked; // Obtém o estado do RadioButton

                bool csim2 = rb3.Checked;

                bool csim3 = rb5.Checked;

                bool csim4 = rbEmail.Checked;

                bool csim5 = rbFinalS.Checked;



                int bsim = csim ? 1 : 0; // Converte para 1 ou 0             

                int bsim2 = csim2 ? 1 : 0;

                int bsim3 = csim3 ? 1 : 0;

                int bsim4 = csim4 ? 1 : 0;

                int bsim5 = csim5 ? 1 : 0;


                string query = @"INSERT INTO formularios (pergunta_1, pergunta_2, pergunta_3, pergunta_5, pergunta_6, sobre) VALUES (@pergunta_1, @pergunta_2, @pergunta_3, @pergunta_5, @pergunta_6, @sobre)";
                             

                var parameters = new[]

                {


                    new MySqlParameter("@pergunta_1", bsim ),

                    new MySqlParameter("@pergunta_2", bsim2 ),

                    new MySqlParameter("@sobre", voce),

                    new MySqlParameter("@pergunta_3", bsim3),

                    new MySqlParameter("@pergunta_5", bsim4),

                    new MySqlParameter("@pergunta_6", bsim5),
                                        
                };



                int rowsAffected = db.Database.ExecuteSqlCommand(query, parameters);
              
            }

        if (acesso == "juridico")
        {
                Form juridico = new frmPessoasjuridica(formulario_id);                
                juridico.WindowState = FormWindowState.Maximized;
                juridico.Show();
        }

            if (acesso2 == "fisico")
            {
                Form fisico = new frmPessoasfisicas(formulario_id);
                fisico.WindowState = FormWindowState.Maximized;
                fisico.Show();
            }
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            rb1.Checked = rb2.Checked = rb3.Checked = rb4.Checked = rb5.Checked = rb6.Checked = rb7.Checked = rb8.Checked = rb9.Checked = rbEmail.Checked = rbTelefone.Checked = false;

            cbLigas.Text = txtVoce.Text = txtEmail.Text = cbLigas.Text = txtVoce.Text = txtEmail.Text = "";
        }


        private void frmCadastro_Load(object sender, EventArgs e)
        {
            btnFinalizar.Enabled = false;

        }


        private void rbTelefone_CheckedChanged(object sender, EventArgs e)
        {
            lblTel.Visible = true;
            lblEmail.Visible = false;

            mskNumero.Visible = true;

            txtEmail.Visible = false;

        }

        private void rbEmail_CheckedChanged(object sender, EventArgs e)
        {
            lblEmail.Visible = true;
            lblTel.Visible = false;

                mskNumero.Visible = false;
            
                txtEmail.Visible = true;
            
        }
                
        private void cbLigas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string TIME = cbLigas.SelectedItem.ToString();
            lblTimeeee.Text = TIME;
        }

        private void rbFinalN_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbFinalN_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbFinalN.Checked)
            {
                btnFinalizar.Enabled = true;
            }
        }

        private void rbFinalS_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFinalS.Checked)
            {
                btnFinalizar.Enabled = true;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtEmail_Validated(object sender, EventArgs e)
        {
            string email = txtEmail.Text;

            Regex regex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            if (!regex.IsMatch(email))
            {
                MessageBox.Show("Email inválido");
            }
        }

        private void mskNumero_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form login = new frmLogin();
            login.WindowState = FormWindowState.Maximized;
            login.Show();
        }
    }
}
/*
using (MyDbContext db = new MyDbContext())
{
    // Supondo que você tenha obtido o ID do usuário de algum lugar, vamos chamá-lo de 'userId'
    int userId = ObterIdDoUsuario(); // Substitua isso pela lógica real de obtenção do ID

    string query = @"INSERT INTO formularios (pergunta_1, pergunta_2, pergunta_3, pergunta_5, pergunta_6, sobre, usuario_id) 
                    VALUES (@pergunta_1, @pergunta_2, @pergunta_3, @pergunta_5, @pergunta_6, @sobre, @usuario_id)";

    bool csim = rb1.Checked;
    bool csim2 = rb3.Checked;
    bool csim3 = rb5.Checked;
    bool csim4 = rbEmail.Checked;
    bool csim5 = rbFinalS.Checked;

    int bsim = csim ? 1 : 0;
    int bsim2 = csim2 ? 1 : 0;
    int bsim3 = csim3 ? 1 : 0;
    int bsim4 = csim4 ? 1 : 0;
    int bsim5 = csim5 ? 1 : 0;

    var parametros = new[]
    {
        new MySqlParameter("@pergunta_1", bsim ),
        new MySqlParameter("@pergunta_2", bsim2 ),
        new MySqlParameter("@sobre", voce),
        new MySqlParameter("@pergunta_3", bsim3),
        new MySqlParameter("@pergunta_5", bsim4),
        new MySqlParameter("@pergunta_6", bsim5),
        new MySqlParameter("@usuario_id", userId), // Use o ID do usuário obtido aqui
    };

    int linhasAfetadas = db.Database.ExecuteSqlCommand(query, parametros);
}
*/