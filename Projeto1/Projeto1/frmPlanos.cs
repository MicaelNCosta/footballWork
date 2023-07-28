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
    public partial class frmPlanos : Form
    {
        public frmPlanos()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string planos = "";
            string plano1 = "";
            if (rbGratuito.Checked)
            {
                planos = "Plano Gratuito";
                MessageBox.Show("Parabens você selecionou o nosso plano gratuito");
            }

            else if (rbPremiun.Checked)
            {
                plano1 = " Plano Gratuito";
                Form Form1 = new frmPagamento();
                Form1.Show();
            }
        }

        private void cbGratuito_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void frmPlanos_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void gbPlanos_Enter(object sender, EventArgs e)
        {
            
        }

        private void rbPremiun_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
