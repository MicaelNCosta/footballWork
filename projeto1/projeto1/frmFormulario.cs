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
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();

        }
        
           //* string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            
        

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
    }
}