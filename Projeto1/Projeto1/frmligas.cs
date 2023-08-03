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
    public partial class frmligas : Form
    {
        public frmligas()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string txt = "";
            int contador = 0;
            if (chInglesa.Checked)
            {
                txt += chInglesa.Text + " |Liga inglesa ";
                contador++;
            }
            if (chFrancesa.Checked)
            {
                txt += chFrancesa.Text + " |Liga Francesa";
                contador++;
            }
            if (chAlema.Checked)
            {
                txt += chAlema.Text + " |LigaAlema";
                contador++;
            }
            if (chEspanhola.Checked)
            {
                txt += chEspanhola.Text + "|Liga Espanhola";
                contador++;
            }
            if (chItaliana.Checked)
            {
                txt += chItaliana.Text + "|Liga Italiana";
                contador++;
            }

            if (contador > 3)
            {
                MessageBox.Show("Selecione Apenas 3 Ligas");
                return;
            }
            else { 
                MessageBox.Show(txt);
             }
        }
           
       
            
        

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            chEspanhola.Checked = false;
            chFrancesa.Checked = false;
            chInglesa.Checked = false;
            chItaliana.Checked = false;
            chAlema.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            this.Hide();
        }

        private void chItaliana_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chItalia_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
