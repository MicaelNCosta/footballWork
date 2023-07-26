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
            MessageBox.Show("Obrigado por finalizar o formulario");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cbAva = null;
            cbIni = null;
            cbInter = null;
            cbNao = null;
            cbNao2 = null;
            cbNão3 = null;
            cbSIM = null;
            cbSim2 = null;
            cbSim3 = null;
            cbLigas.Text = "";
            txtVoce.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}