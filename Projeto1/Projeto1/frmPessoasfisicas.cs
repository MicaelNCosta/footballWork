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
    public partial class frmPessoasfisicas : Form
    {
        public frmPessoasfisicas()
        {
            InitializeComponent();
        }

        private void btnCadastre_Click(object sender, EventArgs e)
        {
            MessageBox.Show( " usuario cadastrado");
            
            {
                btnCadastre.Enabled = false;
            }     
            else
            {
                btnCadastre.Enabled = true;
            }
              
           
            {
                MessageBox.Show("this i am enabled");
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                btnCadastre.Enabled = false;
            }
            else
            {
                btnCadastre.Enabled = true;
            }
              private void txtEmail_click(object sender, EventArgs e)

            {
                MessageBox.Show("this i am enabled");
            }     
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                btnCadastre.Enabled = false;
            }
            else
            {
                btnCadastre.Enabled = true;
            }
            private void txtNome_click(object sender, EventArgs e)
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

         if (txtSenha.Text == "")
            {
                btnCadastre.Enabled = false;
            }     
            else
            {
                btnCadastre.Enabled = true;
            }
            private void btnCadastre_click(object sender, EventArgs e)
    }

        private void txtData_TextChanged(object sender, EventArgs e)
        {
            if (txtData.Text == "")
            {
                btnCadastre.Enabled = false;
            }
            else
            {
                btnCadastre.Enabled = true;
            }
            {
                private void btnData_click(object sender, EventArgs e)
        }   }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            if (txtCpf.Text == "")
            {
                btnCadastre.Enabled = false;
            }
            else
            {
                btnCadastre.Enabled = true;
            }
            private void txtCpf_click(object sender, EventArgs e)
        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {
            if (txtCep.Text == "")
            {
                btnCadastre.Enabled = false;
            }
            else
            {
                btnCadastre.Enabled = true;
            }
            private void txtCep_click(object sender, EventArgs e)
        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {
            if (txtEndereco.Text == "")
            {
                btnCadastre.Enabled = false;
            }
            else
            {
                btnCadastre.Enabled = true;
            }
            private void txtEndereco_click(object sender, EventArgs e)
        }
    }
