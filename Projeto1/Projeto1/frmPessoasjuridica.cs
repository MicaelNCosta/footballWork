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
    public partial class frmPessoasjuridica : Form
    {
        public frmPessoasjuridica()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtCnpj.Text == "")

            {
                MessageBox.Show(" Obrigatorio preencher tudo ");
                return;
            }
            if (txtRazão.Text == "Obrigatorio preencher tudo ")
            {
                MessageBox.Show(" Obrigatorio preencher tudo ");
                return;
            }
            if (txtNome.Text == " Obrigario preencher tudo ")
            {
                MessageBox.Show(" Obrigario preencher tudo ");
                return;
            }
            if (txtPessoa.Text == "")
            {
                MessageBox.Show(" Obrigatorio preencher tudo ");
                return;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Obrigatorio preencher tudo ");
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
            MessageBox.Show(" Usuario cadrastrado");

        }
    }
}
