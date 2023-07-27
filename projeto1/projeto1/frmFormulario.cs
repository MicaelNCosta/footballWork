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
                    
            
            MessageBox.Show("Obrigado por responder o formulário.", "Fomulário finalizado", MessageBoxButtons.OK ,MessageBoxIcon.Information);
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            rb1.Checked = false;
            rb2.Checked = false;
            rb3.Checked = false;
            rb4.Checked = false;
            rb5.Checked = false;
            rb6.Checked = false;
            rb7.Checked = false;
            rb8.Checked = false;
            rb9.Checked = false;
            rb10.Checked = false;
            rb11.Checked = false;

            cbLigas.Text = "";
            txtVoce.Text = "";
            txtEmail.Text = "";
        }


        private void frmCadastro_Load(object sender, EventArgs e)
        {
            btnFinalizar.Enabled = false;
        }


        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (rb10.Enabled)
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
            if (rb10.Enabled)
            {
                txtEmail.Enabled = true;
            }
            else
            {
                txtEmail.Enabled = false;
            }
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
    }
}