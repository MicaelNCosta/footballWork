using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void lblSistema_Click(object sender, EventArgs e)
        {
            lblSistema.Text = "Definição do objetivo do  sistema: venda de dados \n" +

                "requisito funcional :   As principais funções, que sem elas  o sistema  não funcionariam \n" +

                "ex: login e senha \n" +

                "requisitos não funcionais : tudo que não esta ligado ao desinvolvimento do sistema\n" +


                "EX: designer , interface";
                            
        }

        private void lblforca(object sender, EventArgs e)
        {


            string[,] swot = new string[2, 2];
            swot[0, 0] = "Forças \n" +
               " \n" +
         "-capacidade de coletar informções \n" +
               "\n " +
            "-Buscar dados de diferentes Fontes";


            swot[0, 1] = "Fraquezas   \n" +
                "\n" +
            " - inexperiencia em trabalhar com vendas de dados   \n" +
                " \n" +

                "-Perca de oportunidades por falta de experiencia";




            swot[1, 0] ="Oportunidades \n" +
                "\n" +
             "-Alta demanda de comercialização de dados \n" +
                " \n" +
                "-Mercado de tecnologia em expansão";



            swot[1, 1] = "Ameaças \n " +

                "\n  " +
              "-infringir as leis do pais  \n" +
                "ex : lgpd\n  " +
                "-Vazamento de dados";

            lblForca.Text = swot[0, 0];
            lblFraqueza.Text = swot[0, 1];
         lblOportunidades.Text = swot[1, 0];
            lblAmeacas.Text = swot[1, 1];





        }

        private void lblApi(object sender, EventArgs e)
        {

            string[] arrey = new string[6];
            string textodeapi = "";




            arrey[0] = "Api Linkdin";
            arrey[1] = "https://brasilapi.com.br/docs#tag/IBGE";
            arrey[2] = "";
            arrey[3] = "Api 4";
            arrey[4] = "Api 5";
            arrey[5] = "Api 6";

            for (int j = 0; j < arrey.Length; j++)
            {
                textodeapi += arrey[j] + "\n";
            }



            lblApi1.Text = textodeapi;









        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            
               


            


                }

        private void btn1_Click(object sender, EventArgs e)
        {


            if (txt1.Text == "Não" && txt2.Text == txt1.Text) 
            {
                lblVerificar.Text = "reprovado";
            }
            
               else  if(txt1.Text == "Sim" && txt2.Text == "Sim")
            {
               
                 lblVerificar.Text = "Aprovado";  
            }
            else
            {
                lblVerificar.Text = "reprovado";
            }
            
                
                 
        }
    }
}
