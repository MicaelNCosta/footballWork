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

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            lbl1.Text = " Definição do objetivo do sistema : Construir um banco de dados para futura vendas \n" +
            "Buscar conhecimento para evoluir";
                                           
            
            string[,] sowt = new string[2, 2];

            sowt[0, 0] = "FORÇAS \n" +
            "\n" +
            " Juntar informações \n" +
            " Buscar dados em diferentes fontes \n" +
            " Investiment de tempo";

            sowt[0, 1] = "FRAQUEZAS \n " + 
            "\n" +
            " Inexperiencia em trabalhar com dados \n" +
            " Perca de oportunidades \n " +
            " Falta de conhecimento";

            sowt[1, 0] = " OPORTUNIDADES \n" +
            "\n" +
            "Alta demanda de comercialização de dados \n " +
            "grande comercio \n" +
            " Expansão do mercado na area de tecnologia ";

            sowt[1, 1] = "AMEAÇAS \n" +
            "\n" +
            "Infringir as leis do país ex. LGPD \n " +
            "Vazamento de dados \n" +
            "Competidores consolidados no mercado";

            lblForca.Text = sowt[0, 0];
            lblFraqueza.Text = sowt[0, 1];
            lblOportunidades.Text = sowt[1, 0];
            lblAmeacas.Text = sowt[1, 1];


            string[] vetor = new string[6];
            string textodeapi = "";


            vetor[0] = "https://brasilapi.com.br/docs#tag/IBGE ";
            vetor[1] = "https://aws.amazon.com/pt/transcribe/";
            vetor[2] = "https://www.gov.br/conecta/catalogo/apis/cadastro-base-do-cidadao-cbc-cpf/swagger-v2.json/swagger_view";
            vetor[3] = "Api 4";
            vetor[4] = "Api 5";
            vetor[5] = "Api 6";
      
            for (int i =0; i < vetor.Length; i++)
            {
                textodeapi += vetor[i] + "\n";
            }

            lblApis.Text = textodeapi;
           


                
           




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRes_Click(object sender, EventArgs e)
        {
          
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
                       
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            string pergunta1 = txt1.Text;
            string pergunta2 = txt2.Text;
            string pergunta3 = txt3.Text;




            if (pergunta1 == "sim" && pergunta2 == "sim" && pergunta3 == "sim")
            {
               btnRes.Text = "APROVADO";

                btnRes.ForeColor = Color.Green;
            }
            else 
            {
                btnRes.Text = "REPROVADO";

                btnRes.ForeColor = Color.Red;
            }
        }
    }
}
