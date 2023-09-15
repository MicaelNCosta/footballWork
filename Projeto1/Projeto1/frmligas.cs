using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using projeto1.models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using MySql.Data.MySqlClient;


namespace projeto1
{
    public partial class frmligas : Form
    {
        bool pagamentos;
        public frmligas(bool pagamentos)
        {
            this.pagamentos = pagamentos;
            InitializeComponent();

         

        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string txt = "";
            int contador = 0;

          /*  if(!(!this.pagamentos && (chInglesa.Checked ^ chFrancesa.Checked ^ chAlema.Checked ^ chEspanhola.Checked ^ chItaliana.Checked)))
            {
                MessageBox.Show("Metodo gratuito só pode selecionar uma liga");
            }
            else if (this.pagamentos && contador == 1)
            {
                Form form1 = new frmtimes(txt);
                form1.Show();

            }*/

            if (chInglesa.Checked)
            {
                txt += chInglesa.Text + " 'Liga inglesa',";
                contador++;
            }
            if (chFrancesa.Checked)
            {
                txt += chFrancesa.Text + " 'Liga Francesa',";
                contador++;
            }
            if (chAlema.Checked)
            {
                txt += chAlema.Text + " 'Liga Alema',";
                contador++;
            }
            if (chEspanhola.Checked)
            {
                txt += chEspanhola.Text + "'Liga Espanhola',";
                contador++;
            }
            if (chItaliana.Checked)
            {
                txt += chItaliana.Text + "'Liga Italiana',";
                contador++;
            }

            if (!(!this.pagamentos && (chInglesa.Checked ^ chFrancesa.Checked ^ chAlema.Checked ^ chEspanhola.Checked ^ chItaliana.Checked)))
            {
                MessageBox.Show("Metodo gratuito só pode selecionar uma liga");

            }


            if (this.pagamentos && contador == 1)
            {
                Form form1 = new frmtimes(txt);
                form1.Show();

            }

            /* if (this.pagamentos && contador == 1)
             {
                 Form form1 = new frmtimes(txt);
                 form1.Show();

             }

             if(!this.pagamentos && contador == 1){

                 Form form1 = new frmtimes(txt);
                 form1.Show();
             }*/

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

        private void frmligas_Load(object sender, EventArgs e)
        {

        }
    }
}
