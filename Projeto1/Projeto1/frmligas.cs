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
            if (chPortuguesa.Checked)
            {
                txt += chPortuguesa.Text + " |Liga Portuguesa";
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
            chPortuguesa.Checked = false;
        }
    }
}
