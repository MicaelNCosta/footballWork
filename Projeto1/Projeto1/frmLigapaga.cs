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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string txt = "";
            
            if (chInglesa.Checked )
            {
                txt += chInglesa.Text + " Liga inglesa |";
                
            }
            if (chFrancesa.Checked)
            {
                txt += chFrancesa.Text +  " Liga Francesa |";
                
            }
            if (chAlema.Checked)
            {
                txt += chAlema.Text + " LigaAlema |";
                
            }
            if (chEspanhola.Checked)
            {
                txt += chEspanhola.Text + " Liga Espanhola |";
                
            }
            if (chItalia.Checked)
            {
                txt += chItalia.Text + " Liga Italiana |";            
              
            }

            MessageBox.Show(txt ,"Ligas selecionadas : ");
                      
           
            
             
            





        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            this.Hide();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            chEspanhola.Checked = false;
            chFrancesa.Checked = false;
            chInglesa.Checked = false;
            chItalia.Checked = false;
            chAlema.Checked = false;
        }

        private void chItalia_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
