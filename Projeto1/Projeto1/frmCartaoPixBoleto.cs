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
    public partial class frmCartaoPixBoleto : Form
    {
        public frmCartaoPixBoleto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (rbCartao.Checked)
            {
                Form Form1 = new frmPagamento();
                Form1.Show();                

            }
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Form Form1 = new frmPlanos();
            Form1.WindowState = FormWindowState.Maximized;
            Form1.Show();
        
        }
    }   
}
