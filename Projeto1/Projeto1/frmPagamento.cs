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
    public partial class frmPagamento : Form
    {
        public frmPagamento()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbCpf_CheckedChanged(object sender, EventArgs e)
        {
            lblCpf.Visible = true;
            lblCnpj.Visible = false;



            mskCpf.Visible = true;



            mskCnpj.Visible = false;
        }

        private void lblCnpj_Click(object sender, EventArgs e)
        {

        }

        private void rbCnpj_CheckedChanged(object sender, EventArgs e)
        {
            lblCpf.Visible = false;
            lblCnpj.Visible = true;



            mskCnpj.Visible = true;



            mskCpf.Visible = false;
        }

        private void frmPagamento_Load(object sender, EventArgs e)
        {
            btnProsseguir.Enabled = false;
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtSenha.Enabled)
            {
                btnProsseguir.Enabled = true;
            }
        }

        private void btnProsseguir_Click(object sender, EventArgs e)
        {
            
        }
    }
}
