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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
           
        }

              

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form frmLogin = new frmLogin();
            frmLogin.WindowState = FormWindowState.Maximized;
            frmLogin.Show();
            this.Hide();
        }
    }
}
