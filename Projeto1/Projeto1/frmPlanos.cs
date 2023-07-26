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

            string txt = "";
            if (cbGratuito.Checked)
            {
                txt += cbGratuito.Text + " |parabens você selecionou o nosso plano gratuito";
            }
            
                if (cbPremiun.Checked) 
            
            {
                txt += cbPremiun.Text + " |parabens você selecionou o nosso plano premiun";
                MessageBox.Show(txt);   
            }
                

            
                
            
        }

        private void cbGratuito_CheckedChanged(object sender, EventArgs e)
        {
            

        }
    }
}
