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
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void bntFinalizar_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Obrigado por responder o formulário.", "Fomulário finalizado");
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            
            cbLigas.Text = "";
            txtVoce.Text = "";
            txtEmail.Text = string.Empty;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            //btnFinalizar.Enabled = !string.IsNullOrWhiteSpace(txtVoce.Text);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Enabled)
            {
                txtEmail.Enabled = false;
            }
            else
            {
                txtEmail.Enabled = true;
            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Enabled)
            {
                txtEmail.Enabled = true;
            }
            else
            {
                txtEmail.Enabled = false;
            }
        }
    }
}