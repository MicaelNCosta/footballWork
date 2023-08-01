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
    public partial class frmEsqueceuSenha : Form
    {
        public frmEsqueceuSenha()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formVoltar = new frmLogin();
            formVoltar.Show();
        }

        bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return System.Text.RegularExpressions.Regex.IsMatch(email, pattern);
        }

        private void btnRedefinir_Click(object sender, EventArgs e)
        {
            string email = txtEmailRecapSenha.Text;

            if (IsValidEmail(email))
            {
                MessageBox.Show("Um Email foi enviado para o destinatario para fazer a alterção de senha");
            }
            else
            {
                MessageBox.Show("Endereço de e-mail inválido!");
            }
        }
    }
}
