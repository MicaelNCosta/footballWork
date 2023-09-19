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
            string txt = null;


            int contador = 0;

            if (chInglesa.Checked)
            {
                txt = "LigaInglesa";
                contador++;
            }
            if (chFrancesa.Checked)
            {
                txt = "LigaFrancesa";
                contador++;
            }
            if (chAlema.Checked)
            {
                txt = "LigaAlema";
                contador++;
            }
            if (chEspanhola.Checked)
            {
                txt = "LigaEspanhola";
                contador++;
            }
            if (chItaliana.Checked)
            {
                txt = "LigaItaliana";
                contador++;
            }

            if ((!this.pagamentos && !(chInglesa.Checked ^ chFrancesa.Checked ^ chAlema.Checked ^ chEspanhola.Checked ^ chItaliana.Checked)))
            {
                MessageBox.Show("Metodo gratuito só pode selecionar uma liga");
                return;
            }


            if (contador > 0)
            {
                Form telaPri1 = new frmTelaInicial1(txt);
                telaPri1.WindowState = FormWindowState.Maximized;
                telaPri1.Show();
            }
            else
            {
                MessageBox.Show("Selecione pelo menos uma liga");
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
            Form planos = new frmPlanos(1);
            planos.WindowState = FormWindowState.Maximized;
            planos.Show();
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
