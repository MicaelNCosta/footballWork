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
        int usuario_id;
        public frmPlanos(int usuario_id)
        {
            this.usuario_id = usuario_id;
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

                Form frmligas = new frmligas(true);
                frmligas.WindowState = FormWindowState.Maximized;
                frmligas.Show();
            }

            else if (rbPremiun.Checked)
            {
                plano1 = " Plano Gratuito";
                Form Form1 = new frmPagamento(this.usuario_id);
                Form1.Show();
            }
            this.Hide();
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
