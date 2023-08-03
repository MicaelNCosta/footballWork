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
    public partial class frmLigapaga : Form
    {
        public frmLigapaga()
        {
            InitializeComponent();
        }

        private void frmLigapaga_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string txt = "";
            
            if (chInglesa.Checked)
            {
                txt += chInglesa.Text + " |Liga inglesa ";
                
            }
            if (chFrancesa.Checked)
            {
                txt += chFrancesa.Text + " |Liga Francesa";
                
            }
            if (chPortuguesa.Checked)
            {
                txt += chPortuguesa.Text + " |Liga Portuguesa";
               
            }
            if (chEspanhola.Checked)
            {
                txt += chEspanhola.Text + "|Liga Espanhola";
                
            }
            if (chItaliana.Checked)
            {
                txt += chItaliana.Text + "|Liga Italiana";
                
            }

            
            else
            {
                MessageBox.Show(txt);
            }
        }
    }
}
